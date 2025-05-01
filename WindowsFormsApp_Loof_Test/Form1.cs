using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Loof_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_result.Text = ""; // input버튼 클릭 할 때 마다 빈칸으로 초기화 😊

            int students;
            bool check = int.TryParse(textBox_input.Text, out students);

            if (check)
            {
                Random random = new Random();
                string[] student = new string[students];

                for (int i = 0; i < students; i++)
                {
                    student[i] = $"학생 {(i + 1).ToString()}의 점수: {random.Next(0, 101)}점 😊";
                    textBox_result.Text += student[i] + "\r\n";
                }

            }
            else
            {
                textBox_result.Text = "숫자만 정확히 입력 해주세요 😊";
            }
        }
    }
}
