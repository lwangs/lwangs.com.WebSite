using System;
using System.Collections.Generic;
using System.Text;

namespace Speech.ForSY.Model
{
    /// <summary>
    /// 所有单词 实体类
    /// </summary>
    public class EnglishWordsModel
    {
        /// <summary>
        /// 单词编号ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 英文单词
        /// </summary>
        public string English { get; set; }
         
        /// <summary>
        /// 单词所属分类
        /// </summary>
        public string CatagoryTitle { get; set; }
         
        /// <summary>
        /// 默认图片
        /// </summary>
        public string DefaultImages { get; set; }

        /// <summary>
        /// 单词英、美发音标识
        /// </summary>
        public string PhoneticSymbol { get; set; }

        /// <summary>
        /// 中文解释
        /// </summary>
        public string Chiness { get; set; }

        /// <summary>
        /// 单词备注信息
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 第三方发音Bit文件
        /// </summary>
        public string VoiceByte { get; set; }

        /// <summary>
        /// 物理文件存放地址
        /// </summary>
        public string VoiceFullFilePath { get; set; }

        /// <summary>
        /// 单词所属分类
        /// </summary>
        public string CatagoryID { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int OrderBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }

    }
}
