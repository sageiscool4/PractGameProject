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
    [SerializeField] Animator anim;
    [SerializeField] int numTimesText = 0;

    // Start is called before the first frame update
    void Start()
    {
       textBox.SetActive(false);
       replyButton.SetActive(false);
        StartCoroutine(MomSpeakingBegin(4));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MomSpeakingBegin(int bSecs)
    {
        yield return new WaitForSeconds(bSecs);

        textBox.SetActive(true);
        replyButton.SetActive(true);

        numTimesText++;

    }

  

   public void replyButtonPressed()
    {
        switch (numTimesText)
        {
            case 1:
                anim.SetBool("isUpset", true);

                characterText.text = "There's a big corporation around here. \nThey're trying to make us go bankrupt!";
                replyBButton.text = "...";
                numTimesText++;
                break;

        }
    }
}
