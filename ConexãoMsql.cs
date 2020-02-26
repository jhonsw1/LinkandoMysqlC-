using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace testandoMysql4
{
    class ConexãoMsql
    {
      
       MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;uid=root;pwd=;database=bd_prod");
       
        public void conectarBanco()
        {
           objcon.Open();
        }
       
    }
   
}
