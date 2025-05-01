using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public GameObject PlayButton;
    public PlayButton pB;
    public Animator anim;
    public int timePlayed = 0;
    public bool isButtonPressed;

    

    // Start is called before the first frame update
    void Start()
    {
       anim = gameObject.GetComponent<Animator>(); 
        pB = PlayButton.GetComponent<PlayButton>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isButtonPressed = pB.buttonPressed; //had to play with this a bit bc animation wouldn't play
       if (isButtonPressed == true && timePlayed == 0)
        {
            
            anim.SetTrigger("Button_Pressed3");
            timePlayed++;
        }

        if (gameObject.transform.position.y < -530.0f)
        {
            gameObject.SetActive(false); //make it unactive when it's off the screen
        }
    }
}
