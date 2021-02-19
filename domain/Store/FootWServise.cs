using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class FootWServise
    {
        private readonly IFootwearRepository footwearRepository;

        public FootWServise(IFootwearRepository footwearRepository)
        {
            this.footwearRepository = footwearRepository; 
        }

        public Footwear[] GetAllByQuery(string query)
        {
            if (Footwear.IsIsbn(query))
                return footwearRepository.GetAllByIsbn(query);

            return footwearRepository.GetAllByTitleOrAuthor(query);
        }
    }
}
