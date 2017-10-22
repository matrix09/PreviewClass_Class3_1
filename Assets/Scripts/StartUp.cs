using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//加载我的主角
        Object obj = Resources.Load("Vegibi/Prefab/Vegebi2");
        Instantiate(obj);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
