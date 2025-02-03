using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Buttons;
    public GameObject GameTitle;

    private int runCount = 0;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waiter(int secs)
    {
        yield return new WaitForSeconds(secs);
    }


}
