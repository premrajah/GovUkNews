using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UKGovNews.Models
{
    public class MainViewModel
    {
        
        public readonly string CopyrightText = "Copyright belongs to respective copyright holders, Information publicly avaliable on website gov.uk";
        public List<PostItem> PostItems { get; set; }

        public MainViewModel()
        {
            
        }
    }
}
