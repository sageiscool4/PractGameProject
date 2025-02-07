using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : MonoBehaviour
{
    public GameObject PlayButton;
    private Animation anim;

    

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayButton.GetComponent<PlayButton>().buttonPressed == true)
        {
            anim.Play("OptionsAni");
        }

        if (gameObject.transform.position.y < -530.0f)
        {
            gameObject.SetActive(false);
        }
    }
}
