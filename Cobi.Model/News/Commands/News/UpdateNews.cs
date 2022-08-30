using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobi.Model.News.Commands.News
{
    public class UpdateNews : IRequest<ApplicationServiceResponse<NewsBase>>
    {

        public int Id { get; set; }
        [Display(Name = "نوع خبر ")]
        public string Type { get; set; }

        [Display(Name = "رو تیتر")]
        public string? Rowtitle { get; set; }

        [Display(Name = "لید خبر")]
        public string? Rowmainnews { get; set; }

        [Display(Name = "اولویت نمایش")]
        public int? Showpriority { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime Startdate { get; set; }

        [Display(Name = "تاریخ پایان")]
        public DateTime Enddate { get; set; }

        [Display(Name = "تصویر اصلی")]
        public string AttachpicturemainUrl { get; set; }

        [Display(Name = "تصاویر")]
        public string AttachpicturesUrl { get; set; }


        [Display(Name = "نمایش پروفایل")]
        public bool Showprofile { get; set; }

        [Display(Name = "اخبار برگزیده")]
        public string Slectnews { get; set; }

        [Display(Name = "متن اصلی")]
        [Required]
        public string Mainnews { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Keywordnews { get; set; }


        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "فعال")]
        public Boolean IsActive { get; set; }





    }


}
   
