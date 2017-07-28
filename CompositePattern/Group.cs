using System.Collections.Generic;

namespace CompositePattern
{
    public class Group : IParty
    {
        public Group()
        {
            Members = new List<IParty>();
        }

        public string Name { get; set; }
        public List<IParty> Members { get; set; }

        public int Gold
        {
            get
            {
                int totalGold = 0;
                foreach (var member in Members)
                {
                    totalGold += member.Gold;
                }
                return totalGold; 
            }

            set
            {
                var eachSplit = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Gold += eachSplit + leftOver;
                    leftOver = 0;
                }
            }

        }

        public void Statistics()
        {
            foreach (var member in Members)
            {
                member.Statistics();
            }
        }
    }
}
