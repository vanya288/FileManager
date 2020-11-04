using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class DBHelper
    {
        public static string Getconnectionstring(string _keyname)
        {
            string connection = string.Empty;

            switch (_keyname)
            {
                case "ISDB":
                    connection = ConfigurationManager.ConnectionStrings["ISDB"].ConnectionString;
                    break;

                default:
                    break;
            }

            return connection;

        }
    }
}
