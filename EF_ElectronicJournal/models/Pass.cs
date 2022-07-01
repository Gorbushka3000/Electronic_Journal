using EF_ElectronicJournal.Models;
using System;
using System.Collections.Generic;

namespace EF_ElectronicJournal
{
    public partial class Pass : Ratings
    {
        public string? pass;
        public int Id { get; set; }
        public string? Pass1
        {
            get { return pass; }
            set
            {
                pass = value;
                OnPropertyChanged("Pass1");
            }
        }
    }
}
