using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CollegeManagementSystem
{
    class Conn
    {
        public static SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|CollegeManagement.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
    }
}
