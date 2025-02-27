using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject textBox;
    [SerializeField] TextMeshProUGUI characterText;
    [SerializeField] GameObject replyButton;
    [SerializeField] TextMeshProUGUI replyBButton;
    [SerializeField] int numTimesText = 0;
    [SerializeField] TextMeshProUGUI characterNameText;

    // Start is called before the first frame update
    void Start()
    {
       textBox.SetActive(false);
       replyButton.SetActive(false);
        StartCoroutine(MomSpeakingBegin(4));
       
    }

  
    IEnumerator MomSpeakingBegin(int bSecs)
    {
        yield return new WaitForSeconds(bSecs); //wait for wipe out screen to pass

        textBox.SetActive(true);
        replyButton.SetActive(true);

        numTimesText++; // how many times mom has talked

    }

  

   public void replyButtonPressed()
    {
        switch (numTimesText) //change text based on how many times she's talked
        {
            case 1: 
                
                characterText.text = "There's a big corporation around here. \nThey're trying to make us go bankrupt!";
                replyBButton.text = "...";
                numTimesText++;
                break;

            case 2:
                characterText.text = "You probably think I'm joking... \nBut I'm not! I swear";
                replyBButton.text = "Ok, I believe you.";
                numTimesText++; 
                break;

            case 3:

                characterText.text = "Good! Thank you! Everyone is so glad you're here. \nOh I'm sorry I forgot to introduce myself..";
                replyBButton.text = "...";
                numTimesText++;
                break;

            case 4:
                characterText.text = "People around here call me Mom! I'm sure we'll be close in no time!";
                characterNameText.text = "Mom";
                replyBButton.text = "Ok!";
                numTimesText++;
                break;

            case 5:

                characterText.text = "Anyway, I think Greg had something for the new comer... which is you.";
                replyBButton.text = "Who's Greg?";
                numTimesText++;
                break;

            case 6:

                characterText.text = "Greg is the local craftsman! He usually only makes furniture, but I'm sure he can make machines! \nHis place isn't very hard to find in the town, don't worry.";
                replyBButton.text = "Ok.";
                numTimesText++;
                break;

            case 7:

                characterText.text = "Ok let's go!";
                replyBButton.text = "*Go outside*";
                numTimesText++;
                break;

            default:

                break;


        }
    }
}
