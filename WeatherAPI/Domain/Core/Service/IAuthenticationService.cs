using WeatherAPI.Domain.Dto;
using WeatherAPI.Domain.Model;

namespace WeatherAPI.Domain.Core.Service
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<string>> Login(UserDto request);
        Task<ResponseDto<User>> Register(UserDto request);
    }
}