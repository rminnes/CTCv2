using CTCv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTCv2.Code
{
    public class ContactRepo
    {

        rossminnes_SiteDBEntities context;

        public ContactRepo()
        {
            context = new rossminnes_SiteDBEntities();
        }

        public void AddContactDetails(string name, string email, string message)
        {
            context.SubscribedUsers.Add(new SubscribedUser { Name = name, Email = email, Message = message });
            context.SaveChanges();
        }


    }
}