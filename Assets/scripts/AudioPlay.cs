using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip leftStep;
    public AudioClip rightStep;

    public void StepLeft(){
        audioSource.PlayOneShot(leftStep);
    }

    public void StepRight(){
        audioSource.PlayOneShot(rightStep);
    }

}
