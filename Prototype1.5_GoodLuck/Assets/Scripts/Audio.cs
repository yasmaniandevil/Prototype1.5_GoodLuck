using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gm;
    void Start()
    {
        //gets the script game manager by finding the game object that holds it
        //stores the script in gm
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }
    
    //Coroutine with for loop inside it
    private IEnumerator runAudioList()
    {
        for(int i = 0; i < gm.AudioList.Count; i++)
        {
            Debug.Log("clicy");
            //starting at 0 in the list
            //how long are we going thru the list
            //while i is less than the number of objects 
            //incrementing it by 1
            Debug.Log(i);
            //gm which is the component script on the game object
           //Game manager. Audio list which is from game manager and onclick which is from bopoit
           //on click is accessed thru game manager bc we added the cubes that hold tht script bopoit
            gm.AudioList[i].OnClick();
            yield return new WaitForSeconds(2.0f);
        }
        
        StopAllCoroutines();
    }

    // Update is called once per frame
    void Update()
    {
        //if the box is clicked
        //start coroutine which is called runAudioList
        if (Mouse.current.leftButton.isPressed)
        {
            StartCoroutine(runAudioList());
        }
    }

    /*public void ActivateBlocks()
    {
        
        for(int i = 0; i < gm.AudioList.Count; i++)
        {
            //i made a list of bopit scripts
            Debug.Log(i);
            gm.AudioList[i].OnClick();
        }
        //GameManager.AudioList
    }*/
    
}
