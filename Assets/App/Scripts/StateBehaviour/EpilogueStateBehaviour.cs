using UniFsm;
using UnityEngine;

namespace Akeruna.StateBehaviour
{
	public class EpilogueStateBehaviour : StateBehaviour<GameState>
	{
		public override void OnEnabled()
		{
			Debug.Log("Epilogue enabled");
		}

		public override void OnDisabled()
		{
			Debug.Log("Epilogue disabled");
		}

		public override OptionalEnum<GameState> Tick()
		{
			if (Input.GetKeyDown(KeyCode.Z))
			{
				return GameState.Title;
			}

			return OptionalEnum<GameState>.None;
		}
	}
}