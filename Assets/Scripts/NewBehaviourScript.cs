using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.D))
        {
          musicSource.clip = musicClipOne;
          musicSource.Play();

        }

    if (Input.GetKeyUp(KeyCode.D))
        {
          musicSource.Stop();

        }
    if (Input.GetKeyDown("space"))
        {
          musicSource.clip = musicClipTwo;
          musicSource.Play();
        }

    if (Input.GetKeyUp("space"))
        {
          musicSource.Stop();

        }
    }
}
