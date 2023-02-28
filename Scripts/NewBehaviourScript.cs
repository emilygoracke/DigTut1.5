using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;

    Animator anim;

    //Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.D))
        {
          musicSource.clip = musicClipOne;
          musicSource.Play();
          anim.SetInteger("State", 1);
        }

    if (Input.GetKeyUp(KeyCode.D))
        {
          musicSource.Stop();
          anim.SetInteger("State", 0);
        }
   
    if (Input.GetKeyDown("space"))
        {
          musicSource.clip = musicClipTwo;
          musicSource.Play();
          anim.SetInteger("State", 2);
        }

    if (Input.GetKeyUp("space"))
        {
          musicSource.Stop();
          anim.SetInteger("State", 0);
        }
   
    if (Input.GetKeyDown(KeyCode.L))
        {
          musicSource.loop = true;
        }
     
     if (Input.GetKeyDown(KeyCode.L))
        {
          musicSource.loop = false;
        }
    }
}
