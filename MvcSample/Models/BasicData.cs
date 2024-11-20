using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSample.Models
{
    public class BasicData
    {
        [DisplayName("編號")]
        public int Id { get; set; }
        [DisplayName("名稱")]
        public string Name { get; set; }
        [DisplayName("備註")]
        public string Memo { get; set; }
    }
}