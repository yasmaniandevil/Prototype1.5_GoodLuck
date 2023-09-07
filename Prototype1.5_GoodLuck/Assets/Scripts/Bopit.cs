using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bopit : MonoBehaviour
{
    
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        _audioSource.Play();
        
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
