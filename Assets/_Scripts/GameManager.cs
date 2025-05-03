using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public int currentPoints = 0;
    public int currentLog = 1;
    public bool isThereLog = false;
    public int currentLogHP = 0;
    public int[] logMaxHits;
    public int[] logHitValue;

    public GameObject[] logPrefabs;
    public TextMeshPro scoreDisplay;

    public static GameManager gm;
    // Start is called before the first frame update
    void Awake()
    {
        gm = this;
    }
    void Update()
    {
        scoreDisplay.text = Convert.ToString(currentPoints);
    }
    void RefreshScore()
    {

    }
    public void spawnLog()
    {
        if (currentLog <= 1)
        {
            currentLog = 1;
        }
        else if (currentLog >= 3)
        {
            currentLog = 3;
        }
        currentLogHP = logMaxHits[currentLog];
    }
    public void HitLog()
    {
        currentPoints = currentPoints + logHitValue[currentLog];
        currentLogHP--;
        if (currentLogHP <= 0)
        {
            currentPoints = currentPoints + (logHitValue[currentLog] * 3);
            currentLogHP = logMaxHits[currentLog];
            //Destroy Log prefab
        }

    }
    public void UpgradeLog()
    {
        currentLog++;
    }
}
