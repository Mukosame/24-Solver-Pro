using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Dian
{
        class dealNum
    {
            public int result=0;
        public bool IsNumeric(String message)
        {
           // System.Text.RegularExpressions.Regex rex =
        //new System.Text.RegularExpressions.Regex(@"^\d+$");
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(@"^[0-9]\d*$");
            if (rex.IsMatch(message))
            {
                result = int.Parse(message);
                if ((result > 0) && (result < 14))
                { return true; }
                else
                {
                    result = 0;
                    return false;
                }
            }
            else
            {
                result = 0;
                return false;
            }
        }


    }//class end


    //
    //IF_YOU_WANT_TO_ADD_SOMETHING_HERE
    //
}
