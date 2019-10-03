using CoffeeShopAssignmentUI.Model;
using CoffeeShopAssignmentUI.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopAssignmentUI.BLL
{
    
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();

        public bool Add(Item item)
        {
            return _itemRepository.Add(item);

        }
        public bool IsNameExists(string name)
        {
            return _itemRepository.IsNameExists(name);
        }
        public DataTable Display()
        {
            return _itemRepository.Display();
        }
        public bool Delete(int ItemId)
        {
            return _itemRepository.Delete(ItemId);
        }
        public bool Update(string Name, double Price, int ItemId)
        {
            return _itemRepository.Update(Name, Price, ItemId);
        }
        public DataTable Search(string name)
        {
            return _itemRepository.Search(name);
        }
        public DataTable ItemCombobox()
        {
            return _itemRepository.ItemCombobox();
        }

    }
}
