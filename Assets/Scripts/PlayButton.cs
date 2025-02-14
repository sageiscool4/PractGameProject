using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject button;
    public GameObject wipeImage;
    private Animation anim;
    private Animation wipeAni;
    public bool buttonPressed = false;

    private void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        wipeAni = wipeImage.GetComponent<Animation>();
       
    }

    private void Update()
    {
        
    }
    public void PlayButtonPressed()
    {
        buttonPressed = true;
        anim.Play("PlayAni"); // play button falls out, the other buttons will too
        wipeAni.Play("WipeIn"); // plays the wipe in screen to change scenes without a crazy change
    }
}
