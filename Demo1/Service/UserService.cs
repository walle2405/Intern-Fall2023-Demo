using AutoMapper;
using Demo1.Entity;
using Demo1.Repository;

namespace Demo1.Service
{
    public interface IUserService
    {
        public Task<ICollection<UserEntity>> GetUsers();
    }

    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly UserRepository _userRepository;

        public UserService(IMapper mapper, UserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<ICollection<UserEntity>> GetUsers()
        {
            var users = await _userRepository.GetAll();
            return users.ToList();
        }

        // tạo các services cho create new user, edit user và delete user

    }
}
