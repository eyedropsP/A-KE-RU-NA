using System;
using Akeruna.Pages;
using Cysharp.Threading.Tasks;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Akeruna.PageManager
{
	public class BasePageTransition<TPage> : IPageTransition where TPage : BasePage
	{
		private BasePage page;

		public virtual async UniTask<BasePage> LoadPageAsync()
		{
			if (!(Attribute.GetCustomAttribute(typeof(TPage), typeof(PageAssetAttribute)) is PageAssetAttribute
				pageNameAttr)) return default;

			var pageInstance = await LoadPrefabAsync(pageNameAttr.PrefabName);
			var pageLifetimeScope = pageInstance.GetComponent<LifetimeScope>();
			InitializePageParameter(pageLifetimeScope);
			pageLifetimeScope.Build();
			page = pageLifetimeScope.Container.Resolve<TPage>();

			return page;
		}

		public virtual BasePage LoadPage()
		{
			if (!(Attribute.GetCustomAttribute(typeof(TPage), typeof(PageAssetAttribute)) is PageAssetAttribute
				pageNameAttr))
				return default;

			var pageInstance = LoadPrefab(pageNameAttr.PrefabName);
			var pageLifetimeScope = pageInstance.GetComponent<LifetimeScope>();
			InitializePageParameter(pageLifetimeScope);
			pageLifetimeScope.Build();
			page = pageLifetimeScope.Container.Resolve<TPage>();
			return page;
		}

		protected virtual void InitializePageParameter(LifetimeScope container)
		{
		}

		protected GameObject LoadPrefab(string pageAssetName)
		{
			GameObject pageInstance = default;
			pageInstance = Resources.Load(pageAssetName) as GameObject;
			return pageInstance;
		}

		protected async UniTask<GameObject> LoadPrefabAsync(string pageAssetName)
		{
			GameObject pageInstance = default;
#if UNITY_EDITOR
			pageInstance = await Resources.LoadAsync(pageAssetName) as GameObject;
#endif
			return pageInstance;
		}
	}

	public class BasePageTransition<TPage, TParam> : BasePageTransition<TPage> where TPage : BasePage<TParam>
	{
		public TParam Parameter { get; set; }

		protected override void InitializePageParameter(LifetimeScope container)
		{
		}
	}
}