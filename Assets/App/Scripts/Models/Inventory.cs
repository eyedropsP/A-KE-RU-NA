using System.Collections.Generic;
using Akeruna.UseCases;

namespace Akeruna.Models
{
	public class Inventory : IInventory
	{
		private List<IItem> itemList = new List<IItem>();
		private int selectedIndex = default;
		private int itemsCount = default;

		public void Push(IItem item)
		{
			itemList.Add(item);
		}

		public void Pop(IItem item)
		{
			itemList.Remove(item);
		}

		public void Pop(int index)
		{
			if (index > itemList.Count)
			{
				return;
			}
			
			itemList.RemoveAt(index);
		}
	}
}