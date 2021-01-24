using Akeruna.UseCases;

namespace Akeruna.Models
{
	/// <summary>
	/// 精神安定剤
	/// </summary>
	public class MentalStabilizer : IItem
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