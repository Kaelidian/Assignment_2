using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    class Utility
    {
        public class CallNumber
        {
            //Call Number Format "100 GAD"

            int indexNum = -1;
            string authCode = "";


            public CallNumber(string rawNumber)
            {
                if(rawNumber != null)
                {
                    string[] input;
                    input = rawNumber.Split(' ');

                    if(input[0].Length == 3)
                    {
                        if (int.TryParse(input[0].Trim(), out indexNum))
                        {
                            if (input[1].Length == 3)
                            {
                                authCode = input[1].Trim();
                            }
                        }
                    }
                    else { MessageBox.Show("Index Number invalid."); }
                    
                }
            }

            public static bool ValidateCNumber(string callNumber)
            {
                bool isValid = false;
                CallNumber cNum = new CallNumber(callNumber);
                if(cNum != null)
                {
                    isValid = true;
                }
                return isValid;
            }
        }
    }
}
