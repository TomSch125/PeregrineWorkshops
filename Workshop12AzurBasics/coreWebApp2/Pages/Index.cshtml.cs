using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace coreWebApp2.Pages
{
    public class IndexModel : PageModel
    {

        public List<String> cols = new List<String>();

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
            string sqlString = "Select * From student";
            SqlCommand cmd = new SqlCommand(sqlString, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            string format = "| {0,-10} | {1,-10} | {2,-10}";
            cols.Add(string.Format(format, "Id", "Name", "Age"));

            while (dr.Read())
            {
                string output = "";
                int fields = dr.FieldCount;

                output = string.Format(format, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2));
                cols.Add(output);
            }
            dr.Close();
        }
    }
}
