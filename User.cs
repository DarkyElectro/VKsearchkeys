using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkAPITutorial
{
    public class User
    {
        public String id
        {
            get;
            private set;
        }
        public String firstname
        {
            get;
            private set;
        }
        public String lastname
        {
            get;
            private set;
        }
        public String city
        {
            get;
            private set;
        }
        public Boolean closed
        {
            get;
            private set;
        }

        public User (String Result)
        {
            if (Result != null)
            {
                if (Result.IndexOf("id") > 0)
                {
                    id = Result.Split('"')[4].Remove(0, 1);
                    id = id.Remove(id.Length - 1, 1);
                    Posts = MainForm._ApiRequest.GetPosts(id);
                    Groups = new List<Group>();

                    if (Result.IndexOf("first_name") > 0)
                    {
                        firstname = Result.Split('"')[7];
                    }
                    if (Result.IndexOf("last_name") > 0)
                    {
                        lastname = Result.Split('"')[11];
                    }
                    if (Result.IndexOf("city") > 0)
                    {
                        city = Result.Split('"')[23];
                    }
                    if (Result.IndexOf("is_closed") > 0)
                    {
                        closed = Result.Split('"')[14].IndexOf("true") > 0;
                    }
                    markered = closed;
                    if (!closed && MainForm.groupcheck)
                    {

                        List<String> GroupsList = MainForm._ApiRequest.GetGroups(id);
                        foreach (var item in GroupsList)
                        {
                            Group temp = Data.Groups.Find(x => x.id == item);
                            if (temp == null)
                            {
                                temp = new Group(item);
                                temp.Users.Add(this);
                                Groups.Add(temp);
                                Data.Groups.Add(temp);
                            }
                            else
                            {
                                temp.Users.Add(this);
                                Groups.Add(temp);
                            }
                        }
                    }
                }
            }
            
        }
        public Boolean markered;
        public List<String> Posts;
        public List<Group> Groups;
    }
}
