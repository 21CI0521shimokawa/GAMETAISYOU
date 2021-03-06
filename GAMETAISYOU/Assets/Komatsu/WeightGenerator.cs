using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightGenerator : MonoBehaviour
{
    public GameObject weightPrefab;
    public float spawnInterval;
    public Vector3 spawnPosition;
    public bool spawnFlag;
    float timer;
    [SerializeField] AudioSource WeightGeneratorAudioSource;
    [SerializeField] AudioClip SE;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
        this.transform.position = spawnPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnFlag)
        {
            timer += Time.deltaTime;
            if (timer >= spawnInterval)
            {
               PlaySE(SE);
                timer = 0.0f;
                GameObject weight = Instantiate(weightPrefab) as GameObject;
                weight.transform.position = this.transform.position;
            }
        }
    }
    public void PlaySE(AudioClip audio)
    {
        if (WeightGeneratorAudioSource != null)
        {
            WeightGeneratorAudioSource.PlayOneShot(audio);
        }
        else
        {
            Debug.Log("オーディオソースが設定されてない");
        }
    }
}
