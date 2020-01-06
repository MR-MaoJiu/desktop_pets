using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Threading;
/*时间：2017.96日
 * 作者：猫九先森
 * 联系QQ：481869314
 * 作者留言：此程序为我无聊时写的大家可以补充一下功能但是修改好希望可以
 * 把代码发给我，我们一起完善这个好玩的小宠物，可以的话建一个群方便大家
 * 修改，修改时希望大家尽量写一下注释和修改了那些代码增加了那些功能！
 * 修改者：
 * 联系方式：
 * 修改时间：
 * 修改内容：
 */
namespace 不做单身狗__桌面宠物
{
    public partial class cw : Form
    {

        private string a;
        bool run = false,bf=false ;
        SoundPlayer zl;
        Form1 f = new Form1();
        public cw(string str)
        {
            InitializeComponent();
            this.a = str;
            TransparencyKey = BackColor;
            pictureBox1.Focus();
        }//构造函数
        private void cw_Load(object sender, EventArgs e)//加载宠物
        {
            zheng();

                ts.Start();
            
            
        }
        #region 宠物动作  
        public void qian()
        {
          
                if (run == false)
                {
                    System.Reflection.Assembly assembly;

                    assembly = System.Reflection.Assembly.GetExecutingAssembly();
                    zl = new SoundPlayer(Properties.Resources.走路);
                    zl.PlayLooping();//循环播放
                    if (a == "男1") { pictureBox1.Image = Properties.Resources.男1前; }
                    if (a == "男2") { pictureBox1.Image = Properties.Resources.男2前; }
                    if (a == "男3") { pictureBox1.Image = Properties.Resources.男3前; }
                    if (a == "女1") { pictureBox1.Image = Properties.Resources.女1前; }
                    if (a == "女2") { pictureBox1.Image = Properties.Resources.女2前; }
                    if (a == "女3") { pictureBox1.Image = Properties.Resources.女3前; }
                    run = true;
                }

              //pictureBox1.Top = pictureBox1.Top -1;
            panel1.Top = panel1.Top -1;

        }
        public void hou()
        {

                if (run == false)
                {
                    System.Reflection.Assembly assembly;
                    assembly = System.Reflection.Assembly.GetExecutingAssembly();
                    zl = new SoundPlayer(Properties.Resources.走路);
                    zl.PlayLooping();//循环播放
                    bf = true;
                    if (a == "男1") { pictureBox1.Image = Properties.Resources.男1后; }
                    if (a == "男2") { pictureBox1.Image = Properties.Resources.男2后; }
                    if (a == "男3") { pictureBox1.Image = Properties.Resources.男3后; }
                    if (a == "女1") { pictureBox1.Image = Properties.Resources.女1后; }
                    if (a == "女2") { pictureBox1.Image = Properties.Resources.女2后; }
                    if (a == "女3") { pictureBox1.Image = Properties.Resources.女3后; }

                    run = true;
                }

              //pictureBox1.Top = pictureBox1.Top + 1;
            panel1.Top =panel1 .Top+1;
         }
        public void zuo()
        {

                if (run == false)
                {
                    System.Reflection.Assembly assembly;

                    assembly = System.Reflection.Assembly.GetExecutingAssembly();
                    zl = new SoundPlayer(Properties.Resources.走路);
                    zl.PlayLooping();//循环播放
                    bf = true;
                    if (a == "男1") { pictureBox1.Image = Properties.Resources.男1左; }
                    if (a == "男2") { pictureBox1.Image = Properties.Resources.男2左; }
                    if (a == "男3") { pictureBox1.Image = Properties.Resources.男3左; }
                    if (a == "女1") { pictureBox1.Image = Properties.Resources.女1左; }
                    if (a == "女2") { pictureBox1.Image = Properties.Resources.女2左; }
                    if (a == "女3") { pictureBox1.Image = Properties.Resources.女3左; }

                    run = true;
                }

              //pictureBox1.Left = pictureBox1.Left - 1;
            panel1.Left = panel1.Left - 1;
        }
        public void you()
        {

                if (run == false)
                {
                    System.Reflection.Assembly assembly;

                    assembly = System.Reflection.Assembly.GetExecutingAssembly();
                    zl = new SoundPlayer(Properties.Resources.走路);
                    zl.PlayLooping();//循环播放
                    bf = true;
                    if (a == "男1") { pictureBox1.Image = Properties.Resources.男1右; }
                    if (a == "男2") { pictureBox1.Image = Properties.Resources.男2右; }
                    if (a == "男3") { pictureBox1.Image = Properties.Resources.男3右; }
                    if (a == "女1") { pictureBox1.Image = Properties.Resources.女1右; }
                    if (a == "女2") { pictureBox1.Image = Properties.Resources.女2右; }
                    if (a == "女3") { pictureBox1.Image = Properties.Resources.女3右; }
                    run = true;
                }

            //pictureBox1.Left = pictureBox1.Left +1;
            panel1.Left = panel1.Left + 1;
        }
        public void zheng()
        {
            if (a == "男1") { pictureBox1.Image = Properties.Resources.男1正; }
            if (a == "男2") { pictureBox1.Image = Properties.Resources.男2正; }
            if (a == "男3") { pictureBox1.Image = Properties.Resources.男3正; }
            if (a == "女1") { pictureBox1.Image = Properties.Resources.女1正; }
            if (a == "女2") { pictureBox1.Image = Properties.Resources.女2正; }
            if (a == "女3") { pictureBox1.Image = Properties.Resources.女3正; }
            
        }
        public void fa()
        {

                if (run == false)
                {
                    System.Reflection.Assembly assembly;
                    assembly = System.Reflection.Assembly.GetExecutingAssembly();
                    zl = new SoundPlayer(Properties.Resources.Q);
                    zl.PlayLooping();//循环播放
                    bf = true;
                    if (a == "男1") { pictureBox1.Image = Properties.Resources.男1法; }
                    if (a == "男2") { pictureBox1.Image = Properties.Resources.男2法; }
                    if (a == "男3") { pictureBox1.Image = Properties.Resources.男3法; }
                    if (a == "女1") { pictureBox1.Image = Properties.Resources.女1法; }
                    if (a == "女2") { pictureBox1.Image = Properties.Resources.女2法; }
                    if (a == "女3") { pictureBox1.Image = Properties.Resources.女3法; }
                    run = true;
                 }                
        }
        #endregion

