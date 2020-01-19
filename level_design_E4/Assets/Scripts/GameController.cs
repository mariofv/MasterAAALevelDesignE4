using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public uint goal = 1;
    public float seconds_until_exit = 3.0f;
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
            gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.BallUserControl>().enabled = false;
            gameObject.GetComponent<UnityStandardAssets.Vehicles.Ball.BallUserControl>().enabled = false;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

            Invoke("Close", seconds_until_exit);
        }
    }

    void Close()
    {
        Debug.Log("WIN");
        Application.Quit();
    }
}
