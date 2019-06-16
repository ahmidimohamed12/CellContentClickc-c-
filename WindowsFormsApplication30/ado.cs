using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace WindowsFormsApplication30
{
    class ado
    {
        public static SqlConnection cnx = new SqlConnection("data source=.;initial catalog=efm2018v1;integrated security=true");
        public static SqlCommand cmd = new SqlCommand("", cnx);
        public static SqlDataAdapter da = new SqlDataAdapter("",cnx);

    }
}
