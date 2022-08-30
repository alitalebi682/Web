using CobiWebSite.Model.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.News.Entities

{
    public class GroupNews :BaseEntity

    {
        
        [Display(Name = "گروه اخبار")]
        [Required(ErrorMessage = "لطفا مقدار {0} را وارد کنید")]
        [StringLength(100, ErrorMessage = "طول {0} میبایست بین {2} تا {1} کاراکتر باشد", MinimumLength = 5)]
        public string GroupNewsName { get; set; }

       
        
    }

    
}

