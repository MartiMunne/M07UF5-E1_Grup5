using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerButton : MonoBehaviour
{
    public LogManager bool_script;
    private void Awake()
    {
        GameObject gmObject = GameObject.Find("LogSpawner");
        bool_script = gmObject.GetComponent<LogManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            bool_script.SpawnLog();
        }
    }
}
