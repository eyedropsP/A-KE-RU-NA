using System;

namespace Akeruna.PageManager
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public class PageAssetAttribute : Attribute
	{
		public string PrefabName { get; }

		public PageAssetAttribute(string prefabName)
		{
			PrefabName = $"{prefabName}.prefab";
		}
	}
}