using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Entity
{
    public enum EnumOrderState
    {
        [Display(Name ="Onay Bekleniyor")]
        Bekliyor,
        [Display(Name = "Kargoya Verildi")]
        Kargoda,
        [Display(Name = "Tamamlandı")]
        Tamamlandı


    }
}