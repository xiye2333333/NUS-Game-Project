using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    
    public AudioSource BGMSource;
    
    public AudioSource audioSource;

    public float AudioSound = 1f;
    
    public AudioClip Wood;

    public AudioClip HeroHit;

    public AudioClip MonsterHit;

    public AudioClip Buy;

    public AudioClip Click;
    
    public AudioClip Place;

    public AudioClip Recover;

    public AudioClip Vectory;

    public AudioClip Upgrade;

    public AudioClip BossHit;
    
    public Slider VolumeSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        BGMSource.volume = VolumeSlider.value;
        audioSource.volume = VolumeSlider.value;
    }
    
    public void PlayWood()
    {
        audioSource.PlayOneShot(Wood, AudioSound);
    }
    
    public void PlayHeroHit()
    {
        audioSource.PlayOneShot(HeroHit, AudioSound);
    }
    
    public void PlayMonsterHit()
    {
        audioSource.PlayOneShot(MonsterHit, AudioSound);
    }
    
    public void PlayBuy()
    {
        audioSource.PlayOneShot(Buy, AudioSound);
    }
    
    public void PlayClick()
    {
        audioSource.PlayOneShot(Click, AudioSound);
    }
    
    public void PlayPlace()
    {
        audioSource.PlayOneShot(Place, AudioSound);
    }
    
    public void PlayRecover()
    {
        audioSource.PlayOneShot(Recover, AudioSound);
    }
    
    public void PlayVectory()
    {
        audioSource.PlayOneShot(Vectory, AudioSound);
    }
    
    public void PlayUpgrade()
    {
        audioSource.PlayOneShot(Upgrade, AudioSound);
    }
    
    public void Play(AudioClip clip)
    {
        audioSource.PlayOneShot(clip, AudioSound);
    }
    
    public void PlayBossHit()
    {
        audioSource.PlayOneShot(BossHit, AudioSound);
    }
    
}