using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace github.api
{
    public class CreateContentResponse
        {
        public Content content{get; set;} 

    public class Content{ public string name{get; set;}
         public string path{get; set;}
         public string sha{get; set;}
         public int size{get; set;}
         public string url{get; set;}
             public string html_url{get; set;}
            public string git_url{get; set;}
          public string download_url{get; set;}
          public string type{get; set;}
        public Links _links{get; set;}
        public class Links{  public string self{get; set;}
          public string git{get; set;}
             public string html{get; set;}
     }
    }
        public Object commit{get; set;}
        public string message{get; set;}
        public Object[] parents{get; set;}
        public Object verification{get; set;}
      
}
    public class Content
    {
        
        public string name{get; set;}
        public string path{get; set;}
        public string sha{get; set;}
        public int size{get; set;}
        public string url{get; set;}
         public string html_url{get; set;}
          public string git_url{get; set;}
          public string download_url{get; set;}
       public string type{get; set;}
        public Links _links{get; set;}
        public class Links{
        public string self{get; set;}
            public string git{get; set;}
          public string html{get; set;}
    }
    }
    public class Commit4
    {
       public string sha{get; set;}
        public string node_id{get; set;}
        public Committ commit { get; set; }
        public class Committ { 
        public Object author{ get; set; }
        public Object committer{ get; set; }
        public string  message{ get; set; }
        public Object tree { get; set; }
        public string url{ get; set; }
 public int comment_count{ get; set; }
public Object verification{ get; set; }
        }
   public string url{ get; set; }
 public string html_url{ get; set; }
  public Stats stats{get; set;}
        public class Stats { 
            public int total{get; set;}
       public int additions{get; set;}
       public int deletions{get; set;}
        }
        public File[] files{get; set;}
    public class File{ 

public string sha{get; set;}
 public string filename{get; set;}
        public string status{get; set;}
        public int additions{get; set;}
        public int  deletions{get; set;}
        public int  changes{get; set;}
        public string  blob_url{get; set;}
         public string  raw_url{get; set;}
           public string  contents_url{get; set;}
           public string  patch{get; set;}
    
        }
}
           
    /*
    public class Commit3
        {
         public string sha{get; set;}
        public string node_id{get; set;}
             "commit":{
       public  Object author{get; set;}
             public Object committer{get; set;}
           public string message{get; set;}
        public Object tree{get; set;}
              public Object verification{get; set;}
           public Object[] parents{get; set;}
       public Stats stats{get; set;}
        public class Stats{public int total{get; set;}
            public int additions{get; set;}
            public int deletions{get; set;}
    public File[] files{get; set;}

        public class File{public string sha{get; set;}
             public string filename{get; set;}
            public string status{get; set;}
            public int  additions{get; set;}
             public int  deletions{get; set;}
             public int  changes{get; set;}
            public string blob_url{get; set;}
               public string raw_url{get; set;}
              public string contents_url{get; set;}
             public string patch{get; set;}
        }
}
        */
    public class Commit
      {
    public string url{get; set;}
       public string sha{get; set;}
         public string node_id{get; set;}
     public string html_url{get; set;}
     public string comments_url{get; set;}
       public Commit2 commit{get; set;} 
    
    public class Commit2{
      public string url{get; set;}
         public Object author{get; set;}
      public Object committer{get; set;}
      public string message{get; set;}
      public Object tree{get; set;}
      public int comment_count{get; set;}
      public Object verification{get; set;}
    }
   public Object author{get; set;}
    public Object  committer{get; set;}
    public Object[] parents{get; set;}
  }
    public class Repo
    {
        public override string ToString()
        {
            return full_name;
        }
        public string id{get; set;}
         public string  node_id{get; set;}
         public string  name{get; set;}
         public string  full_name{get; set;}
        [JsonProperty("private")]
         public bool _private{get; set;}
         public User owner{get; set;}
    public class User{
         public string login{get; set;}
         public string id{get; set;}
         public string  node_id{get; set;}
         public string avatar_url{get; set;}
         public string gravatar_id{get; set;}
         public string url{get; set;}
         public string html_url{get; set;}
         public string followers_url{get; set;}
         public string following_url{get; set;}
         public string gists_url{get; set;}
         public string starred_url{get; set;}
         public string subscriptions_url{get; set;}
         public string organizations_url{get; set;}
         public string repos_url{get; set;}
         public string events_url{get; set;}
         public string received_events_url{get; set;}
         public string type{get; set;}
         public bool site_admin{get; set;}
    }
         public string  html_url{get; set;}
         public string description{get; set;}
         public bool fork{get; set;}
         public string url{get; set;}
         public string forks_url{get; set;}
         public string keys_url{get; set;}
            
         public string collaborators_url{get; set;}
       
         public string teams_url{get; set;}
       
         public string hooks_url{get; set;}
       
         public string issue_events_url{get; set;}
        
         public string events_url{get; set;}
        
         public string assignees_url{get; set;}
       
         public string branches_url{get; set;}
       
         public string tags_url{get; set;}
        
         public string blobs_url{get; set;}
       
         public string git_tags_url{get; set;}
        
         public string git_refs_url{get; set;}
        
         public string  trees_url{get; set;}
        
         public string statuses_url{get; set;}
        
         public string languages_url{get; set;}
       
         public string stargazers_url{get; set;}
        
         public string contributors_url{get; set;}
        
         public string subscribers_url{get; set;}
        
         public string subscription_url{get; set;}
        
         public string commits_url{get; set;}
        
         public string git_commits_url{get; set;}
        
         public string comments_url{get; set;}
        
         public string issue_comment_url{get; set;}
        
         public string contents_url{get; set;}
       
         public string compare_url{get; set;}
        
         public string merges_url{get; set;}
        
         public string archive_url{get; set;}
        
         public string downloads_url{get; set;}
       
         public string issues_url{get; set;}
        
         public string pulls_url{get; set;}
       
         public string milestones_url{get; set;}
       
         public string notifications_url{get; set;}
          public string labels_url{get; set;}
        
         public string releases_url{get; set;}
        
         public string deployments_url{get; set;}
       
         public string created_at{get; set;}
         public string updated_at{get; set;}
         public string pushed_at{get; set;}
         public string git_url{get; set;}
         public string ssh_url{get; set;}
         public string clone_url{get; set;}
         public string svn_url{get; set;}
         public string homepage{get; set;}
        public int size{get; set;}
         public int stargazers_count{get; set;}
         public int watchers_count{get; set;}
         public string language{get; set;}
         public bool has_issues{get; set;}
         public bool has_projects{get; set;}
        public bool has_downloads{get; set;}
        public bool has_wiki{get; set;}
        public bool has_pages{get; set;}
        public int forks_count{get; set;}
         public string mirror_url{get; set;}
        public bool archived{get; set;}
        public bool disabled{get; set;}
        public int open_issues_count{get; set;}
         public string license{get; set;}
        public int forks{get; set;}
        public int open_issues{get; set;}
        public int watchers{get; set;}
        public string default_branch{get; set;}
        public Permissions permissions{get; set;}
        public class Permissions{
        public bool admin{get; set;}
         public bool push{get; set;}
         public bool pull{get; set;}
    }
    }
    public class Feeds
    {
    }
    public class User
    {
       public string login{get; set;}
        public string id{get; set;}
        public string node_id{get; set;}
        public string avatar_url{get; set;}
          public string gravatar_id{get; set;}
        public string url{get; set;}
        public string html_url{get; set;}
        public string followers_url{get; set;}
           public string following_url{get; set;}
          public string gists_url{get; set;}
          public string starred_url{get; set;}
           public string subscriptions_url{get; set;}
           public string organizations_url{get; set;}
          public string repos_url{get; set;}
         public string events_url{get; set;}
        public string received_events_url{get; set;}
          public string type{get; set;}
        public bool site_admin{get; set;}
        public string name{get; set;}
        public string company{get; set;}
        public string blog{get; set;}
        public string location{get; set;}
        public string email{get; set;}
        public string hireable{get; set;}
        public string bio{get; set;}
        public int public_repos{get; set;}
        public int public_gists{get; set;}
        public int followers{get; set;}
        public int following{get; set;}
        public string created_at{get; set;}
        public string updated_at{get; set;}
        public int private_gists{get; set;}
        public int total_private_repos{get; set;}
        public int owned_private_repos{get; set;}
        public int disk_usage{get; set;}
        public int collaborators{get; set;}
        public bool two_factor_authentication{get; set;}
            public Plan plan{get; set;}
                public class Plan{public string name{get; set;}
        public long space{get; set;}
                    public int collaborators{get; set;}
        public int private_repos{get; set;}
                }
    
    }
}