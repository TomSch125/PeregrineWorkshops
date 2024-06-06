using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace corewebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly IConfiguration _configuration;
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet(Guid id)
        {
            string conStr = _configuration.GetSection("ConnectionStrings")["MyDB"];
            SqlConnection con = new SqlConnection(conStr);
            string sqlString = "Select * From customers";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string output = "";
                int fields = dr.FieldCount;
                for (int i = 0; i < fields; i++) {

                    output = output + dr.GetValue(i)+" ";
                }
                Console.WriteLine(output);
            }
            dr.Close();
        }
    }
}
