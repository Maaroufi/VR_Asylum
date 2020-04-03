using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VRStartButton : MonoBehaviour {

    public string LevelToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void OnClick()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
