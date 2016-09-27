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
        //public const string CreateDate = "/^((((19|20)\\d{2})-(0?(1|[3-9])|1[012])-(0?[1-9]|[12]\\d|30))|(((19|20)\\d{2})-(0?[13578]|1[02])-31)|(((19|20)\\d{2})-0?2-(0?[1-9]|1\\d|2[0-8]))|((((19|20)([13579][26]|[2468][048]|0[48]))|(2000))-0?2-29))$/";
    }
}
