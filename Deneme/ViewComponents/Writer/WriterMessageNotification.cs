﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        
        public IViewComponentResult Invoke()
        {
            int id = 4;
            var result = mm.GetInboxListByWriter(id);
            return View(result);
        }
    }
}
