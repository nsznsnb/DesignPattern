using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public enum HAND
    {
        ROCK = 0,
        SCISSORS = 1,
        PAPER = 2
    }


    public class Hand
    {
        private static Dictionary<HAND, Hand> _handDict = new Dictionary<HAND, Hand>()
        {
            { HAND.ROCK, new Hand(HAND.ROCK, "グー")}, 
            { HAND.SCISSORS, new Hand(HAND.SCISSORS, "チョキ")}, 
            { HAND.PAPER, new Hand(HAND.PAPER, "パー")}
        };

        private HAND _choice;
        private string _name;

        public HAND Choice { get {  return _choice; } }
        private Hand(HAND hand, string name)
        {
            _choice = hand;
            _name = name;
        }

        public static Hand GetInstance(int handValue)
        {
            return _handDict[(HAND)handValue];
        }

        public bool IsStrongerThan(Hand h)
        {
            return Fight(h) == 1;
        }

        public bool IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        public int Fight(Hand h)
        {
            if (this.Choice == h.Choice)
            {
                return 0;
            }
            else if (((int)this.Choice + 1) % 3 == (int)h.Choice)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
