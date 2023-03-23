using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.SqlServer.Server;

namespace MyStore.Pages.Client
{
    public class LogInPageModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            String username = "motify";
            String password = "0w0";

            if(userid==username && passid ==password) 
            { 
            
            }
        }
    }
}
