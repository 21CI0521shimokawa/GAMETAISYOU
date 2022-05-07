using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSE : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource audioSourceSoundStretch;

    [SerializeField] AudioClip soundJump;
    [SerializeField] AudioClip soundTearoff;
    [SerializeField] AudioClip soundMove;
    [SerializeField] AudioClip soundLanding;

    bool playsoundJump;
    bool playsoundTearoff;
    bool playsoundMove;
    bool playsoundLanding;

    bool PlaysoundStretch; 
    bool isPlaysoundStretch;    //今再生しているかどうか

    // Start is called before the first frame update
    void Start()
    {
        flagReset();

        PlaysoundStretch = false;
        isPlaysoundStretch = false;
    }

    // Update is called once per frame
    void Update()
    {
        flagReset();

        if(PlaysoundStretch)
        {
            if (!isPlaysoundStretch)
            {
                isPlaysoundStretch = true;
                audioSourceSoundStretch.Play();
            }
        }
        else
        {
            if (isPlaysoundStretch)
            {
                isPlaysoundStretch = false;
                audioSourceSoundStretch.Stop();
            }          
        }
    }

    void flagReset()
    {
        playsoundJump = false;
        playsoundTearoff = false;
        playsoundMove = false;
        playsoundLanding = false;
    }

    public void _PlayJumpSE()
    {
        if (!playsoundJump)
        {
            playsoundJump = true;

            if (soundJump)
            {
                audioSource.PlayOneShot(soundJump);
            }
            Debug.Log("飛ぶ音");
        }
    }

    public void _PlayTearoffSE()
    {
        if (!playsoundTearoff)
        {
            playsoundTearoff = true;

            if (soundTearoff)
            {
                audioSource.PlayOneShot(soundTearoff);
            }
            Debug.Log("ちぎれる音");
        }
    }

    public void _PlayMoveSE()
    {
        if (!playsoundMove)
        {
            playsoundMove = true;

            if (soundMove)
            {
                audioSource.PlayOneShot(soundMove);
            }
            Debug.Log("歩く音");
        }
    }

    public void _PlayLandingSE()
    {
        if (!playsoundLanding)
        {
            playsoundLanding = true;

            if (soundLanding)
            {
                audioSource.PlayOneShot(soundLanding);
            }
            Debug.Log("着地音");
        }
    }

    public void _PlayStretchSE(float pitch_)
    {
        audioSourceSoundStretch.pitch = pitch_;

        PlaysoundStretch = true;

        //Debug.Log("引き延ばす " + pitch_);
    }

    public void _StopStretchSE()
    {
        PlaysoundStretch = false;
    }
}
