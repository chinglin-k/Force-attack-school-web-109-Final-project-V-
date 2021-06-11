using System;
using System.Windows.Forms;

namespace _01_02_
{
    public partial class Form1 : Form
    {
        int sum = 0, save = 0, gen = 0;
        int n1 = 0, n2 = 0, n3 = 0, n4 = 0, n5 = 0, n6 = 0, n7 = 0, n8 = 0;// n1~n4是前四碼、n5~n8是後四碼、n8是驗證碼
        string ch, g;
        bool FFchecknum, LFchecknum, Lchecknum, Schecknum;
        public Form1()
        {
            InitializeComponent();
        }

        //WIKI有ID_check可對照
        private void radioButton3_CheckedChanged(object sender, EventArgs e)//台北市Button3 -> 10
        {
            save = (1 * 1) + (0 * 9);
            ch = "A";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)//台中市Button4 -> 11
        {
            save = (1 * 1) + (1 * 9);
            ch = "B";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)//基隆市Button5 -> 12
        {
            save = (1 * 1) + (2 * 9);
            ch = "C";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)//台南市Button6 -> 13
        {
            save = (1 * 1) + (3 * 9);
            ch = "D";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)//高雄市Button7 -> 14
        {
            save = (1 * 1) + (4 * 9);
            ch = "E";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)//新北市Button8 -> 15
        {
            save = (1 * 1) + (5 * 9);
            ch = "F";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)//宜蘭縣Button9 -> 16
        {
            save = (1 * 1) + (6 * 9);
            ch = "G";
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)//桃園市Button10 -> 17
        {
            save = (1 * 1) + (7 * 9);
            ch = "H";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)//嘉義市Button11 -> 34
        {
            save = (3 * 1) + (4 * 9);
            ch = "I";
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)//新竹縣Button12 -> 18
        {
            save = (1 * 1) + (8 * 9);
            ch = "J";
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)//苗栗縣Button13 -> 19
        {
            save = (1 * 1) + (9 * 9);
            ch = "K";
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)//南投縣Button14 -> 21
        {
            save = (2 * 1) + (1 * 9);
            ch = "M";
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)//彰化縣Button15 -> 22
        {
            save = (2 * 1) + (2 * 9);
            ch = "N";
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)//新竹市Button16 -> 35
        {
            save = (3 * 1) + (5 * 9);
            ch = "O";
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)//雲林縣Button17 -> 23
        {
            save = (2 * 1) + (3 * 9);
            ch = "P";
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)//嘉義縣Button18 -> 24
        {
            save = (2 * 1) + (4 * 9);
            ch = "Q";
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)//屏東縣Button19 -> 27
        {
            save = (2 * 1) + (7 * 9);
            ch = "T";
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)//花蓮縣Button20 -> 28
        {
            save = (2 * 1) + (8 * 9);
            ch = "U";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)//台東縣Button21 -> 29
        {
            save = (2 * 1) + (9 * 9);
            ch = "V";
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)//金門縣Button22 -> 32
        {
            save = (3 * 1) + (2 * 9);
            ch = "W";
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)//澎湖縣Button23 -> 30
        {
            save = (3 * 1) + (0 * 9);
            ch = "X";
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)//連江縣Button24 -> 33
        {
            save = (3 * 1) + (3 * 9);
            ch = "Z";
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)//台中縣Button25 -> 20
        {
            save = (2 * 1) + (0 * 9);
            ch = "L";
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)//台南縣Button26 -> 25
        {
            save = (2 * 1) + (5 * 9);
            ch = "R";
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)//高雄縣Button27 -> 26
        {
            save = (2 * 1) + (6 * 9);
            ch = "S";
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)//陽明山Button28 -> 31
        {
            save = (3 * 1) + (1 * 9);
            ch = "Y";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//男Button1 -> 1
        {
            gen = (1 * 8);
            g = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//女Button2 -> 2
        {
            gen = (2 * 8);
            g = "2";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)//前四碼、n1~n4
        {
            int FFnum;
            int[] F_F = new int[4];
            FFchecknum = false;

            try
            {
                FFnum = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                FFchecknum = false;
                MessageBox.Show("輸入錯誤，請重新輸入");
                textBox2.Text = "";
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                F_F[i] = FFnum % 10;
                FFnum = FFnum / 10;
            }
            n4 = F_F[0];
            n3 = F_F[1];
            n2 = F_F[2];
            n1 = F_F[3];

            FFchecknum = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//末四碼、n5~n8
        {
            int LFnum;
            int[] L_F = new int[4];
            LFchecknum = false;

            try
            {
                LFnum = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
                LFchecknum = false;
                MessageBox.Show("輸入錯誤，請重新輸入");
                textBox3.Text = "";
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                L_F[i] = LFnum % 10;
                LFnum = LFnum / 10;
            }
            n8 = L_F[0];
            n7 = L_F[1];
            n6 = L_F[2];
            n5 = L_F[3];

            LFchecknum = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//驗證碼、n8
        {
            int Lnum;
            Lchecknum = false;

            try
            {
                Lnum = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception)
            {
                Lchecknum = false;
                MessageBox.Show("輸入錯誤，請重新輸入");
                textBox4.Text = "";
                return;
            }

            n8 = Lnum;

            Lchecknum = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//網址
        {

        }

        private void button1_Click(object sender, EventArgs e)//start
        {
            textBox5.Clear();
            sum = 0;
            //label5.Text = Convert.ToString(sum);
            string strT = "", strF = "";

            if (FFchecknum == true)
            {   //n1~n4 // *7 *6 *5 *4

                sum = 0;
                sum = sum + save + gen;

                sum = sum + (n1 * 7);
                sum = sum + (n2 * 6);
                sum = sum + (n3 * 5);
                sum = sum + (n4 * 4);
                if (LFchecknum == true)//末四與驗證不能同時觸發
                {
                    sum = sum + (n5 * 3);
                    sum = sum + (n6 * 2);
                    sum = sum + (n7 * 1);
                    sum = sum + (n8 * 1);
                    //MessageBox.Show(Convert.ToString(sum));
                    if ((sum % 10) == 0)
                    {
                        strT = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "成功" + "\r\n";
                        textBox5.AppendText(strT);
                        Schecknum = true;//true後轉去http request
                    }
                    else
                    {
                        MessageBox.Show("ID無效，請重新輸入");
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                    }
                }
                else if (Lchecknum == true)//末四與驗證不能同時觸發 //n5,n6,n7 //*3*2*1
                {
                    sum = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            for (int k = 0; k < 10; k++)
                            {
                                n5 = i;
                                sum = sum + (n5 * 3);
                                n6 = j;
                                sum = sum + (n6 * 2);
                                n7 = k;
                                sum = sum + (n7 * 1);

                                sum = sum + save + gen;
                                sum = sum + (n1 * 7);
                                sum = sum + (n2 * 6);
                                sum = sum + (n3 * 5);
                                sum = sum + (n4 * 4);
                                sum = sum + (n8 * 1);

                                if ((sum % 10) == 0)
                                {
                                    strT = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "成功" + "\r\n";
                                    textBox5.AppendText(strT);
                                    //textBox5.AppendText(sum.ToString()+"\r\n");
                                    Schecknum = true;//true後轉去http request
                                }
                                else
                                {
                                    strF = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "失敗" + "\r\n";
                                    textBox5.AppendText(strF);
                                    //textBox5.AppendText(sum.ToString()+"\r\n");
                                }
                                sum = 0;
                            }
                        }
                    }
                }
                else if (LFchecknum == false && Lchecknum == false)//n5,n6,n7,n8 //*3*2*1*1
                {
                    sum = 0;
                    for (int i = 0; i < 10; i++)
                    { 
                        for (int j = 0; j < 10; j++)
                        {
                            for (int k = 0; k < 10; k++)
                            {
                                for (int m = 0; m < 10; m++)
                                {
                                    n5 = i;
                                    sum = sum + (n5 * 3);
                                    n6 = j;
                                    sum = sum + (n6 * 2);
                                    n7 = k;
                                    sum = sum + (n7 * 1);
                                    n8 = m;
                                    sum = sum + (n8 * 1);

                                    sum = sum + save + gen;
                                    sum = sum + (n1 * 7);
                                    sum = sum + (n2 * 6);
                                    sum = sum + (n3 * 5);
                                    sum = sum + (n4 * 4);

                                    if ((sum % 10) == 0)
                                    {
                                        strT = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "成功" + "\r\n";
                                        textBox5.AppendText(strT);
                                        Schecknum = true;//true後轉去http request
                                    }
                                    else
                                    {
                                        strF = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "失敗" + "\r\n";
                                        textBox5.AppendText(strF);
                                    }
                                    sum = 0;
                                }
                            }
                        }
                    }
                }
            }

            if (FFchecknum == false && LFchecknum == true && Lchecknum == false)
            {   //n5~n8 // *3 *2 *1 *1
                sum = 0;
                for (int i = 0; i < 10; i++)//n1~n4 // *7 *6 *5 *4
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                n1 = i;
                                sum = sum + (n1 * 7);
                                n2 = j;
                                sum = sum + (n2 * 6);
                                n3 = k;
                                sum = sum + (n3 * 5);
                                n4 = m;
                                sum = sum + (n4 * 4);

                                sum = sum + save + gen;
                                sum = sum + (n5 * 3);
                                sum = sum + (n6 * 2);
                                sum = sum + (n7 * 1);
                                sum = sum + (n8 * 1);

                                if ((sum % 10) == 0)
                                {
                                    strT = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "成功" + "\r\n";
                                    textBox5.AppendText(strT);
                                    Schecknum = true;//true後轉去http request
                                }
                                else
                                {
                                    strF = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "失敗" + "\r\n";
                                    textBox5.AppendText(strF);
                                }
                                sum = 0;
                            }
                        }
                    }
                }
            }

