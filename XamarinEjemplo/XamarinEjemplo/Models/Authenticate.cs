using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinEjemplo.Models
{
    public class Authenticate
    {
        public bool success { get; set; }
        public string type { get; set; }
        public string access_token { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}
