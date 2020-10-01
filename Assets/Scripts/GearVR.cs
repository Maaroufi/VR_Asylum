using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearVR : MonoBehaviour {

    public Renderer rend;

    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	void Update () {
		
	}
}
