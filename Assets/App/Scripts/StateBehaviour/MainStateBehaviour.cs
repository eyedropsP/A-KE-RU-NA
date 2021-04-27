using UniFsm;
using UnityEngine;

namespace Akeruna.StateBehaviour
{
	public sealed class MainStateBehaviour : StateBehaviour<GameState>
	{
		public override void OnEnabled()
		{
			Debug.Log("Game enabled");
		}

		public override void OnDisabled()
		{
			Debug.Log("Game disabled");
		}

		public override OptionalEnum<GameState> Tick()
		{
			if (Input.GetKeyDown(KeyCode.X))
			{
				return GameState.Config;
			}

			if (Input.GetKeyDown(KeyCode.Z))
			{
				return GameState.Epilogue;
			}

			return OptionalEnum<GameState>.None;
		}
	}
}