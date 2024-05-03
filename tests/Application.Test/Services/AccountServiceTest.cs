using Application.Models;
using Application.Services;
using Application.Services.Abstractions;
using AutoFixture;
using Domain.Entitites;
using Domain.Test;
using Microsoft.AspNetCore.Http;
using Moq;

namespace Application.Test.Services;

public class AccountServiceTest : SetupTest
{
    private readonly IAccountService _accountService;

    //private readonly Mock<IClaimService> _claimServiceMock;
    //private readonly Mock<IUnitOfWork> _unitOfWorkMock;
    //private readonly IMapper _mapper;

    public AccountServiceTest()
    {
        _accountService = new AccountService(
            _unitOfWorkMock.Object,
            _claimsServiceMock.Object,
            _firebaseServiceMock.Object,
            _mapperConfig);
    }

    [Fact]
    public async Task GetAccountByIdAsync_WithValidAccountId_ReturnsAccountVM()
    {
        // Arrange
        var accountId = Guid.NewGuid();
        var newAccount = _fixture.Build<Account>().Create();
        newAccount.Id = accountId;
        newAccount.DeletedOn = null;
        _unitOfWorkMock.Setup(repo => repo.AccountRepository.GetByIdAsync(accountId))
                       .ReturnsAsync(newAccount);

        // Act
        var result = await _accountService.GetAccountByIdAsync(accountId);

        // Assert
        Assert.NotNull(result);
        Assert.IsType<AccountVM>(result);
    }

    [Fact]
    public async Task GetAccountByIdAsync_WithDeletedAccount_ThrowsKeyNotFoundException()
    {
        // Arrange
        var accountId = Guid.NewGuid();
        var newAccount = _fixture.Build<Account>().Create();
        newAccount.Id = accountId;
        newAccount.DeletedOn = DateTime.UtcNow;

        _unitOfWorkMock.Setup(repo => repo.AccountRepository.GetByIdAsync(accountId))
                       .ReturnsAsync(newAccount);

        // Act & Assert
        await Assert.ThrowsAsync<KeyNotFoundException>(() => _accountService.GetAccountByIdAsync(accountId));
    }

    [Fact]
    public async Task GetAccountByIdAsync_WithBlockedAccount_ThrowsBadHttpRequestException()
    {
        // Arrange
        var accountId = Guid.NewGuid();
        var account = _fixture.Build<Account>().Create();
        account.Id = accountId;
        account.DeletedOn = null;
        var loginId = Guid.NewGuid();
        _claimsServiceMock.Setup(claimService => claimService.GetCurrentUserId)
                         .Returns(loginId);
        _unitOfWorkMock.Setup(repo => repo.AccountRepository.GetByIdAsync(accountId))
                       .ReturnsAsync(account);
        _unitOfWorkMock.Setup(repo => repo.BlockRepository.IsBlockedOrBlockingAsync(loginId, accountId))
                       .ReturnsAsync(true);

        // Act & Assert
        await Assert.ThrowsAsync<BadHttpRequestException>(() => _accountService.GetAccountByIdAsync(accountId));
    }
}
