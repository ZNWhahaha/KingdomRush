using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {


	public Transform SpwanerPoint;
	float SpwanerInterval = 2f;
	string monsterPath = "Monster/Monster1/Prefab/Monster1";

	// Use this for initialization
	void Start (){
		InvokeRepeating ("SpwanerMonster", 0, SpwanerInterval);
		//在0，内开始，并按照制定的时间间隔进行执行
	}

	void SpwanMonster()
	{
		GameObject monster = (GameObject)GameObject.Instantiate (Resources.Load(monsterPath),SpwanerPoint.position,Quaternion.identity);
		monster.transform.parent = transform;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
