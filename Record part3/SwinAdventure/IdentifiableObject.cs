using System;
using System.Collections.Generic;
using System.Linq;
using SwinAdventure;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class IdentifiableObject
    {
        List<string> _identifier = new List<string>();
        public IdentifiableObject(String[] Idents)
        {
            _identifier.AddRange(Idents);
        }

        public bool AreYou(string id)
        {
            foreach (string Check in _identifier)
            {
                if (id == Check)
                { return true; }
            }
            return false;
        }
        public string FirstId
        {
            get
            {
                if (_identifier.Count == 0)
                { return " "; }
                else
                { return _identifier.First(); }
            }
        }

        public void AddIdentifier(string id)
        {
            _identifier.Add(id.ToLower());
        }
    }
}
