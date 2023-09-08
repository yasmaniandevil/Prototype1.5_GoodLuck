using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    //script Bopit make a list of these scripts
    //list is in inspector
    //add the cubes that contain the bopit scripts
    public List<Bopit> AudioList = new List<Bopit>();

    public GameManager instance; 
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
