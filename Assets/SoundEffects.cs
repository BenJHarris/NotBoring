using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource goldSound;

    public void PlayGoldSound()
    {
        goldSound.Play();
    }
}
