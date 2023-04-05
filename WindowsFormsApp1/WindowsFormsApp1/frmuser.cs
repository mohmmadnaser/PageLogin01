using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmuser : Form
    {
        public frmuser()
        {
            InitializeComponent();
        }

        private User user1;
        private User user2;
        private User user3;
        


        public List<User> users;


        private void frmuser_Load(object sender, EventArgs e)
        {
            user1 = new User();
            user1.UserId = 1;
            user1.FullName = "mohmmad naser";
            user1.Username = "MN";
            user1.Password = "1991";

            user2 = new User();
            user2.UserId = 2;
            user2.FullName = "ahmmad ";
            user2.Username = "AA";
            user2.Password = "5678";

            user3 = new User();
            user3.UserId = 3;
            user3.FullName = "mask ";
            user3.Username = "MA";
            user3.Password = "2020";



            users = new List<User>();

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            

             if (user1.Password == txtpassword.Text)
            { 

                    MessageBox.Show("Welcome " + user1.FullName);
            }
             else if (user2.Password == txtpassword.Text)
            {

                MessageBox.Show("Welcome " + user2.FullName);
            }
             else if (user3.Password == txtpassword.Text)
            {

                MessageBox.Show("Welcome " + user3.FullName);
            }

             else if (user1.Username != txtusername.Text)
            {
                MessageBox.Show("User does not exist");

            }
             else if (user2.Username != txtusername.Text)
            {
                MessageBox.Show("User does not exist");

            }
            else if (user3.Username != txtusername.Text)
            {
                MessageBox.Show("User does not exist");

            }
            else
                {
                    MessageBox.Show("Wrong password");
                }



            }


        }
    }

        







