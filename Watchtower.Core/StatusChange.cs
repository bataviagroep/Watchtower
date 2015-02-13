using System;
using System.Collections.Generic;

namespace BataviaGroep.Watchtower.Core
{
    public class StatusChange
    {
        private StatusChange()
        {
            this.Date = DateTime.Now;
            this.Properties = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        public StatusChange(string name, StatusType type) : this()
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public StatusType Type { get; private set; }
        public IDictionary<string, string> Properties { get; private set; }
    }
}
