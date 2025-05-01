using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject button;
    public GameObject wipeImage;
    private Animator anim;
    private Animation wipeAni;
    public bool buttonPressed;
    private bool ifButtonP;
    public int timePlayed = 0;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        wipeAni = wipeImage.GetComponent<Animation>();
       
    }

    public void FixedUpdate()
    {
        buttonPressed = ifButtonP; //also tried something else
    }
    public void PlayButtonPressed()
    {
        ifButtonP = true;
        anim.SetTrigger("Button_Pressed1");
        wipeAni.Play("WipeIn"); // plays the wipe in screen to change scenes without a crazy change
    }
}
