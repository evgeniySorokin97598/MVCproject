using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.data
{



    public class albom
    {
        public int IDalbom;

        public int price;

        public int yearRelise;

        public string titleAlbom;

        public string author;

        public string publication;

        public string label;

        public string locationCreate;

        static albom alb;




        public static void setAlbom(int _IDalbom, int price, int yearRelise, string titleAlbom, string author, string publication, string label, string locationCreate)
        {
            albom Albom = new albom();
            alb = Albom;
            Albom.IDalbom = _IDalbom;
            Albom.price = price;
            Albom.yearRelise = yearRelise;
            Albom.titleAlbom = titleAlbom;
            Albom.author = author;
            Albom.publication = publication;
            Albom.label = label;
            Albom.locationCreate = locationCreate;
        }


        public static albom GetAlbom()
        {
            return alb;
        }




    }
}
