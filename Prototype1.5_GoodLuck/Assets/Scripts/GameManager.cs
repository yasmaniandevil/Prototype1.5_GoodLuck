using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    private List<int> playerTaskList = new List<int>();
    //player input list
    private List<int> playerSequenceList = new List<int>();

    //list of audio clips
    public List<AudioClip> SoundsList = new List<AudioClip>();
    
    //list of colors
    public List<List<Color32>> cubeColors = new List<List<Color32>>();

    public List<GameObject> clickableCubes;

    public AudioClip audioSource;
    public AudioClip loseSound;

    public void Awake()
    {
        //initzialise list of colors
        cubeColors.Add(new List<Color32> {new Color32(255,100,100,255), new Color32(255, 0, 0, 255)});
        cubeColors.Add(new List<Color32> {new Color(255, 187, 109, 255), new Color32(255,136, 0, 255)});
        cubeColors.Add(new List<Color32> {new Color32(102,255,124,255), new Color32(72, 248, 0, 255)});
        cubeColors.Add(new List<Color32> {new Color32(57,111,255,255), new Color32(0, 70, 255, 255)});

        for (int i = 0; i < 4; i++)
        {
            clickableCubes[i].GetComponent<Renderer>().material.color = cubeColors[i][0];
        }
        //clickableCubes[0].GetComponent<Renderer>().material.color = cubeColors[0][0];
        //clickableCubes[0].GetComponent<Renderer>().material.color = cubeColors[1][0];
        //clickableCubes[0].GetComponent<Renderer>().material.color = cubeColors[2][0];
        //clickableCubes[0].GetComponent<Renderer>().material.color = cubeColors[3][0];
    }

    public void AddToPlayerSequenceList(int cubeID)
    {
        //adds cube ID to player sequence list
        playerSequenceList.Add(cubeID);
        for (int i = 0; i < playerSequenceList.Count; i++)
        {
            if (playerTaskList[i] == playerSequenceList[i])
            {
                //if it is the same then continue
                continue;
            }
            else
            {
                //if not end game
                Debug.Log("Lost");
                return;
            }
        }

        if (playerSequenceList.Count == playerTaskList.Count)
        {
            Debug.Log("StartNextRound");
            StartCoroutine(StartNextRound());
        }
    }
    
    public IEnumerator StartNextRound()
    {
        playerSequenceList.Clear();
        clickableCubes[0].SetActive(false);
        yield return new WaitForSeconds(2f);
        playerTaskList.Add(Random.Range(0,4));
        clickableCubes[0].SetActive(true);
        yield return null;
    }
}
