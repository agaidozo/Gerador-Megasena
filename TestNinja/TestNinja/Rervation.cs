using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja
{
    public class Rervation
    {
        public User MadeBy { get; set; }

        public bool CAnBeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;

            if (MadeBy == user)
                return true;

            return false;
        }
    }
}
