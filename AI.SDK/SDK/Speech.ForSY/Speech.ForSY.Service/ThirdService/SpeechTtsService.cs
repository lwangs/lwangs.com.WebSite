using Speech.ForSY.Service.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Speech.ForSY.Service.ThirdService
{
    public class SpeechTtsService
    {
        #region SpeechSynthesis根据当前文本内容  转换成对于的语音信息  写入本地文件
        public static bool SpeechSynthesis(string fileName, string readContent)
        {
            bool isSuccess = false;

            try
            {
                var _ttsClient = new Baidu.Aip.Speech.Tts(StringResource.BaiduSpeechAPIKey, StringResource.BaiduSpeechSecretKey);
                _ttsClient.Timeout = 5000;  // 修改超时时间

                //tex String  合成的文本，使用UTF - 8编码， 
                //cuid String  用户唯一标识，用来区分用户， 
                //spd String  语速，取值0 - 9，默认为5中语速 否
                //pit String  音调，取值0 - 9，默认为5中语调 否
                //vol String  音量，取值0 - 15，默认为5中音量 否
                //per String  发音人选择, 0为女声，1为男声，3为情感合成 - 度逍遥，4为情感合成 - 度丫丫

                var option = new Dictionary<string, object>()
                {
                    {"spd", 3}, // 语速
                    {"vol", 13}, // 音量
                    {"pit", 4}, // 音调
                    {"per", 0}  // 发音人，4：情感度丫丫童声
                };

                var result = _ttsClient.Synthesis(readContent, option);

                if (result.ErrorCode == 0)  // 或 result.Success
                {
                    File.WriteAllBytes(string.Format("wwwroot/audio/{0}.mp3", fileName), result.Data);
                    isSuccess = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return isSuccess;
        }
        #endregion


    }
}
