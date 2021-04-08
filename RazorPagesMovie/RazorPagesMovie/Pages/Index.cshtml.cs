using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RazorPagesMovie.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var CONN = Environment.GetEnvironmentVariable("CONN");
            MySqlConnection conn = new MySqlConnection(CONN);//!!!!no referrence bracket variable CONN
            conn.Open();
            string op = "CREATE TABLE `new_schema`.`new` (`ID` INT NOT NULL);INSERT INTO new(ID) VALUES (200)"; //creat table named new;insert column ID and variable 200
            MySqlCommand command = new MySqlCommand(op, conn);
            //command.Parameters.AddWithValue("@ID", 200);
            command.ExecuteNonQuery();
           
        }
    }
}
