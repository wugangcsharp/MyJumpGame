﻿using UnityEngine;
using System.Collections;

public class PlayerAnimator : MonoBehaviour {
	Vector3 [] paths;

	void Awake(){
		paths = iTweenPath.GetPath ("path1");
	}
	void Start () {
//		Hashtable args = new Hashtable();
//		//设置路径的点
//		args.Add("path",paths);
//		//设置类型为线性，线性效果会好一些。
//		args.Add("easeType", iTween.EaseType.linear);
//		//设置寻路的速度
//		args.Add("speed",0.1f);
//		//是否先从原始位置走到路径中第一个点的位置
//		args.Add("movetopath",true);
//		//是否让模型始终面朝当面目标的方向，拐弯的地方会自动旋转模型
//		//如果你发现你的模型在寻路的时候始终都是一个方向那么一定要打开这个
//		args.Add("orienttopath",true);
//
//		args.Add ("loop", iTween.LoopType.pingPong);
//
//		//让模型开始寻路	
//		iTween.MoveTo(gameObject,args);


		Hashtable table = new Hashtable ();
		table.Add ("path", paths);
		//table.Add ("movetopath", true);
		//table.Add ("orienttopath", true);
		table.Add("speed",1f);
		table.Add ("easeType", iTween.EaseType.linear);
		table.Add ("looptype", iTween.LoopType.loop);
		iTween.MoveTo (this.gameObject, table);


	}
	
	void OnDrawGizmos()
	{
		//在scene视图中绘制出路径与线
		iTween.DrawLine(paths,Color.yellow);
		
		iTween.DrawPath(paths,Color.red);
		
	}
    
}
