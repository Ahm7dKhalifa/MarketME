using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHerePoint : MonoBehaviour {

    public Animator scaleAnimation;
    public string NextSceneName;
	// Use this for initialization
	void Start () {
        scaleAnimation.GetComponents<Animator>();
    }	
    public void StartScaleGoHere()
    {
        scaleAnimation.Play("GoHereAnimation");
    }
    public void StopScaleGoHere()
    {
        scaleAnimation.Play("none");
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene(NextSceneName);
    }

}
