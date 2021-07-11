using Cysharp.Threading.Tasks;

namespace Akeruna.Pages
{
	public abstract class BasePage
	{
		/// <summary>
		/// ページ初期化
		/// </summary>
		/// <returns></returns>
		public abstract UniTask Initialize();

		/// <summary>
		/// 一時停止
		/// </summary>
		/// <returns></returns>
		public abstract UniTask Suspend();

		/// <summary>
		/// 再開
		/// </summary>
		/// <returns></returns>
		public abstract UniTask Resume();

		/// <summary>
		/// 破棄
		/// </summary>
		/// <returns></returns>
		public abstract UniTask Discard();
	}

	public abstract class BasePage<TParam> : BasePage
	{
		protected TParam Parameter { get; }
	}
}