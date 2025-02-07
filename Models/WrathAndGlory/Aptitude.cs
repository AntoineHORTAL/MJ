using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MJ.Models.WrathAndGlory
{
    public class Aptitude
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public Aptitude(int pId, string pType, string pDescription)
        {
            this.Id = pId;
            this.Type = pType;
            this.Description = pDescription;
        }
    }
}