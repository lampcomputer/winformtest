using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSave
{
    public partial class UserListHome : Form
    {
        public UserListHome()
        {
            InitializeComponent();

            if(System.IO.File.Exists("save.csv"))
            {
                List<UserInfoDto> dtos = new List<UserInfoDto>();
                var lines = System.IO.File.ReadAllLines("save.csv",System.Text.Encoding.GetEncoding("shift_jis"));
                foreach (var line in lines)
                {
                    var row = line.Split(',');

                    UserInfoDto dto = new UserInfoDto();
                    dto.Id = row[0];
                    dto.MailSend = row[1];
                    dto.MailAddress = row[2];
                    dto.Plan = row[3];
                    dto.EnableText = row[4];
                    dtos.Add(dto);

                    UserDataGrid.DataSource = dtos;

                    UserDataGrid.Columns[0].HeaderText = "ID";
                    UserDataGrid.Columns[1].HeaderText = "メール送信";
                    UserDataGrid.Columns[2].HeaderText = "メールアドレス";
                    UserDataGrid.Columns[3].HeaderText = "プラン";
                    UserDataGrid.Columns[4].HeaderText = "有効／無効";

                }
            }
        }
    }
}
