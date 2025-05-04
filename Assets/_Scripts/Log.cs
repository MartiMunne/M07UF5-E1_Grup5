using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    public GameManager bool_script;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Axe")
        {
            bool_script.HitLog();
        }
    }
}
