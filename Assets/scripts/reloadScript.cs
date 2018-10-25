using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// put this on empty game object
// will reload scene if you press R
public class reloadScript : MonoBehaviour {

	void Update () {
		

		if (Input.GetKeyDown(KeyCode.R))
		{
			Debug.Log("R to restart");
			SceneManager.LoadScene("mainLabScene");

			Pathmaker.globalTileCount = 0;
		}
	}
}
