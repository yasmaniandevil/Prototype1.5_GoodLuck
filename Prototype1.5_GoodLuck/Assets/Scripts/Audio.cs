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
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

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
            gm.AudioList[i].OnClick();
            yield return new WaitForSeconds(2.0f);
        }
        
        StopAllCoroutines();
    }

    // Update is called once per frame
    void Update()
    {
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
