﻿using System.Collections.Generic;
using System.Web;
using WebApplication1.Areas.AdminControl.Models;
using WebApplication1.Models;

namespace WebApplication1.Areas.AdminControl.Services
{
    public interface IAdminServices
    {
        Account GetAcount();

        List<WebApplication1.Models.HomeStay> GetAllHomeStay();

        FormViewModel GetAllTable();

        bool AddImage(string[] idHomestay, HttpPostedFileBase urlImage);

        bool DeleteImage(int id);
    }
}
