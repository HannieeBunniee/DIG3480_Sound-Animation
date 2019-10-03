using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Controller : MonoBehaviour
{
    public AudioSource musicSource; //tell unity what game object use to play audio
    public AudioClip musicClipOne; // hold music clip
    public AudioClip musicClipTwo;

    Animator anim; //call animator called anim

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); // setting animator variable = animtor on this game object
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // press w key
        {
            musicSource.clip = musicClipOne; // set musicSource.clip to clipOne
            musicSource.Play();
            anim.SetInteger("State", 1); // make the animation to state one to walking
        }

        if (Input.GetKeyUp(KeyCode.W)) //release key w, music stop
        {
            musicSource.Stop();
            anim.SetInteger("State", 0); // back to idle
        }
        //================================================================

        if (Input.GetKeyDown(KeyCode.R)) // press r key
        {
            musicSource.clip = musicClipTwo; // set musicSource.clip to cliptwo
            musicSource.Play();
            anim.SetInteger("State", 2); // make the animation to state one to run
        }

        if (Input.GetKeyUp(KeyCode.R)) //release key w, music stop
        {
            musicSource.Stop();
            anim.SetInteger("State", 0); // back to idle
        }

        //=============================================================== 

        if (Input.GetKeyDown(KeyCode.L)) //loop music
        {
            musicSource.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            musicSource.loop = false;
        }

        //===============================================================
        if (Input.GetKey("escape"))
            Application.Quit();
    }
}

