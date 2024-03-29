﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_Project_Hs085315.Models
{
    public class Order
    {
        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<OrderDetail> OrderDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}