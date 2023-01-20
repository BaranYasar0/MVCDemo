﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
	public class CommentController : Controller
	{

		CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
	public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
	public PartialViewResult CommentListByBlog(int id)
		{
			ViewBag.str = "Deneme";
			var result=cm.GetAll(id);
			return PartialView(result );
		}
	}
}