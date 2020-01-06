using SpeechLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class Function
    {
        public static string WorkTime//计算机运行时间
        {
            get
            {
                return ((Environment.TickCount / 0x3e8) / 60).ToString();
            }
        }
      public static void Ts()//按时提示
      {
          while(true)
            {
                if ( DateTime.Now.Minute == 00 ||DateTime.Now.Minute == 30 && DateTime.Now.Second==00)
                {
                    double sj = double.Parse(Function.WorkTime) / 60;
                    SpVoice voice = new SpVoice();
                    voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
                    if (sj > 4)
                    {
                        voice.Speak("亲爱的您已使用电脑" + Math.Floor(sj) + "个多小时了！请注意休息,累坏了人家会心疼的呢！", SpeechVoiceSpeakFlags.SVSFDefault);

                    }
                }
                if (DateTime.Now.Hour == 7 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 00)
                {
                    SpVoice voice = new SpVoice();
                    voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
                    voice.Speak("亲爱的现在已经7点了记得吃早餐啊！", SpeechVoiceSpeakFlags.SVSFDefault);
                    continue;
                }
                if (DateTime.Now.Hour == 11 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 00)
                {
                    SpVoice voice = new SpVoice();
                    voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
                    voice.Speak("亲爱的现在已经11点了记得吃午饭哦！", SpeechVoiceSpeakFlags.SVSFDefault);
                    continue;
                }
                if (DateTime.Now.Hour == 18 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 00)
                {
                    SpVoice voice = new SpVoice();
                    voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
                    voice.Speak("亲爱的现在已经晚上6点了快去吃晚饭呀！", SpeechVoiceSpeakFlags.SVSFDefault);
                    continue;
                }
                if (DateTime.Now.Hour == 23 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 00)
                {
                    SpVoice voice = new SpVoice();
                    voice.Voice = voice.GetVoices(string.Empty, string.Empty).Item(0);
                    voice.Speak("亲爱的现在已经晚上11点了还不快去睡觉！！！", SpeechVoiceSpeakFlags.SVSFDefault);
                    continue;
                }
              
            }
                        
        }

    }
}
