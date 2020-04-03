using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierActivation : MonoBehaviour {

    public GameObject obj;   //here the object you want to disable
    public GameObject objUI;
    public OVRInput.Button menu = OVRInput.Button.PrimaryIndexTrigger;
    private bool activity;

    void Start()
    {
        activity = false;
    }

    void Update()
    {
        obj.SetActive(activity);   //here disables the obj

        if (OVRInput.GetDown(menu))
        {
            if (activity == true)
            {
                activity = false;
            }
            else
            {
                activity = true;
            }
        }  
    }
}