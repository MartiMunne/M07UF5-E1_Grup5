using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogManager : MonoBehaviour
{
    public GameManager bool_script;
    public Transform spawnPosition;
    public GameObject[] logPrefabs;

    public GameObject currentInstance;
    public void SpawnLog()
    {
        if (currentInstance == null)
        {
            currentInstance = Instantiate(logPrefabs[bool_script.currentLog], spawnPosition.position, spawnPosition.rotation);
            bool_script.currentLogHP = bool_script.logMaxHits[bool_script.currentLog];
        }
    }
    public void DestroyLog()
    {
        if (currentInstance != null)
        {
            Destroy(currentInstance);
            currentInstance = null;
        }
    }
}
