using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDCard
{
    public class IDCardFactory : Factory
    {
        private int _id = 100;
        private Dictionary<int, IDCard> _cards = new(); 
        protected override Product CreateProduct(string owner)
        {
            var newCard = new IDCard(owner,_id++);

            return newCard;
        }

        protected override void RegisterProduct(Product product)
        {
            Console.WriteLine(product + "を登録しました。");
        }

        public IDCard GetIDCardAt(int id)
        {
            return _cards[id];
        }
    }
}
