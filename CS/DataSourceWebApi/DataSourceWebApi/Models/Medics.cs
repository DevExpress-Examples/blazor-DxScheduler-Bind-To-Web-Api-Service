using System;
using System.Collections.Generic;

namespace DataSourceWebApi.Models
{
    public partial class Medics
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public byte[] PhotoBytes { get; set; }
    }
}
