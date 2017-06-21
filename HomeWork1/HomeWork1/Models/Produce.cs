using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeWork.Models
{
    public enum MyType
    {
        [Display(Name ="支出")]
        Expend,
        [Display(Name ="收入")]
        Income
    }
    public class Produce
    {
        [Key]
        [Display(Name ="項次")]
        public int Id { get; set; }
        [Display(Name = "類別")]
        public MyType Type { get; set; }
        [Display(Name = "金額")]
        public double Money { get; set; }
        [Display(Name = "日期")]
        public DateTime Date { get; set; }
        [Display(Name = "備註")]
        public string Note { get; set; }

    }
}