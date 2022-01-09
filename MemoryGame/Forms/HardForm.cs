using MemoryGame.Models.Enum;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame.Forms
{
    public partial class HardForm : Form
    {
        /// <summary>
        /// 未完成組數
        /// </summary>
        private int Undone;

        /// <summary>
        /// 父表單
        /// </summary>
        private GameForm ParentGameForm;

        /// <summary>
        /// 第一次點擊
        /// </summary>
        PictureBox FirstClick;
        /// <summary>
        /// 第二次點擊
        /// </summary>
        PictureBox SecondClick;

        public HardForm(GameForm parentForm)
        {
            InitializeComponent();
            ParentGameForm = parentForm;

            // 此難度需要的牌數量
            int count = (int)LevelEnum.Hard;
            Undone = count;

            // 取得卡池
            Random rnd = new Random();
            Bitmap[] cardPool = CardEnum.GetCards
                                        .OrderBy(x => rnd.Next())
                                        .Take(count)
                                        .ToArray();
            // 複製一份
            cardPool = cardPool.Concat(cardPool)
                               .OrderBy(x => rnd.Next())
                               .Take(count * 2)
                               .ToArray();

            pictureBox1.Image = cardPool[0];
            pictureBox2.Image = cardPool[1];
            pictureBox3.Image = cardPool[2];
            pictureBox4.Image = cardPool[3];
            pictureBox5.Image = cardPool[4];
            pictureBox6.Image = cardPool[5];
            pictureBox7.Image = cardPool[6];
            pictureBox8.Image = cardPool[7];
            pictureBox9.Image = cardPool[8];
            pictureBox10.Image = cardPool[9];
            pictureBox11.Image = cardPool[10];
            pictureBox12.Image = cardPool[11];
        }

        /// <summary>
        /// 圖片點擊處理
        /// </summary>
        /// <param name="pictureBox">圖片物件</param>
        private void OnClick(PictureBox pictureBox)
        {
            ParentGameForm.AddClickCount();
            pictureBox.Enabled = false;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            if (FirstClick == null)
            {
                FirstClick = pictureBox;
                return;
            }
            else
            {
                SecondClick = pictureBox;
            }

            if (FirstClick.Image == SecondClick.Image)
            {
                FirstClick.Visible = false;
                SecondClick.Visible = false;
                Undone--;
            }

            FirstClick.Enabled = true;
            FirstClick.BorderStyle = BorderStyle.None;
            FirstClick = null;

            SecondClick.Enabled = true;
            SecondClick.BorderStyle = BorderStyle.None;
            SecondClick = null;

            // 全數按完
            if (Undone == 0)
            {
                // 獲勝
                ParentGameForm.GoToWin();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            OnClick(pictureBox12);
        }
    }
}
