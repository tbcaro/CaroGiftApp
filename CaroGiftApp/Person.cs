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
//          Use this object to store any data associated with a Person and their associated properties
//              Note that some properties may go unused



namespace CaroGiftApp
{
    class Person
    {

        //Initialize list of assigned products on construction
        public Person()
        {
            assignedProducts = new List<Product>();
        }

        private int personID;

        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        private String firstName;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private String lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        private String city;

        public String City
        {
            get { return city; }
            set { city = value; }
        }

        private String state;

        public String State
        {
            get { return state; }
            set { state = value; }
        }

        private int zipCode;

        public int ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private List<Product> assignedProducts;

        public List<Product> AssignedProducts
        {
            get { return assignedProducts; }
            set { assignedProducts = value; }
        }
        
    }
}
