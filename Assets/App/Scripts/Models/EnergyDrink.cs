using Akeruna.UseCases;

namespace Akeruna.Models
{
    /// <summary>
    /// エナドリ
    /// </summary>
    public class EnergyDrink : IItem
    {
    
        public IItem PickUp()
        {
            return this;
        }

        public void Store(IItem item)
        {
        
        }

        public void Use()
        {
            
        }

        public void Show()
        {
            
        }

        public bool CanUse()
        {
            return false;
        }
    }
}
