﻿using System.Web.Mvc;
using DDDEastAnglia.DataAccess;
using DDDEastAnglia.Models.Query;

namespace DDDEastAnglia.Controllers
{
    public class BannerController : Controller
    {
        private readonly IBannerModelQuery _bannerQuery;

        public BannerController()
            : this(Factory.GetBannerModelQuery())
        {
            
        }

        public BannerController(IBannerModelQuery bannerQuery)
        {
            _bannerQuery = bannerQuery;
        }

        public ActionResult Details(string id)
        {
            return PartialView("_Banner", _bannerQuery.Get(id));
        }
    }
}