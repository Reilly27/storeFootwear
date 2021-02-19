using Store;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Store_Mamory
{
   public class FootwearRepository : IFootwearRepository
    {
        private readonly Footwear[] footwers = new [] { 
        
        new Footwear(1, "ISBN 43423-65454", "Nice", "Sneakers", "Удобные кросы(описание)", 150.25m),
        new Footwear (2,"ISBN 44523-75454", "Suprime", "Sneakers full", "Дешевые кросы(описание)", 50.15m),
        new Footwear (3,"ISBN 47423-65414", "Puma", "Sneakers mini", "Легкие кросы(описание)", 130.75m)
                           
        };

        public Footwear[] GetAllByIsbn(string isbn)
        {
            return footwers.Where(footwer => footwer.Isbn == isbn).ToArray();
        }

        public Footwear[] GetAllByTitleOrAuthor(string query)
        {
            return footwers.Where(footwer => footwer.Author.Contains(query)
                                          || footwer.Title.Contains(query)).ToArray();
        }

        public Footwear GetById(int id)
        {
            return footwers.Single(footwer => footwer.Id == id);
        }
    }
}
