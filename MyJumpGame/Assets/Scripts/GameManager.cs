using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
		 
		private static GameObject panel;
		private static GameObject panel1;

		void Awake ()
		{
			//panel = GameObject.Find ("UI Root (2D)/Camera/Anchor/Panel");
			panel = GameObject.Find ("Panel");
			panel1 = GameObject.Find ("UI Root (2D)/Camera/Anchor/Panel1");
			ChangeGameState (EGameState.HELLO);
		}
 

		public static void ChangeGameState (EGameState currentGameState)
		{

				if (currentGameState == null) {
						print ("currentGameState又是null");
				} else {
						switch (currentGameState) {
						case EGameState.HELLO:
								NGUITools.SetActive (panel, true);
								NGUITools.SetActive (panel1, false);
								break;
						case EGameState.GAMESTART:
								NGUITools.SetActive (panel, false);
								NGUITools.SetActive (panel1, true);
								GameObject obj = GameObject.Find("UI Root (2D)/Camera/Anchor/Panel1/btnpause");
								UIEventListener.Get(obj).onClick = Pause;

								break;
						case EGameState.GAMEPAUSE:
							
								break;
						case EGameState.GAMEOVER:
								break;
						case EGameState.HELP:
								break;
						case EGameState.HIGHSCORE:
								break;
						case EGameState.ABOUT:
							break;
						default:
								break;
						}


			 
			 






				}
		}
	static void Pause(GameObject obj){
		if(Time.timeScale==1){
			Time.timeScale=0;
		}
		else{
			Time.timeScale=1;
		}
	}
}

public enum EGameState
{		
		/// <summary>
		/// 开始画面
		/// </summary>
		HELLO,
		/// <summary>
		/// 游戏开始
		/// </summary>
		GAMESTART,
		/// <summary>
		/// 游戏暂停
		/// </summary>
		GAMEPAUSE,
		/// <summary>
		/// 游戏失败
		/// </summary>
		GAMEOVER,
		/// <summary>
		/// 帮助
		/// </summary>
		HELP,
		/// <summary>
		/// 高分榜
		/// </summary>
		HIGHSCORE,
		/// <summary>
		/// 关于
		/// </summary>
		ABOUT
}