using AuthenService.Domain.User;

namespace AuthenService.Application.Commons.Interfaces.Persistence.User;

public interface IUserRepository
{
    public UserEntity Add(UserEntity entity);
}
