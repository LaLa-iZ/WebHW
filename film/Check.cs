using System;
using System.Collections.Generic;
using System.Text;

namespace film
{
    class Check
    {
        public static void Filler()
        {
            ProducerManager.Add(1, "Christopher", "Nolan");
            ProducerManager.Add(2, "Luc", "Besson");
            ProducerManager.Add(3, "Andrew", "Stanton");

            CompanyManager.Add(1, "Legendary Pictures");
            CompanyManager.Add(2, "Les Films du Dauphin");
            CompanyManager.Add(3, "Walt Disney Pictures");

            GenreManager.Add(1, "thriller");
            GenreManager.Add(2, "fantasy");
            GenreManager.Add(3,"animated-film");

            FilmManager.Add(1, "Inception", "A professional thief who steals information by infiltrating the subconscious", 1,1,1,8,7,2010);
            FilmManager.Add(2, "Léon: The Professional", "Cult film by French director Luc Besson about a professional killer named Leon",2,2,1,14,9,1994);
            FilmManager.Add(3, "WALL-E", "From year to year, the robot works diligently on an empty Earth, cleansing our planet from the mountains of debris that people left after flying into space. He has no idea that incredible events will happen very soon", 3,3,3,23,7,2008);
            FilmManager.Add(4, "Interstellar", "The film is about the travels of a group of researchers who use the recently discovered space-time tunnel to circumvent the limitations of manned space travel and cover huge distances on an interstellar ship", 1,1,2,26,10,2014);
        }
    }
}