        #region 拖动宠物
        //是否正在拖拽 
        bool isDrag = false;
        //鼠标按下坐标（control控件的相对坐标） 
        Point mouseDownPoint = Point.Empty;
        //将被拖动的控件 
        private Control control;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrag = true;
            control = panel1; //pictureBox1;
            if (e.Button == MouseButtons.Left)
            {
                mouseDownPoint = panel1.Location;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                Point mousePos = new Point(control.Location.X, control.Location.Y);
                mousePos.Offset(e.X, e.Y);
                mousePos.X -= this.control.Width / 7;
                mousePos.Y -= this.control.Height / 7;
                control.Location = mousePos;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                isDrag = false;
            }
        }
        #endregion
        private void cw_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)//执行动作
        {
            if (e.KeyValue == 87) { qian(); }
            if (e.KeyValue == 83) { hou (); }
            if (e.KeyValue == 65) { zuo (); }
            if (e.KeyValue == 68) { you (); }
            if (e.KeyValue == 81) { fa  (); }
            if (e.KeyValue == 27) {Application.Exit();ts.Abort(); }
        }
        private void cw_KeyUp(object sender, KeyEventArgs e)//结束动作
        {
            zheng();
            if (bf == true)
            { zl.Stop();}
            
            run = false ;
        }
        Thread ts = new Thread(Function.Ts);//按时提示功能
        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)//对话
        {
            SpVoice voice = new SpVoice();
            voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
            voice.Speak("亲爱的，好期待和您讲话啊！再耐心等等吧！等我爸爸给我这个功能！", SpeechVoiceSpeakFlags.SVSFDefault);
            

            

        }


    }
}
