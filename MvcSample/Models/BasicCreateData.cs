using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
    public class BasicCreateData
    {
        [Required(ErrorMessage = "錯誤訊息 : 必填欄位")]
        [StringLength(30,ErrorMessage ="錯誤訊息 : 超過長度 {0} ,{1}")]
        public string Name { get; set; }
        public string Memo { get; set; }
    }
}