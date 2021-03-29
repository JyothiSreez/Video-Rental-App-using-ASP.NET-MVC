using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        public Customers Customers { get; set; }

        public string Title
        {
            get
            {
                if (Customers != null && Customers.Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }
    }
}