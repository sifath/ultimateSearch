using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateSearch.bll.SearchHandler;

namespace UltimateSearch.bll
{
    public class SearchKey
    {
        public string searchQuery;
        public List<string> selectedLocation = new List<string>();
        public string sortBy;
        public int lowerPriceRange;
        public int upperPriceRange;

    }
}
