using System.IO.Pipelines;
using System.Collections.Generic;


namespace Cake_Shop_Thelins.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> AllCakes { get; }
        IEnumerable<Cake> CakesOfTheWeek { get; }

        Cake GetCakeById(int id);

    }
}
