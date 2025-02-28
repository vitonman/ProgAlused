using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class PeopleList
    {

        public static readonly List<People> people = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joonas",
                Age = 33,
                GenderId = Guid.Parse("4f0ee674-3db4-4b26-83a9-bc9beb5637e1")
            },
            
            new People()
            {
                Id = 2,
                Name = "Gulbert",
                Age = 22,
                GenderId = Guid.Parse("dcb1a718-f9ec-4362-9c81-7ae9f28631e2")
            },

            new People()
            {
                Id = 3,
                Name = "Korbis",
                Age = 50,
                GenderId = Guid.Parse("ec7a2530-16db-4573-a70d-5133bbc3916a")
            },

              new People()
            {
                Id = 3,
                Name = "Korbis Juunior",
                Age = 15,
                GenderId = Guid.Parse("14634b2e-4cab-4b5e-a1a3-4821c7ca9a89")
            },


        };
       

    };
}
