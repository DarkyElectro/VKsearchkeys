using System.Collections.Generic;
using xNet;
using Newtonsoft.Json;
using System;

namespace VkAPITutorial
{
    public class VkAPI
    {
        public const string __APPID = "6623951";  //ID приложения
        private const string __VKAPIURL = "https://api.vk.com/method/";  //Ссылка для запросов
        private string _Token;  //Токен, использующийся при запросах

        public VkAPI(string AccessToken)
        {
            _Token = AccessToken;
        }

        public Dictionary<string, string> GetInformation(string UserId, string[] Fields)  //Получение заданной информации о пользователе с заданным ID 
        {
            HttpRequest GetInformation = new HttpRequest();
            GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);
            
            string Params = "";
            foreach (string i in Fields)
            {
                Params += i + ",";
            }
            Params = Params.Remove(Params.Length - 1);
            GetInformation.AddUrlParam("fields", Params);
            GetInformation.AddUrlParam("name_case", "Nom");
            GetInformation.AddUrlParam("v", "5.95");
            string Result = GetInformation.Get(__VKAPIURL + "users.get").ToString();
            Result = Result.Substring(13, Result.Length - 15);
            Dictionary<string, string> Dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Result);
            return Dict;
        }

                
        public User GetUser(string id)  //Получение заданной информации о пользователе с заданным ID 
        {
            if (Data.Users.Find(x => x.id == id) != null)
            {
                return null;
            }
            HttpRequest GetInformation = new HttpRequest();
            //GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);

            //string Params = "";
            //foreach (string i in Fields)
            //{
            //    Params += i + ",";
            //}
            //Params = Params.Remove(Params.Length - 1);
            //GetInformation.AddUrlParam("fields", Params);
            GetInformation.AddUrlParam("user", id);
            GetInformation.AddUrlParam("v", "5.95");
            string Result = GetInformation.Get(__VKAPIURL + "execute.GetUserById").ToString();
            //Result = Result.Substring(13, Result.Length - 15);
            //Dictionary<string, string> Dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(Result);
            return new User(Result);
        }
        public List<String> GetFriends(string id)
        {
            List<String> Friends = new List<string>();

            int count;

            HttpRequest GetInformation = new HttpRequest();
            //GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);

            //string Params = "";
            //foreach (string i in Fields)
            //{
            //    Params += i + ",";
            //}
            //Params = Params.Remove(Params.Length - 1);
            //GetInformation.AddUrlParam("fields", Params);
            GetInformation.AddUrlParam("user", id);
            GetInformation.AddUrlParam("v", "5.95");
            string Result = GetInformation.Get(__VKAPIURL + "execute.GetUsersFriends").ToString();

            if (Result == null || Result.IndexOf("error") > 0)
            {
                return Friends;
            }
            if (Result.IndexOf("count") > 0)
            {
                count = int.Parse(Result.Split(':')[2].Split(',')[0]);

                Result = Result.Split(':')[3].Split('[')[1].Split(']')[0];
                if (count > 0)
                {
                    Friends.AddRange(Result.Split(','));
                }
            }
            return Friends;
        }
        public List<String> GetPosts(string id)
        {
            List<String> Posts = new List<string>();

            //int count;

            HttpRequest GetInformation = new HttpRequest();
            //GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);

            //string Params = "";
            //foreach (string i in Fields)
            //{
            //    Params += i + ",";
            //}
            //Params = Params.Remove(Params.Length - 1);
            //GetInformation.AddUrlParam("fields", Params);
            GetInformation.AddUrlParam("user", id);
            GetInformation.AddUrlParam("v", "5.95");
            string Result = GetInformation.Get(__VKAPIURL + "execute.GetPosts").ToString();

            if (Result == null || Result.IndexOf("error") > 0)
            {
                return Posts;
            }
            else
            {
                
                if (Result.Length>0)
                {
                    Posts.AddRange(Result.Split('[')[1].Split(']')[0].Split('|'));
                }
                Posts.RemoveAll(x => x.Length < 4);
            }
            return Posts;
        }

        public List<String> GetGroupPosts(string id)
        {
            List<String> Posts = new List<string>();

            //int count;

            HttpRequest GetInformation = new HttpRequest();
            //GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);

            //string Params = "";
            //foreach (string i in Fields)
            //{
            //    Params += i + ",";
            //}
            //Params = Params.Remove(Params.Length - 1);
            //GetInformation.AddUrlParam("fields", Params);
            GetInformation.AddUrlParam("user", "-" + id);
            GetInformation.AddUrlParam("v", "5.95");
            string Result = GetInformation.Get(__VKAPIURL + "execute.GetPosts").ToString();

            if (Result == null || Result.IndexOf("error") > 0)
            {
                return Posts;
            }
            else
            {

                if (Result.Length > 0)
                {
                    Posts.AddRange(Result.Split('[')[1].Split(']')[0].Split('|'));
                }
                Posts.RemoveAll(x => x.Length < 4);
            }
            return Posts;
        }

        public List<String> GetGroups(string id)
        {
            List<String> Groups = new List<string>();

            //int count;

            HttpRequest GetInformation = new HttpRequest();
            //GetInformation.AddUrlParam("user_ids", UserId);
            GetInformation.AddUrlParam("access_token", _Token);

            //string Params = "";
            //foreach (string i in Fields)
            //{
            //    Params += i + ",";
            //}
            //Params = Params.Remove(Params.Length - 1);
            //GetInformation.AddUrlParam("fields", Params);
            GetInformation.AddUrlParam("user", id);
            GetInformation.AddUrlParam("v", "5.95");
            string Result = GetInformation.Get(__VKAPIURL + "execute.GetGroups").ToString();

            if (Result == null || Result.IndexOf("error") > 0)
            {
                return Groups;
            }
            else
            {

                if (Result.Length > 0)
                {
                    Groups.AddRange(Result.Split('[')[1].Split(']')[0].Split(','));
                }
                Groups.RemoveAll(x => x.Length == 0);
            }
            return Groups;
        }

    }
}