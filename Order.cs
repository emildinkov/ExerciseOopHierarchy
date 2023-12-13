using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items = new(); // Правим списък да можем да съхраняваме поръчки.

        public IReadOnlyCollection<MenuItem> Items => this._items.AsReadOnly(); // По този начин виждаме всички елементи от поръчката но не можем нищо друго да правим с тях.

        public void AddItem(MenuItem item)      // Метод за добавяне на поръчки.
        {
            this._items.Add(item);
        }

        public decimal GetTotal()   // Правим метод който сумира всички поръчки в списъка.
        {
            return this._items.Select(x => x.Price).Sum();
        }
    }
}
