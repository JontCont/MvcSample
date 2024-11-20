using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
    public class BasicCreateData : BasicData
    {
        [DisplayName("舊名稱")]
        public string OldName { get; set; }
    }
}