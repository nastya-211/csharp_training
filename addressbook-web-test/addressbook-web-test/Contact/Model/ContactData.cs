﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTest
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;
        private string lastname="";
        private string nickname="";

        public ContactData(string name)
        {
            this.firstname = firstname;
        }
        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null));
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other));
            {
                return true;
            }
            return Firstname == other.Firstname;
        }
        public override string ToString()
        {
            return "firstname=" + Firstname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null));
            {
                return 1;
            }
            return Firstname.CompareTo(other.Firstname);
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
    }
}
