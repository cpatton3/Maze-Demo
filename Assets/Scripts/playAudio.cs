﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider body)
    {
        Debug.Log("Moved through object");
        if (body.gameObject.tag == "body")
        {
            Debug.Log("Was triggered");
            source.Play();
        }
    }
}
