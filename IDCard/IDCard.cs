using Framework;

namespace IDCard
{
    public class IDCard : Product
    {
        private string _owner;
        private int _id;

        internal IDCard(string owner, int id)
        {
            Console.WriteLine(owner + "のカードをid:" + id +  " で作ります。");
            _owner = owner; 
            _id = id;
        }
        public override void Use()
        {
            Console.WriteLine(this + "を使います。");
        }

        public override string ToString()
        {
            return $"[IDCard:{_owner}({_id})]";
        }
    }
}
