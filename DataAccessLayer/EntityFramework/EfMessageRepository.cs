﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMessageRepository : GenericRepository<Message2>, IMessageDal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c = new Context())
            {
                return c.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }

        public List<Message2> GetSendBoxByWriter(int id)
        {
        using(var c = new Context())
            {
                return c.Message2s.Include(x => x.ReceiverUser).Where(y => y.SenderID == id).ToList();
            }

        }
    }
}
