using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkAPITutorial
{
    public class Group
    {
        public String id
        {
            get;
            private set;
        }
        public List<String> Posts;
        public List<User> Users;
        public Boolean markered;
        public Group(String g)
        {
            id = g;
            Users = new List<User>();
            
        }
        public void Load()
        {
            Posts = MainForm._ApiRequest.GetGroupPosts(id);
            if (Posts.Count == 0)
            {
                markered = true;
            }
        }
    }
}
