using Speech.ForSY.Service.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Speech.ForSY.Service
{
    public class SpeechTtsService
    {
        #region SpeechSynthesis根据当前文本内容  转换成对于的语音信息  写入本地文件
        public static void SpeechSynthesis()
        { 
            var _ttsClient = new Baidu.Aip.Speech.Tts(StringResource.BaiduSpeechAPIKey, StringResource.BaiduSpeechSecretKey);
            _ttsClient.Timeout = 5000;  // 修改超时时间
             
            // 可选参数
            var option = new Dictionary<string, object>()
            {
                {"spd", 2}, // 语速
                {"vol", 8}, // 音量
                {"per", 4}  // 发音人，4：情感度丫丫童声
            };
            var result = _ttsClient.Synthesis("i love my mother", option);

            if (result.ErrorCode == 0)  // 或 result.Success
            {
                File.WriteAllBytes("aaa.mp3", result.Data);
            }
        }
        #endregion


    }
}
