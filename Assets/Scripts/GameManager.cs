using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject WipeImage;
    private Animation WipeAni;

     void Start()
    {
        WipeAni = WipeImage.GetComponent<Animation>();

        StartCoroutine(GetRidOfWipe(3));
    }

    IEnumerator GetRidOfWipe(int secs)
    {
        WipeAni.Play("WipeOut");

        yield return new WaitForSeconds(secs);

        Destroy(WipeImage);
    }

}
