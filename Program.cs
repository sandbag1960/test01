using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net.Security;

namespace ConsoleApplication1
{
 
    /*
    public class APIClient
    {
        public NetworkCredential credential { get; set; }
        public void CreateRepository(string name)
        {
        }
      
        public void notifications()
        {
            var req = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/user/subscriptions");
            req.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", credential.UserName, credential.Password))));
            req.Version = new Version(1, 1);
            req.Headers.Add("Accept", "application/json");
            req.Headers.Add("User-Agent", "edomurasaki");

            var res = OpenSSL.wapper.HttpsClient.SendAsync(req);
            var s = res.Content.ReadAsStringAsync().Result;
        }
        public void feed()
        {
            var req = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/feeds");
            req.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", credential.UserName, credential.Password))));
            req.Version = new Version(1, 1);
            req.Headers.Add("Accept", "application/json");
            req.Headers.Add("User-Agent", "edomurasaki");

            var res = OpenSSL.wapper.HttpsClient.SendAsync(req);
            var s = res.Content.ReadAsStringAsync().Result;
        }

        public Commit[] Commits(string owner, string repo)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, string.Format("https://api.github.com/repos/{0}/{1}/commits", owner, repo));
            req.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", credential.UserName, credential.Password))));
            req.Version = new Version(1, 1);
            req.Headers.Add("Accept", "application/json");
            req.Headers.Add("User-Agent", "edomurasaki");

            var res = OpenSSL.wapper.HttpsClient.SendAsync(req);
            var s = res.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Commit[]>(s);
        }

       

        public Commit4 Commit(string owner, string repo, string commit_sha)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, string.Format("https://api.github.com/repos/{0}/{1}/commits/{2}", owner, repo,commit_sha));
            req.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", credential.UserName, credential.Password))));
            req.Version = new Version(1, 1);
            req.Headers.Add("Accept", "application/json");
            req.Headers.Add("User-Agent", "edomurasaki");

            var res = OpenSSL.wapper.HttpsClient.SendAsync(req);
            var s = res.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Commit4>(s);
        }
        
    }
    */
    class Program
    {
       
    
        
        static void Main(string[] args)
        {

                     //      var c = authorize();
            //   var tk= exchangeCode2Token(c);
            var api = new github.api.ApiClient(new NetworkCredential("sandbag1960", "moonchild250"));
            
          var u= api.User();
        
          // var contents= api.repoGetcontents(u.login, "test01");
            var fi = new FileInfo(@"C:\Users\goto\Desktop\ConsoleApplication1\ConsoleApplication1\Program.cs");
          var b64= Convert.ToBase64String(File.ReadAllBytes(fi.FullName));
          api.repoCreateFile(u.login, "test01", fi.Name, "first commit", b64);
          
           

                     // var commits= api.Commits("sandbag1963", repos.First().name);
          // var commit = api.Commit("sandbag1963", repos.First().name, commits.First().sha);
         //  api.test(string.Format("https://api.github.com/repos/sandbag1963/{0}/contents/",repos.First().name));
            Console.ReadLine();
        }
    }
}
