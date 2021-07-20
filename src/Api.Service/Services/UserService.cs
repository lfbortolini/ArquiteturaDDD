using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Service.User;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;

        public UserService(IRepository<UserEntity> repository) => _repository = repository;
        public async Task<bool> Delete(Guid id) => await _repository.DeleteAsync(id);
        public async Task<UserEntity> Get(Guid id) => await _repository.SelectAsync(id);
        public async Task<IEnumerable<UserEntity>> GettAll() => await _repository.SeletcAsync();
        public async Task<UserEntity> Post(UserEntity user) => await _repository.InsertAsync(user);
        public async Task<UserEntity> Put(UserEntity user) => await _repository.UpdateAsync(user);
    }
}