using System;

namespace SplitCost.Domain.Entities
{
    public class ShoppingListItem
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime ModificationDate { get; private set; }
        public ShoppingList ShoppingList { get; private set; }
        public Guid ShoppingListId { get; private set; }

        private ShoppingListItem()
        {
            // For EF
        }

        public ShoppingListItem(Guid id, string name, ShoppingList shoppingList)
        {
            Id = id;
            Name = name;
            ShoppingList = shoppingList;
            CreationDate = DateTime.UtcNow;
            ModificationDate = DateTime.UtcNow;
            ShoppingListId = shoppingList.Id;
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
    }
}