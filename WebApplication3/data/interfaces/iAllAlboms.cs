using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.data.interfaces
{
   public  interface iAllAlboms
    {
         public IEnumerable <albom> Alboms { get; set; }


    }
}
