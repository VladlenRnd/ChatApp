using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Data
{
    public class News
    {
        public string status { get; set; }

        public int totalResults { get; set; }

        public List<Articles> articles { get; set; }

    }
}
