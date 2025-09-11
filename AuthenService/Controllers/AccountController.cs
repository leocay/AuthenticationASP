using AuthenService.Application.Commons.Interfaces.Persistence.Account;
using AuthenService.Application.Commons.Interfaces.Persistence.User;

namespace AuthenService.Controllers;


public class AccountController : ApiController
{
    private readonly IUserRepository _userPointRepository;
    private readonly IAccountRepository _accountRepository;

    public AccountController(IUserRepository userRepository,
        IAccountRepository accountRepository)
    {
        _userPointRepository = userRepository;
        _accountRepository = accountRepository;

    }



}
