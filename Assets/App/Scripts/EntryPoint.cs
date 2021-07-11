using Akeruna.Managers;
using Akeruna.StateBehaviour;
using UniFsm;
using UnityEngine;

namespace Akeruna
{
	public class EntryPoint : MonoBehaviour
	{
		private StateMachine<GameState> stateMachine;
		private PageManager.PageManager pageManager = new PageManager.PageManager();
		
		private void Start()
		{
			DontDestroyOnLoad(this);

			stateMachine = new StateMachine<GameState>(GameState.Title);

			stateMachine.RegisterStateBehaviour(GameState.Title, new TitleStateBehaviour());
			stateMachine.RegisterStateBehaviour(GameState.Prologue, new PrologueStateBehaviour());
			stateMachine.RegisterStateBehaviour(GameState.Main, new MainStateBehaviour());
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