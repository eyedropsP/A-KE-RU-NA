namespace Akeruna.UseCases
{
	public interface IInventory
	{
		void Push(IItem item);
		void Pop(IItem item);
		void Pop(int index);
	}
}