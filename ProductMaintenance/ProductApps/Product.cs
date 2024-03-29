﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal delivery = 25;
        private decimal wrapping = 5;
        private decimal gst = 1.1m;

        private decimal price;
        private int quantity;
        private decimal totalPayment;
        //private decimal delivery;
        //private decimal wrapping;
        //private decimal gst;
        private decimal totalCharge;
        private decimal totalWrapping;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        private decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //---------TOTAL CHARGE---------
        public decimal TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        //************TOTAL WRAPPING************
        public decimal TotalWrapping
        {
            get { return totalWrapping; }
            set { totalWrapping = value; }
        }



        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //--------TOTAL CHARGE
        public void calcTotalCharge()
        {
            TotalCharge = TotalPayment + 25;
        }

        //-------TOTAL Wrapping Charge
        public void calcWrapping()
        {
            TotalCharge = TotalPayment + Delivery + Wrapping;
        }

        //-------TOTAL Wrapping Charge
        public void calcGST()
        {
            TotalCharge = (TotalPayment + Delivery + Wrapping) * gst;
        }


    }
}
