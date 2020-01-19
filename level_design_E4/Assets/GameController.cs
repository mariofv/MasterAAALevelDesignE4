using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private uint goal = 1;
    public uint coins = 0;
    public uint diamonds = 0;
    public uint stars = 0;

    public void DiamondCollected(GameObject diamond)
    {
        ++diamonds;
    }
    public void CoinCollected(GameObject coin)
    {
        ++coins;
    }
    public void StarCollected(GameObject star)
    {
        ++stars;
        if(stars == goal)
        {
            //WIN;
        }
    }
}
