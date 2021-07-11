using UniFsm;
using UnityEngine;

namespace Akeruna.StateBehaviour
{
	public class ConfigStateBehaviour : StateBehaviour<GameState>
	{
		public override void OnEnabled()
		{
			Debug.Log("Config enabled");
		}

		public override void OnDisabled()
		{
			Debug.Log("Config disabled");
		}

		public override OptionalEnum<GameState> Tick()
		{
			if (Input.GetKeyDown(KeyCode.X))
			{
				return GameState.Main;
			}

			return OptionalEnum<GameState>.None;
		}
	}
}