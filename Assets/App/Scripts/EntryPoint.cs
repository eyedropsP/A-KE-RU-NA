using Akeruna.StateBehaviour;
using UniFsm;
using UnityEngine;

namespace Akeruna
{
	public class EntryPoint : MonoBehaviour
	{
		private StateMachine<GameState> stateMachine;

		private void Start()
		{
			stateMachine = new StateMachine<GameState>(GameState.Title);
			
			stateMachine.RegisterStateBehaviour(GameState.Title, new TitleStateBehaviour());
			stateMachine.RegisterStateBehaviour(GameState.Prologue, new PrologueStateBehaviour());
			stateMachine.RegisterStateBehaviour(GameState.Game, new MainStateBehaviour());
			stateMachine.RegisterStateBehaviour(GameState.Epilogue, new EpilogueStateBehaviour());
			stateMachine.RegisterStateBehaviour(GameState.Config, new ConfigStateBehaviour());
		}

		private void Update()
		{
			stateMachine.Tick();
		}

		private void OnDestroy()
		{
			stateMachine.Dispose();
		}
	}
}