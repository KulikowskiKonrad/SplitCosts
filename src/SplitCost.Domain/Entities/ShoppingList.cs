using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitCost.Domain.Entities
{
    public class ShoppingList
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ModificationDate { get; private set; }
        public List<ShoppingListItem> Items { get; private set; }

        private ShoppingList()
        {
            // For EF
        }

        public ShoppingList(Guid id, string name, List<ShoppingListItem> items = null)
        {
            Id = id;
            Items = items ?? new List<ShoppingListItem>();
            CreationDate = DateTime.UtcNow;
            ModificationDate = DateTime.UtcNow;
            SetName(name);
        }

        public void ChangeName(string name)
        {
            SetName(name);
            ModificationDate = DateTime.UtcNow;
        }

        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty", nameof(name));
            }

            Name = name;
        }

        public int Count()
        {
            if (Items is null)
            {
                throw new Exception("Property not included.");
            }

            return Items.Count;
        }
    }
}
