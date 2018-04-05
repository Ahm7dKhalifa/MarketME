using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DepartmentPoint : MonoBehaviour {

    public Animator scaleAnimation;
    public string animationName;
    public string NextSceneName;
    // Use this for initialization
    void Start()
    {
        scaleAnimation.GetComponents<Animator>();
    }
    public void StartScaleGoHere()
    {
        scaleAnimation.Play(animationName);
       
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
