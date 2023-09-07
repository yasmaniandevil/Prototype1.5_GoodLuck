using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //starting at 0 in the list
        //how long are we going thru the list
        //while i is less than the number of objects 
        //incrementing it by 1
        for(int i = 0; i < GameManager.AudioList.Count; i++)
        {
            //i made a list of bopit scripts
            GameManager.AudioList[i].OnClick();
        }
        //GameManager.AudioList
    }
}
