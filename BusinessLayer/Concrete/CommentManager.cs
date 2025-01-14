﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentAdd(Comment comment)
		{
			_commentDal.Insert(comment);
		}

		public List<Comment> GetAll(int id)
		{
		
			var result= _commentDal.GetAll(x => x.BlogId == id);
			return result;
		}

		public List<Comment> GetCommentsWithBlog()
		{
		return _commentDal.GetCommentsWithBlog();
		}
	}
}
