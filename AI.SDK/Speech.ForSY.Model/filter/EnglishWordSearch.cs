using System;
using System.Collections.Generic;
using System.Text;

namespace Speech.ForSY.Model.filter
{
    public class EnglishWordSearch
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
        public string CatagoryID { get; set; }
    }
}
