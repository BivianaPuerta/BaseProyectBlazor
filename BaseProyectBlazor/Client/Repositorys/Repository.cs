using BaseProyectBlazor.Shared.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProyectBlazor.Client.Repositorys
{
    public class Repository: IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
    {
                    new Movie() { Title = "Spider-Man:Far From House", Premiere = new DateTime(2019, 07, 02) },
                    new Movie() { Title = "El Recuerdo de Marnie", Premiere = new DateTime(2014, 07, 19) },
                    new Movie() { Title = "Earwig and Witch", Premiere = new DateTime(2020, 12, 30) },
                    new Movie() { Title = "Fantastic Beasts: Crimens of Grindelwold", Premiere = new DateTime(2018, 11, 16) },
                    new Movie() { Title = "Ron da Error", Premiere = new DateTime(2021, 10, 15) },
                };
        }
    }
}
