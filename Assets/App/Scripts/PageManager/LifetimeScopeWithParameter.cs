using VContainer;
using VContainer.Unity;

namespace Akeruna.PageManager
{
	public class LifetimeScopeWithParameter<TParam> : LifetimeScope
	{
		public TParam Param;

		protected override void Configure(IContainerBuilder builder)
		{
			builder.RegisterInstance(Param);
		}
	}
}