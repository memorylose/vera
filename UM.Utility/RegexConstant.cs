using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UM.Utility
{
    public class RegexConstant
    {
        public const string AlphaNumber = "[^A-Za-z0-9_\u4e00-\u9fa5]";
        public const string Htmlmark = "<[^>]*>";
        public const string UserName = "^[A-Za-z0-9]{6,20}$";
        public const string Password = "^(?=.{6,16})(?=.*[a-z])(?=.*\\d).*$";
        public const string Email = "^\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$";
        public const string ArticleId = "^[0-9]*$";
        public const string TypeId = "^[0-9]*$";
    }
}
