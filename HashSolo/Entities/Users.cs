using System;
using System.Collections.Generic;
using System.Text;

namespace HashSolo.Entities
{
    class Users
    {
        public int IdCode { get; set; }

        public Users(int idCode)
        {
            IdCode = idCode;
        }

        public override int GetHashCode()
        {
            return IdCode.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Users))
            {
                return false;
            }
            Users other = obj as Users;
            return IdCode.Equals(other.IdCode);
        }
    }
}
