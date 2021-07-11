using System.Collections.Generic;
using System.Linq;
using Akeruna.Pages;
using Cysharp.Threading.Tasks;

namespace Akeruna.PageManager
{
	public class PageManager
	{
		private List<BasePage> pages = new List<BasePage>();

		public async UniTask PushAsync(IPageTransition transition)
		{
			var nextPage = await transition.LoadPageAsync();
			await nextPage.Initialize();
			pages.Add(nextPage);
		}

		public async UniTask ReplaceAsync(IPageTransition transition)
		{
			var currentPage = pages.Last();
			currentPage.Resume();
			currentPage.Discard();
			pages.Remove(currentPage);
			var nextPage = await transition.LoadPageAsync();
			await nextPage.Initialize();
			pages.Add(nextPage);
		}

		public async UniTask ReplaceAllAsync(IPageTransition transition)
		{
			foreach (var currentPage in pages)
			{
				currentPage.Resume();
				currentPage.Discard();
			}
			pages.Clear();
			var nextPage = await transition.LoadPageAsync();
			await nextPage.Initialize();
			pages.Add(nextPage);
		}
		
		public void Push(IPageTransition transition)
		{
			var nextPage = transition.LoadPage();
			nextPage.Initialize();
			pages.Add(nextPage);
		}

		public void Pop()
		{
			var currentPage = pages.Last();
			currentPage.Suspend();
			currentPage.Discard();
			pages.Remove(currentPage);
			pages.Last().Resume();
		}

		public void Replace(IPageTransition transition)
		{
			var currentPage = pages.Last();
			currentPage.Resume();
			currentPage.Discard();
			pages.Remove(currentPage);
			var nextPage = transition.LoadPage();
			nextPage.Initialize();
			pages.Add(nextPage);
		}

		public void ReplaceAll(IPageTransition transition)
		{
			foreach (var currentPage in pages)
			{
				currentPage.Resume();
				currentPage.Discard();
			}
			pages.Clear();
			var nextPage = transition.LoadPage();
			nextPage.Initialize();
			pages.Add(nextPage);
		}
	}
}