            if (FFchecknum == false && LFchecknum == false && Lchecknum == true)
            {   //n8 // *1
                sum = 0;
                for (int i = 0; i < 10; i++)//n1~n4 // *7 *6 *5 *4
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int n = 0; n < 10; n++)//n5,n6,n7 //*3*2*1
                                {
                                    for (int p = 0; p < 10; p++)
                                    {
                                        for (int q = 0; q < 10; q++)
                                        {
                                            n1 = i;
                                            sum = sum + (n1 * 7);
                                            n2 = j;
                                            sum = sum + (n2 * 6);
                                            n3 = k;
                                            sum = sum + (n3 * 5);
                                            n4 = m;
                                            sum = sum + (n4 * 4);
                                            n5 = n;
                                            sum = sum + (n5 * 3);
                                            n6 = p;
                                            sum = sum + (n6 * 2);
                                            n7 = q;
                                            sum = sum + (n7 * 1);

                                            sum = sum + save + gen;
                                            sum = sum + (n8 * 1);

                                            if ((sum % 10) == 0)
                                            {
                                                strT = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "成功" + "\r\n";
                                                textBox5.AppendText(strT);
                                                Schecknum = true;//true後轉去http request
                                            }
                                            else
                                            {
                                                strF = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "失敗" + "\r\n";
                                                textBox5.AppendText(strF);
                                            }
                                            sum = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (FFchecknum == false && LFchecknum == false && Lchecknum == false)
            {
                sum = 0;
                for (int i = 0; i < 10; i++)//n1~n4 // *7 *6 *5 *4
                {
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int m = 0; m < 10; m++)
                            {
                                for (int n = 0; n < 10; n++)//n5,n6,n7,n8 //*3*2*1*1
                                {
                                    for (int p = 0; p < 10; p++)
                                    {
                                        for (int q = 0; q < 10; q++)
                                        {
                                            for (int r = 0; r < 10; r++)
                                            {
                                                n1 = i;
                                                sum = sum + (n1 * 7);
                                                n2 = j;
                                                sum = sum + (n2 * 6);
                                                n3 = k;
                                                sum = sum + (n3 * 5);
                                                n4 = m;
                                                sum = sum + (n4 * 4);
                                                n5 = n;
                                                sum = sum + (n5 * 3);
                                                n6 = p;
                                                sum = sum + (n6 * 2);
                                                n7 = q;
                                                sum = sum + (n7 * 1);
                                                n8 = r;
                                                sum = sum + (n8 * 1);

                                                sum = sum + save + gen;

                                                if ((sum % 10) == 0)
                                                {
                                                    strT = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "成功" + "\r\n";
                                                    textBox5.AppendText(strT);
                                                    Schecknum = true;//true後轉去http request
                                                }
                                                else
                                                {
                                                    strF = ch + g + n1.ToString() + n2.ToString() + n3.ToString() + n4.ToString() + n5.ToString() + n6.ToString() + n7.ToString() + n8.ToString() + "失敗" + "\r\n";
                                                    textBox5.AppendText(strF);
                                                }
                                                sum = 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //
            //
            if (Schecknum == true)//http request
            {

            }
        }
    }
}
//label5=測試輸出  // label5.Text = Convert.ToString();