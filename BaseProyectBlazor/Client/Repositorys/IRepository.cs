using BaseProyectBlazor.Shared.Entitys;
using System.Collections.Generic;

namespace BaseProyectBlazor.Client.Repositorys
{
    public interface IRepository
        {
            List<Movie> GetMovies();
        }
}

