using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        public UserAccount userAccount = new UserAccount();

        [HttpGet]
        public IEnumerable<UserAccount> Get()
        {
            return userAccount.GetUserAccounts(); ;
        }

        [HttpGet("{id}")]
        public IEnumerable<UserAccount> Get(int id)
        {
            return userAccount.GetUserAccounts(); ;
        }

    }

    public class UserAccount
    {
        public string? Date { get; set; }
        public string? UserEmail { get; set; }
        public int UserId { get; set; }
        public string? UserName { get; set; }

        public List<UserAccount> UserAccounts = new List<UserAccount>();

        public UserAccount()
        {

        }
        public UserAccount(int userId, string userEmail, string date, string username)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Date = date;
            this.UserName = username;
        }
        public List<UserAccount> GetUserAccounts()
        {

            this.UserAccounts.Add(new UserAccount(856511, "devops.gcp@lloydsbanking.com", "Devops GCP",
                DateTime.Now.ToString()));
            this.UserAccounts.Add(new UserAccount(856512, "ops.gcp@lloydsbanking.com", "Devops GCP",
               DateTime.Now.ToString()));
            this.UserAccounts.Add(new UserAccount(856513, "qa.gcp@lloydsbanking.com", "Devops GCP",
               DateTime.Now.ToString()));
            this.UserAccounts.Add(new UserAccount(856514, "preprod.gcp@lloydsbanking.com", "Devops GCP",
               DateTime.Now.ToString()));



            return this.UserAccounts;

        }
    }
}
