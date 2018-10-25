using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// press R to reload scene
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("mainLabScene");

			Pathmaker.globalTileCount = 0;
		}
		
	}
}
