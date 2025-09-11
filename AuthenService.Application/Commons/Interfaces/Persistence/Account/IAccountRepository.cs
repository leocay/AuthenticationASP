using AuthenService.Domain.User;

namespace AuthenService.Application.Commons.Interfaces.Persistence.Account;

public interface IAccountRepository
{
    public UserEntity Add(UserEntity entity);
}
