using ATM.DAL;
using ATM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Logic
{
    public class UserService
    {
        public UserRepository _userRepository { get; set; }

        public UserService(UserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        //CRUD

        public int Create(User user)
        {
            int id = 0;
            if(user == null) throw new ArgumentNullException("user");
            if(user != null) id = _userRepository.Create(user);
            return id;
        }

        public void Update(User user)
        {
            if(user != null) _userRepository.Update(user);
        }

        public User? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User? GetByPhoneNumber(string phoneNumber)
        {
            return _userRepository.GetByPhoneNumber(phoneNumber);
        }

        public Task<List<User>> GetUsersAsync(string? filterword)
        {
            return Task.Run(() => _userRepository.Search(filterword).ToList());
        }

        public List<User> Search(string? filterword)
        {
            return _userRepository.Search(filterword).ToList();
        }

        public void Delete(int id)
        {
            User? userToDelete = _userRepository.GetById(id);
            if(userToDelete != null )
            {
                _userRepository.Delete(userToDelete);
            }
        }

        public void Delete(User user)
        {
            if (user != null)
            {
                _userRepository.Delete(user);
            }
        }



    }
}
