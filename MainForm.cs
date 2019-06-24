using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace VkAPITutorial
{
    public partial class MainForm : Form
    {
        static public User Current;
        static public Boolean groupcheck;
        static public Boolean checking;
        public static VkAPI _ApiRequest;
        private string _Token;  //Токен, использующийся при запросах
        private string _UserId;  //ID пользователя
        private Dictionary<string, string> _Response;  //Ответ на запросы

        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_GetToken_Click_1(object sender, EventArgs e)
        {
            AuthorizationForm GetToken = new AuthorizationForm();
            GetToken.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.Initialize();
            try
            {
                StreamReader ControlInf = new StreamReader("UserInf.txt");
                _Token = ControlInf.ReadLine();
                _UserId = ControlInf.ReadLine();
                ControlInf.Close();
                if (_Token != null)
                {
                    _ApiRequest = new VkAPI(_Token);
                    string[] Params = { "city", "country", "photo_max" };
                    _Response = _ApiRequest.GetInformation(_UserId, Params);
                    if (_Response != null)
                    {
                        User_ID.Text = _UserId;
                        User_Photo.ImageLocation = _Response["photo_max"];
                        User_Name.Text = _Response["first_name"];
                        User_Surname.Text = _Response["last_name"];
                        //User_Country.Text = _ApiRequest.GetCountryById(_Response["country"]);
                        //User_City.Text = _ApiRequest.GetCityById(_Response["city"]);
                        Button_GetToken.Visible = false;
                    }
                }
            }
            catch { }
        }

        private void Button_GetInformation_Click_1(object sender, EventArgs e)
        {
            try
            {
                StreamReader ControlInf = new StreamReader("UserInf.txt");
                _Token = ControlInf.ReadLine();
                ControlInf.Close();
                _ApiRequest = new VkAPI(_Token);
                _UserId = User_ID.Text;
                string[] Params = { "city" };
                _Response = _ApiRequest.GetInformation(_UserId, Params);
                if (_Response != null)
                {
                    User_ID.Text = _UserId;
                    //User_Photo.ImageLocation = _Response["photo_max"];
                    User_Name.Text = _Response["first_name"];
                    User_Surname.Text = _Response["last_name"];
                    //User_Country.Text = _ApiRequest.GetCountryById(_Response["country"]);
                    //User_City.Text = _ApiRequest.GetCityById(_Response["city"]);
                    Button_GetToken.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            _ApiRequest.GetUser(User_ID.Text);
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (checking)
            {
                
            }
            else
            {
                checking = true;
                checkBox_group.Enabled = false;
                button_Start.Text = "Stop";
                Data.Enqueue(User_ID.Text);
                AddFriends(Data.UsersQueue.Peek());
                Thread t = new Thread(delegate()
                {
                    Inspect();
                    //................................
                });
                t.Start();
            }
            
            //Inspect();
        }
       public void AddFriends(User user)
        {
            List<String> friends = new List<string>();
            friends = _ApiRequest.GetFriends(user.id);
            foreach (var item in friends)
            {
                Data.Enqueue(item);
            }
        }
       public void Inspect()
       {
           while (Data.UsersQueue.Count == 0) ;
           if (Data.UsersQueue.Count > 0 && checking)
           {
               Current = Data.UsersQueue.Dequeue();
               Dictionary.InspectUser(Current);
               Thread F = new Thread(delegate()
               {
                   if (Data.CheckCity(Current))
                   {
                       AddFriends(Current);
                   }
               });
               F.Start();
           }
           
           
           Invalidate();
           Inspect();
       }

       private void MainForm_Paint(object sender, PaintEventArgs e)
       {
           if (Current != null)
           {
               User_Name.Text = Current.firstname;

               User_Surname.Text = Current.lastname;

               label_checked.Text = "Проверено: " + Data.Users.FindAll(x => x.markered && !x.closed).Count;
           }
           
       }

       private void checkBox_group_CheckedChanged(object sender, EventArgs e)
       {
           groupcheck = checkBox_group.Checked;
       }
    }
}