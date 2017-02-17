using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebSite2.Models
{
    public class Reel : Product
    {
        public Reel() { }
      public  Reel(int Id, int Categoryid, string Name, string friction) : base(Id,Categoryid,Name){

            this.Friction = friction;
        }
        public int Inches_per_Crank { get; set; }
        public string Friction { get; set; }
        public string BearingsNumber { get; set; }
        public float GearRatio { get; set; }       
    }
}