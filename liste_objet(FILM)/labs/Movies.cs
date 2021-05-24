using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs
{
    class Movies
    {
        private DateTime realeaseDate;
        private string name;
        private string genre;

        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public DateTime RealeaseDate { get => realeaseDate; set => realeaseDate = value; }

        public override String ToString()
        {
            return "The Movie is " + Name + " genre : " + Genre + " realease Date : " + RealeaseDate.ToString("dd/M/yyyy");
        }
    }
}
