using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ConectionStringHelper
    {
        public static string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Coneccion"].ConnectionString;
        }
    }
}
