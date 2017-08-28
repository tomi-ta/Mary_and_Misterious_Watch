using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //スクリプト内でシーンの移動や遷移を行う際に必要なコード

public class TitleScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetMouseButtonDown(0))  //マウスが左クリックされるとtrue 
        {
            SceneManager.LoadScene("Map_Scene");
        }
	}
}
