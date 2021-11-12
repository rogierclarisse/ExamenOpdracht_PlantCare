using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantCare2._0
{
    internal class MessageOnLog
    {
        public event LogEventHandler Login;

        protected void OnLogin(string bericht)
        {
            if(Login != null)
                Login(bericht);
        }

        internal void PressButton()
        {
            OnLogin("Click \"okay\" to enter the homepage ");
        }

    }
 
}
