using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EffectManager : MonoBehaviour
{
    public AudioClip click;

    public AudioClip Fail;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayClick()
    {
        GetComponent<AudioSource>().PlayOneShot(click);
    }
    
    public void PlayFail()
    {
        GetComponent<AudioSource>().PlayOneShot(Fail);
    }
}