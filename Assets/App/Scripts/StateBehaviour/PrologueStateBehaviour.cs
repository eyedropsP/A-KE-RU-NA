using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.Linq;
using UniFsm;
using UnityEngine;

namespace Akeruna.StateBehaviour
{
	public sealed class PrologueStateBehaviour : UniTaskStateBehaviour<GameState>
	{
		public override async UniTask<GameState> RunAsync(IUniTaskAsyncEnumerable<AsyncUnit> onTick,
			CancellationToken cancellationToken)
		{
			try
			{
				Debug.Log("Prologue enabled");
				await onTick.TakeWhile(_ => !Input.GetKeyDown(KeyCode.Z))
					.ForEachAsync(_ => Debug.Log("PrologueState Tick"), cancellationToken);
				return GameState.Game;
			}
			finally
			{
				Debug.Log("Prologue disabled");
			}
		}
	}
}