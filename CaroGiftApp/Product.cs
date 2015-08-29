using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Travis Caro
//CaroGiftApp
//CIS330
//
//Objective:
//
//          Use this object to store any data associated with any products and their associated properties
//              Note that some properties may go unused


namespace CaroGiftApp
{
    class Product
    {
        private int productID;

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        private String productName;

        public String ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private String productDescription;

        public String ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private byte[] productPicture;

        public byte[] ProductPicture
        {
            get { return productPicture; }
            set { productPicture = value; }
        }

    }
}
