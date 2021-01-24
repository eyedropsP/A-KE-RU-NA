namespace Akeruna.UseCases
{
	/// <summary>
	/// アイテムインターフェース
	/// </summary>
	public interface IItem
	{
		/// <summary>
		/// 拾う
		/// </summary>
		/// <returns></returns>
		IItem PickUp();
	
		/// <summary>
		/// 収納する
		/// </summary>
		/// <param name="item"></param>
		void Store(IItem item);
	
		/// <summary>
		/// 使う
		/// </summary>
		void Use();
	
		/// <summary>
		/// 表示する
		/// </summary>
		void Show();

		/// <summary>
		/// 使用可能判定
		/// </summary>
		/// <returns></returns>
		bool CanUse();
	}
}