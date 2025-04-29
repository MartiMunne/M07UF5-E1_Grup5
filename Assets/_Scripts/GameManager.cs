using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentPoints = 0;
    public int currentLog = 1;
    public bool isThereLog = false;

    public static GameManager gm;
    // Start is called before the first frame update
    void Awake()
    {
        gm = this;
    }

    public void HitLog()
    {
        currentPoints = currentLog * 1;

    }
    public void UpgradeLog()
    {
        currentLog++;
    }
    public void BuyAxe()
    {

    }
}
