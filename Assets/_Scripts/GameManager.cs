using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public int currentPoints = 0;
    public int currentLog = 0;
    public int currentLogHP = 0;
    public int[] logMaxHits;
    public int[] logHitValue;

    public GameObject[] logPrefabs;
    public TextMeshProUGUI scoreDisplay;
    public LogManager logManagerScript;

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
    public void HitLog()
    {
        if (logManagerScript.currentInstance != null)
        {
            currentPoints = currentPoints + logHitValue[currentLog];
            currentLogHP--;
            if (currentLogHP <= 0)
            {
                currentPoints = currentPoints + (logHitValue[currentLog] * 3);
                currentLogHP = logMaxHits[currentLog];
                logManagerScript.DestroyLog();
            }
        }
    }
    public void UpgradeLog()
    {
        if ((currentLog < 2) && (currentPoints >= (currentLog * 20 + 10)))
        {
            currentPoints = currentPoints - (currentLog + 10);
            currentLog++;
        }
    }
}
