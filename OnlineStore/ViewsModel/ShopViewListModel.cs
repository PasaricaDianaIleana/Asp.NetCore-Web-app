using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel
{
    public class ShopViewListModel
    {
        public IEnumerable<ProductsViewModel> products { get; set; }
        public IEnumerable<CategoryViewModel> categories { get; set; }
    }
}
