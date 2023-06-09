﻿using Microsoft.AspNetCore.Identity;
using Shop.Shared.DTO;
using Shop.Shared.Entities;

namespace Shop.Api.Helpers
{
    public interface IUserHelper
    {

        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<SignInResult> LoginAsync(LoginDTO model);

        Task LogoutAsync();


    }
}
