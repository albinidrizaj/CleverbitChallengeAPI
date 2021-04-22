using AutoMapper;
using Core.Models.Database;
using Core.Models.DTOs;
using Microsoft.IdentityModel.Tokens;
using Services;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Handlers
{
    public class AuthenticationHandler
    {
        private readonly IMapper _mapper;
        private readonly AuthenticationService _authenticationService;

        public AuthenticationHandler(AuthenticationService authenticationService, IMapper mapper)
        {
            _mapper = mapper;
            _authenticationService = authenticationService;
        }

        public ResultDTO Login(LoginDTO loginDTO)
        {
            if (!_authenticationService.Login(loginDTO))
                return new ResultDTO
                {
                    Sucess = false
                };

            return new ResultDTO
            {
                Sucess = true,
                Data = GenerateJWT(loginDTO)
            };
        }

        public bool Register(UserDTO userDTO)
        {
            var userEntity = _mapper.Map<UserDTO, User>(userDTO);
            return _authenticationService.Register(userEntity);
        }


        private string GenerateJWT(LoginDTO loginDTO)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Jwt:Key"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken("Jwt:Issuer",
              "Jwt:Issuer",
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
