using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.data;
using WebApplication3.data.interfaces;

namespace WebApplication3.Controllers
{
    public class AlbomsController : Controller
    {
        iAllAlboms _iAllAlboms;

        public AlbomsController (iAllAlboms iAllAlboms) {
            _iAllAlboms = iAllAlboms;

        }






        public ViewResult List() {

            var Albom = _iAllAlboms.Alboms;
            return View(Albom);


        }


    }
}
