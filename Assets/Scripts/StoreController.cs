using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreController : MonoBehaviour
{
    [SerializeField] GameObject textBox;
    [SerializeField] TextMeshProUGUI characterText;
    [SerializeField] GameObject replyButton;
    [SerializeField] TextMeshProUGUI replyBButton;
    [SerializeField] int numTimesText = 1;
    [SerializeField] TextMeshProUGUI characterNameText;
    public Animator gregAni;
    public Animator blackAni;
    public GameObject gregAvi;
    // Start is called before the first frame update
    void Start()
    {
        gregAvi.SetActive(false);
        blackAni.SetTrigger("FadeIn"); //Fade the background
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReplyButtonPressed() //Conversation
    {
        switch (numTimesText)
        {
            case 1:
                characterText.text = "Greg!";
                replyBButton.text = "...";
                numTimesText++;
                break;

            case 2:
                gregAvi.SetActive(true);
                gregAni.SetTrigger("MoveGreg");
                characterText.text = "...";
                replyBButton.text = "...";
                numTimesText++;
                break;

            case 3:
                characterText.text = "Oh! Hey Greg! Have you met [REDACTED] yet?";
                replyBButton.text = "Hi";
                numTimesText++;
                break;

            case 4:
                characterNameText.text = "Greg";
                characterText.text = "Hey guys! No I've not met them yet. It's great to finally see you. \nI heard you are building something over there... do you need help?";
                replyBButton.text = "Yes, please!";
                numTimesText++;
                break;

            case 5:
                characterText.text = "Ok great! You need to send me some files first before I can dop anything.. \nI guess your mom can help you out with that";
                replyBButton.text = "...";
                numTimesText++;
                break;

            case 6:
                characterNameText.text = "Mom";
                characterText.text = "Yeah we can for sure do that! Thank you Greg, talk to you later...";
                replyBButton.text = "Bye!";
                numTimesText++;
                break;

            case 7:
                blackAni.SetTrigger("FadeOut");
                break;
        }
    }

}
