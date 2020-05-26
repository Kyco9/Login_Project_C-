using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Viết hàm kết nối database và đi lấy chuổi kết nối
        //đây là chuỗi Data Source=TRUNG\SQLEXPRESS;Initial Catalog=QL_Cafee;Integrated Security=True
        public SqlConnection getConnec()
        {
            return new SqlConnection(@"Data Source=TRUNG\SQLEXPRESS;Initial Catalog=QL_Cafee;Integrated Security=True");
        }

        

       

        //Hàm kiếm tra tài khoản
        /*public DataTable checkLog(string user, string pass)
        {
            string sql = "select * from abc where username = '" +user+"' and pass = '"+pass+"'";
            SqlConnection con = getConnec();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }*/

        //Hàm lấy ID người dùng
        private string getID()
        {
            string id = "";

            try
            {
                string sql = "select * from abc where username = '" + this.txtB_User.Text + "' and pass = '" + this.txtB_Pass.Text + "'";
                SqlConnection con = getConnec();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if(dt !=null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        id = dr["quyen"].ToString();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
            return id;
        }


        //Hàm xử lý khi nhấn nút đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             if (this.txtB_User.TextLength == 0 || this.txtB_Pass.TextLength == 0)
             {
                 this.labelStatus.ForeColor = Color.Red;
                 this.labelStatus.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
                 this.txtB_User.Clear();
                 this.txtB_Pass.Clear();
                 this.txtB_User.Focus();

             }
             else
             {
                 DataTable dt = new DataTable();
                 dt = checkLog(this.txtB_User.Text, this.txtB_Pass.Text);
                 if (dt.Rows.Count > 0)
                 {
                     //login thành công mở form main và đóng form login 
                     this.Hide();
                     frAdmin frMain = new frAdmin();
                     frMain.Show();
                 }
                 else
                 {
                     //Login thất bại thông báo lỗi

                     this.labelStatus.ForeColor = Color.Red;
                     this.labelStatus.Text = "Tài khoản không tồn tại";
                     this.txtB_User.Clear();
                     this.txtB_Pass.Clear();
                     this.txtB_User.Focus();
                 }
             }*/
            if (this.txtB_User.TextLength == 0 || this.txtB_Pass.TextLength == 0)
            {
                this.labelStatus.ForeColor = Color.Red;
                this.labelStatus.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
                this.txtB_User.Clear();
                this.txtB_Pass.Clear();
                this.txtB_User.Focus();
            }
            else
            {
                string a = getID();
                if (a == "admin     ")//csdl cột quyền có 10 ký tự
                {
                    this.Hide();
                    frAdmin frMain = new frAdmin();
                    frMain.Show();
                }
                else if (a == "user      ")
                {
                    this.Hide();
                    FormKH frM = new FormKH();
                    frM.Show();
                }
                else
                {
                    //Login thất bại thông báo lỗi
                    this.labelStatus.ForeColor = Color.Red;
                    this.labelStatus.Text = "Tài khoản không tồn tại";
                    this.txtB_User.Clear();
                    this.txtB_Pass.Clear();
                    this.txtB_User.Focus();
                }
            }
        }

        //Hàm thoát chương trình khi nhấn nút THOÁT
        private void but_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = but_Login;

            //Kiếm tra kết nối csdl
            try
            {
                SqlConnection con = getConnec();
                this.Status.Text = "Kết nối cơ sở dữ liệu thành công";
            }

            catch
            {
                this.Status.Text = "Kết nối cơ sở dữ liệu thất bại";
            }
        }

        
    }
}
