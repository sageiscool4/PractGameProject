using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject GameTitle;
    public GameObject PlayButton;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (PlayButton.GetComponent<PlayButton>().buttonPressed == true)
        {
            StartCoroutine(ChangeScenes(3));


        }
    }

    IEnumerator ChangeScenes(int secs)
    {
        yield return new WaitForSeconds(secs);

        Debug.Log("change");

        PlayButton.GetComponent<PlayButton>().buttonPressed = false;

        SceneManager.LoadScene("Game");
    }
}
