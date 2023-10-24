using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSounds : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;
    public float timeBetweenSoundEffects;
    private float nextSoundEffectTime;
    public void Start()
    {
        source = GetComponent<AudioSource>();

    }
    public void Update()
    {
        if(Time.time > nextSoundEffectTime)
        {
            int randomNumber = Random.Range(0, clips.Length);
            source.clip = clips[randomNumber];
            source.Play();
            nextSoundEffectTime = Time.time + timeBetweenSoundEffects;
        }
     
    }
}
