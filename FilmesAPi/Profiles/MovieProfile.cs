using AutoMapper;
using FilmesAPi.Data.Dtos;
using FilmesAPi.Models;

namespace FilmesAPi.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<CreateMovieDto, Filme>();
            CreateMap<UpdateMovieDto, Filme>();
            CreateMap<Filme, UpdateMovieDto>();
            CreateMap<Filme, ReadMovieDto>();
        }
    }
}
