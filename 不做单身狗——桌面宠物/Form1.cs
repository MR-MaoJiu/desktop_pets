using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }
        SoundPlayer sp, qh;
        string a="男1";
        public string Checked()
        {
            if (radioButton1.Checked) { a = "男1"; }
            if (radioButton2.Checked) { a = "男2"; }
            if (radioButton3.Checked) { a = "男3"; }
            if (radioButton4.Checked) { a = "女1"; }
            if (radioButton5.Checked) { a = "女2"; }
            if (radioButton6.Checked) { a = "女3"; }
            return a;
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly;
            assembly = System.Reflection.Assembly.GetExecutingAssembly();
            qh= new SoundPlayer(Properties.Resources.切换);
            qh.Play();
            cw c = new 不做单身狗__桌面宠物.cw (a);
            c.Show();
            Hide();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            Checked();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢您的使用，目前本桌面宠物有前后左右法功能分别为:WSADQ键来控制，鼠标可拖动宠物哦，按：ESC键退出，当计算机连续使用超过四小时时每隔30分钟提醒您休息一次，早中晚会提醒您吃饭和休息！如有问题联系作者：猫九先森QQ：481869314，再次感谢您的使用，本软件已开源需要源码联系猫九先森哦！","系统提示：");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Reflection.Assembly assembly;   
            assembly = System.Reflection.Assembly.GetExecutingAssembly();
            sp = new SoundPlayer(Properties.Resources.bg);
            sp.PlayLooping();//循环播放
        }


    }
}
