using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class History : Bank_Services
    {
        public int Date
        {
            get => default;
            set
            {
            }
        }

        public int UsedAddress
        {
            get => default;
            set
            {
            }
        }

        public void ShowTxHistory()
        {
            throw new System.NotImplementedException();
        }
    }
}