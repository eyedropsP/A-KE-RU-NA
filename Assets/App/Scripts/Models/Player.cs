using System.Threading;
using Akeruna.UseCases;
using UnityEngine;

namespace Akeruna.Models
{
	public class Player : MonoBehaviour
	{
		private IInventory inventory;
		private IMainGameState State;
		private Sanity Sanity;

		public void Initializer(IInventory inventory)
		{
			this.inventory = inventory;
		}
	}
}