using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VkAPITutorial
{
    public static class Dictionary
    {
        static String[] Words;
        public static void InspectUser(User user)
        {
            if (Words == null)
            {
                Initialize();
            }
            if (user.city == "Москва" || user.city == "Санкт-Петербург")
            {
                user.markered = true;
            }
            if (user != null && !user.markered && !user.closed)
            {
                foreach (var item in user.Posts)
                {
                    foreach (var word in Words)
                    {
                        if (item.IndexOf(word) > 0)
                        {
                            if (!File.Exists(Directory.GetCurrentDirectory() + "/results/id" + user.id + ".txt"))
                            {
                                using (File.Create(Directory.GetCurrentDirectory() + "/results/id" + user.id + ".txt"))
                                {
                                    
                                }
                                
                                
                            }
                            using (StreamWriter SW = new StreamWriter(Directory.GetCurrentDirectory() + "/results/id" + user.id + ".txt"))
                            {
                                SW.WriteLine(user.firstname + " " + user.lastname);
                                SW.WriteLine("Пост:" + Environment.NewLine +item);
                                SW.WriteLine("Ключевое слово: " + word);
                                SW.Close();
                            }
                        }
                    }
                }
                user.markered = true;
            }
        }
        public static void InspectGroup(Group group)
        {
            if (Words == null)
            {
                Initialize();
            }
            if (group != null && !group.markered)
            {
                group.Load();
                foreach (var item in group.Posts)
                {
                    foreach (var word in Words)
                    {
                        if (item.IndexOf(word) > 0)
                        {
                            using (StreamWriter SW = new StreamWriter("/results/club" + group.id + ".txt"))
                            {
                                
                                SW.WriteLine("Пост:" + Environment.NewLine + item);
                                SW.WriteLine("Ключевое слово: " + word);
                                SW.Close();
                            }
                        }
                    }
                }
                group.markered = true;
            }
        }
        public static void Initialize()
        {
            using (StreamReader SR = new StreamReader("dict.txt"))
            {
                Words = SR.ReadToEnd().Split('|');
                SR.Close();
            }
        }
    }
}
