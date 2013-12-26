using UnityEngine;
using System.Collections;

public class EventList : MonoBehaviour {

    void Awake()
    {
        GameObject obj = GameObject.Find("UI Root (2D)/Camera/Anchor/Panel/btnscore");
        UIEventListener.Get(obj).onClick = HighScore;

        obj = GameObject.Find("UI Root (2D)/Camera/Anchor/Panel/btnhelp");
        UIEventListener.Get(obj).onClick = Helper;

        obj = GameObject.Find("UI Root (2D)/Camera/Anchor/Panel/btnstart");
        UIEventListener.Get(obj).onClick = StartGame;

		obj = GameObject.Find("UI Root (2D)/Camera/Anchor/Panel/btnabout");
		UIEventListener.Get(obj).onClick = Abcout;
    }

    void StartGame(GameObject obj)
    {
        Debug.Log("游戏开始");
		GameManager.ChangeGameState(EGameState.GAMESTART);
        
    }

    void Helper(GameObject obj)
    {
        Debug.Log("游戏帮助"); 
		GameManager.ChangeGameState(EGameState.HELP);

    }

    void HighScore(GameObject obj)
    {
        Debug.Log("高分榜 事件绑定"); 
		GameManager.ChangeGameState(EGameState.HIGHSCORE);
        
    }
	void Abcout(GameObject obj){
		Debug.Log("关于"); 
		GameManager.ChangeGameState(EGameState.ABOUT);
	}

}
