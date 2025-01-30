using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject button;
    private Animation anim;
    public bool buttonPressed = false;

    private void Start()
    {
        anim = gameObject.GetComponent<Animation>();
       
    }
    public void PlayButtonPressed()
    {
        buttonPressed = true;
        anim.Play("PlayAni");
    }
}
