using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VkAPITutorial
{
    public static class Data
    {
        public static List<User> Users;
        public static List<Group> Groups;
        public static Queue<User> UsersQueue;
        public static String[] Cities;

        public static void Initialize()
        {
            Users = new List<User>();
            Groups = new List<Group>();
            UsersQueue = new Queue<User>();
            using (StreamReader SR = new StreamReader("cities.txt"))
            {
                Cities = SR.ReadToEnd().Split('|');
                
                SR.Close();

            }
        }
        public static User AddUser(String user)
        {
            if (user != "" && Users.Find(x=>x.id == user) == null)
            {
                User U = MainForm._ApiRequest.GetUser(user);
                if (U.id != null)
                {
                    Users.Add(U);
                    return U;
                }
                
            }
            return null;
        }
        public static void Enqueue(String user)
        {
            if (user != null)
            {
                User Current = AddUser(user);
                if (Current != null)
                {
                    UsersQueue.Enqueue(Current);
                }
            }
        }

        public static Boolean CheckCity(User user)
        {
            if (user.city == null || user.city == "")
            {
                return false;
            }
            foreach (var item in Cities)
            {
                if (item == user.city)
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}
