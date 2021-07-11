using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UniFsm;
using UnityEngine;

namespace Akeruna.StateBehaviour
{
	public sealed class TitleStateBehaviour : UniTaskStateBehaviour<GameState>
	{
		public override async UniTask<GameState> RunAsync(IUniTaskAsyncEnumerable<AsyncUnit> onTick,
			CancellationToken cancellationToken)
		{
			try
			{
				Debug.Log("Title enabled");
				await onTick
					.TakeWhile(_ => !Input.GetKeyDown(KeyCode.Z))
					.ForEachAsync(_ => Debug.Log("StateA Tick"), cancellationToken);
				return GameState.Prologue;
			}
			finally
			{
				Debug.Log("Title disabled");
			}
		}
	}
}