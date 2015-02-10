using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class Prueba
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }


        private bool connection_open;
        private MySqlConnection connection;

    }  
}