using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject GameTitle;
    public GameObject PlayButton;


    // Update is called once per frame
    void Update()
    {


        if (PlayButton.GetComponent<PlayButton>().buttonPressed == true) //checks to see if play button was pressed
        {
            StartCoroutine(ChangeScenes(3)); //calls the scene change with 3 seconds 


        }
    }

    IEnumerator ChangeScenes(int secs)
    {
        PlayButton.GetComponent<PlayButton>().buttonPressed = false; //makes sure the coroutine doesnt get called over and over

        yield return new WaitForSeconds(secs); //wait for x amount of secs

        // Debug.Log("change"); *was for debugging purposes


        SceneManager.LoadScene("Game"); //loads the game
    }
}
