using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingDots : MonoBehaviour
{
    public GameObject dot1;
    public GameObject dot2;
    public GameObject dot3;
    public GameObject dotsEmpty; //all the dots

    private Animation anim1; //dotOne
    private Animation anim2; //dotTwo
    private Animation anim3; //dotThree
    private Animation anim;



    private bool fadeFirstTime = true;


    // Start is called before the first frame update
    void Start()
    {
        // dotsEmpty.SetActive(false);
        anim1 = dot1.GetComponent<Animation>();
        anim2 = dot2.GetComponent<Animation>();
        anim3 = dot3.GetComponent<Animation>();

        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {


        if (dotsEmpty.activeSelf == true)
        {
            StartFadeIn();

            for (int i = 0; i < 4; i++)
            {
                anim1.Play("dotOneAni");
                anim2.Play("dotTwoAni");
                anim3.Play("dotThreeAni");
            }

            StartFadeOut();

            do
            {
                continue;

            } while (dot1.GetComponent<Image>().color.a != 0);

            dotsEmpty.SetActive(false);
        }

        void StartFadeIn()
        {
            if (fadeFirstTime == true) //checks if fade has been played
            {
                anim.Play("DotsAni");
                fadeFirstTime = false;
            }
        }

        void StartFadeOut()
        {
            if (dotsEmpty.activeSelf == true)
            {
                anim.Play("DotsOutAni");
            }
        }
    }
}
