using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 簡易電子琴
{
    public partial class frmBeepPlayer: Form
    {
        public frmBeepPlayer()
        {
            InitializeComponent();
            InitializeButton(); // 必須呼叫此行，琴鍵點擊才會生效
        }
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);
        int[] freq = { 523, 587, 659, 698, 784, 880, 988, 1046 };

        int initWidth = 0;
        int initHeight = 0;
        // Define the Rect structure
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;

            public Rect(int left, int top, int width, int height)
            {
                Left = left;
                Top = top;
                Width = width;
                Height = height;
            }
        }
        Dictionary<string, Rect> initControl = new Dictionary<string, Rect>();

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            Beep(freq[btn.TabIndex], 300);
            btn.Enabled = true;
        }
        private void InitializeButton()
        {
            // 讓btn1~btn8共用同一個事件處理函式
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
            button6.Click += button1_Click;
            button7.Click += button1_Click;
            button8.Click += button1_Click;
        }

        private void frmBeepPlayer_Load(object sender, EventArgs e)
        {
            this.initWidth = this.palMain.Width;
            this.initHeight = this.palMain.Height;
            foreach (Control ctl in this.palMain.Controls)
            {
                this.initControl.Add(ctl.Name, new Rect(ctl.Left, ctl.Top,
                ctl.Width, ctl.Height));
            }
        }

        private void frmBeepPlayer_SizeChanged(object sender, EventArgs e)
        {
            // 1.防呆：如果字典還沒初始化（是空的），就先跳過，避免啟動時崩潰
            if (initControl == null || initControl.Count == 0) return;
            double width = this.palMain.Width;
            double height = this.palMain.Height;
            // 2. 防呆：避免除以零（當視窗縮到最小時）
            if (this.initWidth == 0 || this.initHeight == 0) return;
            double iRatioWith = width / this.initWidth;
            double iRatioHeight = height / this.initHeight;
            foreach (Control ctl in this.palMain.Controls)
            {
                // 3. 安全檢查：確保字典裡真的有這個控制項的原始資料
                if (initControl.ContainsKey(ctl.Name))
                {
                    var originalRect = initControl[ctl.Name];
                    ctl.Left = (int)(originalRect.Left * iRatioWith);
                    ctl.Top = (int)(originalRect.Top * iRatioHeight);
                    ctl.Width = (int)(originalRect.Width * iRatioWith);
                    ctl.Height = (int)(originalRect.Height * iRatioHeight);
                }

            }
        }
    }
}
