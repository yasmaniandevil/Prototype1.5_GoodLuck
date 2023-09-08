using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class Bopit : MonoBehaviour
{
    //private Color lerpedColor = Color.magenta;
    
    //private Renderer _renderer;
    private AudioSource _audioSource;
    //order variable in which things are clicked
    private int order;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
        //_renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //called when the cube is clicked
    public void OnClick()
    {
        _audioSource.Play();
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        //lerpedColor = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1));
        //_renderer.material.color = lerpedColor;

    }

    public void OnMouseDown()
    {
      
        
    }


    //call audio source function play
        
    //im the box that got clicked check thru the list
        
    //first define a coroutine
    //whatever changes the color or the sound is the coroutine
    //coroutine is on the block
    //define coroutine private IEnumator
        
    //pass the next block in (through a list?)
    //identity the next block in the coroutine parameters
    //if whatever that peramator is is not null and if what is playing is false
        
    //one script for coroutine, one script for the function, the coroutine calls the function
}
