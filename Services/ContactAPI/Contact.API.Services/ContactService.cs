﻿using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContact(int id)
        {
            return new ContactDTO()
            {
                Id = id,
                FirstName = "Onur",
                LastName = "Altun"
            };
        }
    }
}
