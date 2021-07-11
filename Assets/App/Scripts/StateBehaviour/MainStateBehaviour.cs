using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UniFsm;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Akeruna.StateBehaviour
{
	public sealed class MainStateBehaviour : UniTaskStateBehaviour<GameState>
	{
		public override async UniTask<GameState> RunAsync(IUniTaskAsyncEnumerable<AsyncUnit> onTick, CancellationToken cancellationToken)
		{
			try
			{
				await SceneManager.LoadSceneAsync("Main");
				Debug.Log("MainState enabled");

				await onTick
					.Take(2)
					.ForEachAsync(_ => Debug.Log("MainState tick"), cancellationToken);

				while (true)
				{
					await onTick.FirstOrDefaultAsync(cancellationToken);
				}
			}
			finally
			{
				Debug.Log("MainState disabled");
			}
		}
	}
}