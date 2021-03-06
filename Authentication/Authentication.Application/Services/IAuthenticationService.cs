﻿using Authentication.Common.DTO;
using Authentication.Domain.Dto.Application;
using Authentication.Domain.Dto.Permission;
using Authentication.Domain.Dto.Role;
using Authentication.Domain.Dto.RolePermission;
using Authentication.Domain.Dto.User;
using System.Threading.Tasks;

namespace Authentication.Application.Services
{
    public interface IAuthenticationService
    {
        public Task<InsertUserResponseDTO> InsertUserAsync(InsertUserRequestDTO request);

        public Task<ValidateUserResponseDTO> ValidateUserAsync(ValidateUserRequestDTO request);

        public GetUserListResponseDTO GetUsers(GetUserRequestDTO request);

        public Task<InsertRoleResponseDTO> InsertRoleAsync(InsertRoleRequestDTO request);

        public Task<InsertPermissionResponseDTO> InsertPermissionAsync(InsertPermissionRequestDTO request);

        public Task<InsertRolePermissionResponseDTO> InsertRolePermissionAsync(InsertRolePermissionRequestDTO request);

        public Task<InsertRoleGroupResponseDTO> InsertRoleGroupAsync(InsertRoleGroupRequestDTO request);

        public Task<InsertUserGroupResponseDTO> InsertUserGroupAsync(InsertUserGroupRequestDTO request);

        public Task<InsertUserRoleResponseDTO> InsertUserRole(InsertUserRoleRequestDTO request);

        public Task<HasPermissionResponseDTO> HasPermission(HasPermissionRequestDTO request);

        public Task<InsertApplicationResponseDTO> InsertApplicationAsync(InsertApplicationRequestDTO request);

    }
}
