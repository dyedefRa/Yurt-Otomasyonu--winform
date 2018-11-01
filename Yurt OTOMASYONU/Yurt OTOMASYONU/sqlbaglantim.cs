using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Yurt_OTOMASYONU
{
    public class sqlbaglantim
    {
        public SqlConnection baglanti()
        {
           SqlConnection baglan = new SqlConnection(@"Data Source=BAKIOZTURK\SQLSERVER;Initial Catalog=Yurtkayit;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
