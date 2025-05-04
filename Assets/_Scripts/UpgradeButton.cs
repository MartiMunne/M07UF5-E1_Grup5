using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public GameManager bool_script;
    private void Awake()
    {
        GameObject gmObject = GameObject.Find("GameManager");
        bool_script = gmObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            bool_script.UpgradeLog();
        }
    }
}
