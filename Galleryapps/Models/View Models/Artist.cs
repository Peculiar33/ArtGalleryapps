using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Galleryapps.Models.View_Models
{
    public class Artist
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public DateTime RegDate { get; set; }
    }
}