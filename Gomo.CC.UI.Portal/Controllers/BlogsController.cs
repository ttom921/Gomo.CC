﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gomo.CC.IDAL;
using Gomo.CC.EFDAL;
using Gomo.CC.Model;
using Gomo.CC.IBLL;
using Gomo.CC.Common;
using Serilog;

namespace Gomo.CC.UI.Portal.Controllers
{
    public class BlogsController : Controller
    {
        #region 使用dal
        //private readonly IBlogDal _BlogDal;

        //public BlogsController(IBlogDal blogDal)
        //{
        //    _BlogDal = blogDal;
        //}
        //public IActionResult Index()
        //{
        //    //IBlogDal.GetEntities()
        //    List<Blog> lst = _BlogDal.GetEntities(u => true).ToList();
        //    return View(lst);
        //}
        #endregion
        private readonly IUserInfoService _UserInfoService;
        readonly ILogger _log;

        public BlogsController(IUserInfoService userInfoService, ILogger log)
        {
            _UserInfoService = userInfoService;
            _log = log;
        }
        public IActionResult Index()
        {
            // LogHelper.WriteLog("BlogsController  log");
            _log.Information("BlogsController  log");
            List<UserInfo> lst = _UserInfoService.GetEntities(u => true).ToList();
            return View(lst);
        }

    }

    
}