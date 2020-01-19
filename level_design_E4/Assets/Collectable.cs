using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            switch (gameObject.tag)
            {
                case "Diamond":
                    other.GetComponent<GameController>().DiamondCollected(gameObject);
                    break;
                case "Coin":
                    other.GetComponent<GameController>().CoinCollected(gameObject);
                    break;
                case "Star":
                    other.GetComponent<GameController>().StarCollected(gameObject);
                    break;
            }
            gameObject.SetActive(false);
        }
       
    }
}
