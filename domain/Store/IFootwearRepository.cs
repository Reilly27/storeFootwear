using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IFootwearRepository
    {
        Footwear[] GetAllByIsbn(string isbn);

        Footwear[] GetAllByTitleOrAuthor(string titleOrAuthor);

        Footwear GetById(int id);
    }
}
