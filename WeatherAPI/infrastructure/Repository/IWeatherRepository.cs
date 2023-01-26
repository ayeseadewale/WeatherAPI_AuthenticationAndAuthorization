using WeatherAPI.Domain.Dto;
using WeatherAPI.Domain.Model;
using static WeatherAPI.Domain.Model.WeatherInformation;

namespace WeatherAPI.infrastructure.Repository
{
    public interface IWeatherRepository
    {
        Task<ResponseDto<WeatherInfoDto>> GetCurrentWeatherAsync(string location);
    }
}