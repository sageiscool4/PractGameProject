using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutsideWipe : MonoBehaviour
{
    public GameObject blackCanvas;
    public Animator blackAnim;
    public Animator outsideAnim;
    public GameObject outsideBG;

    // Start is called before the first frame update
    void Start()
    {
        blackAnim.SetTrigger("Start"); //start the wipe in animation

        StartCoroutine(PlayOutsideAnim());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator PlayOutsideAnim()
    {
        yield return new WaitForSeconds(1.50f); //wait for wipein to finish

        outsideAnim.SetTrigger("Wipe_Done"); //town animation to go to the store

        yield return new WaitForSeconds(1.667f);

        blackAnim.SetTrigger("WipeOut"); //fade to black

        yield return new WaitForSeconds(.95f);

        SceneManager.LoadScene("Store"); //load the store
    }
}
