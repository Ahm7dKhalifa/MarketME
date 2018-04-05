using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleChild : MonoBehaviour {

    public GameObject parent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //DisableAllChild
    public void DisableAllChild()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            var child = parent.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
    //EnableAllChild
    public void EnableAllChild()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            var child = parent.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(true);
        }
    }
}
