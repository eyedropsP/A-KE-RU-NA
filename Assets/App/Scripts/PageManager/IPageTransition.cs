using Akeruna.Pages;
using Cysharp.Threading.Tasks;

namespace Akeruna.PageManager
{
	public interface IPageTransition
	{
		UniTask<BasePage> LoadPageAsync();
		BasePage LoadPage();
	}
}