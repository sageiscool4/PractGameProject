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
    [SerializeField] Button replyBButton;
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
       textBox.SetActive(false);
       replyButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(MomSpeaking(4));
    }

    IEnumerator MomSpeaking(int bSecs)
    {
        yield return new WaitForSeconds(bSecs);

        textBox.SetActive(true);
        replyButton.SetActive(true);
        
        yield return new WaitForSeconds(5);

        anim.SetBool("isUpset", true);

        characterText.text = "There's a big corporation around here. \nThey're trying to make us go bankrupt!";
    }
}
