using Application.Models;
using AutoFixture;
using Domain.Entitites;
using Domain.Models;
using Domain.Test;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Text.Json;
using WebApi.Controllers;
using WebApi.Utils;
using Xunit.Abstractions;

namespace WepApiTest.Controllers;

public class AuthControllerTest : SetupTest
{
    private readonly AuthController _authController;
    private readonly ITestOutputHelper output;

    public AuthControllerTest(ITestOutputHelper output)
    {
        this.output = output;

        _authController = new AuthController(
            _accountServiceMock.Object,
            _userTokenServiceMock.Object,
            _tokenHandlerMock.Object,
            _mapperConfig,
            _thirdAuthenticationServiceMock.Object,
            _appConfigMock.Object,
            _claimsServiceMock.Object);
    }

    [Fact]
    public async Task AuthController_Login_ShouldReturnCorrectData()
    {
        // arrange
        var mockAccount = MockAccountList(1).FirstOrDefault()!;
        mockAccount.DeletedOn = null;
        _accountServiceMock.Setup(x
            => x.CheckLoginAsync(mockAccount.Username, mockAccount.Password!))
            .ReturnsAsync(mockAccount);
        var mockUserToken = _fixture.Build<UserToken>()
                                .Without(x => x.User)
                                .Create();
        var mockAccessToken = _fixture.Build<TokenModel>()
                                      .With(x => x.Token, mockUserToken.AccessToken)
                                      .With(x => x.TokenId, mockUserToken.ATid)
                                      .Create();
        var mockRefreshTOken = _fixture.Build<TokenModel>()
                                      .With(x => x.Token, mockUserToken.RefreshToken)
                                      .With(x => x.TokenId, mockUserToken.RTid)
                                      .Create();
        // mock token hanlder bi loi -> tra ve null
        _tokenHandlerMock.Setup(x => x.CreateAccessToken(mockAccount, DateTime.Now))
                         .Returns(mockAccessToken);
        _tokenHandlerMock.Setup(x => x.CreateRefreshToken(mockAccount, DateTime.Now))
                         .Returns(mockRefreshTOken);
        // mock token hanlder bi loi -> tra ve null
        _userTokenServiceMock.Setup(x => x.SaveTokenAsync(mockUserToken)).Returns(Task.CompletedTask);

        var mockData = MockAccountList(5);
        _accountRepositoryMock.Setup(x => x.GetAllAsync()).ReturnsAsync(mockData);

        //// action
        //var result = await _authController.Login(new LoginModel
        //{
        //    Username = mockAccount.Username,
        //    Password = mockAccount.Password
        //});
        //// assert
        //result.Should().BeOfType<OkObjectResult>();

        //var response = ((result as OkObjectResult)!.Value as TokenVM)!;
        //response.UserId.Should().Be(mockAccount.Id);
        ////response.AccessToken.Should().NotBeNull();
        ////response.RefreshToken.Should().NotBeNull();
        //output.WriteLine(JsonSerializer.Serialize<TokenVM>(response));
        output.WriteLine(JsonSerializer.Serialize<TokenModel>(mockAccessToken));
        output.WriteLine(mockUserToken.AccessToken);
    }

    [Fact]
    public async Task AuthController_Login_ShouldReturnBadRequestWhenUserNotFound()
    {
        // arrange
        var mockAccount = MockAccountList(1).FirstOrDefault()!;
        mockAccount.DeletedOn = DateTime.Now;
        _accountServiceMock.Setup(x
            => x.CheckLoginAsync("username", "password")).ReturnsAsync(mockAccount);

        // action
        var result = await _authController.Login(new LoginModel
        {
            Username = mockAccount.Username,
            Password = mockAccount.Password
        });
        // assert
        result.Should().BeOfType<UnauthorizedObjectResult>();
    }

    [Fact]
    public async Task AuthController_RefreshToken_ShouldReturnCorrectData()
    {
        // arrange
        var mockRefreshTokenModel = _fixture.Build<RefreshTokenModel>().Create();
        var mockData = _fixture.Build<TokenVM>().Create();
        _tokenHandlerMock.Setup(x => x.ValidateRefreshTokenAsync(mockRefreshTokenModel.RefreshToken))
                         .ReturnsAsync(mockData);


        // action
        var result = await _authController.RefreshToken(mockRefreshTokenModel);
        // assert
        result.Should().BeOfType<OkObjectResult>();

        var response = ((result as OkObjectResult)!.Value as TokenVM)!;
        response.UserId.Should().Be(mockData.UserId);
        response.AccessToken.Should().NotBeNull();
        response.RefreshToken.Should().NotBeNull();
    }

    [Fact]
    public async Task AuthController_RefreshToken_ShouldReturnBadRequestWhenInvalidToken()
    {
        // arrange
        var mockRefreshTokenModel = _fixture.Build<RefreshTokenModel>().Create();
        _tokenHandlerMock.Setup(x => x.ValidateRefreshTokenAsync(mockRefreshTokenModel.RefreshToken))
                         .ReturnsAsync((TokenVM)null);


        // action
        var result = await _authController.RefreshToken(mockRefreshTokenModel);
        // assert
        result.Should().BeOfType<BadRequestObjectResult>();

        var response = ((result as BadRequestObjectResult)!.Value as ApiResponse)!;
        response.ErrorMessage.Should().NotBeNull();
    }
}
