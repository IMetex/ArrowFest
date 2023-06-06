using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateSplit : MonoBehaviour
{
    public int arrows;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<Player>())
        {
            int playerChildCount = collision.gameObject.GetComponentInParent<Player>().transform.childCount;
            
            arrows = playerChildCount / arrows;
            

            for (int i = 0; i < arrows; i++)
            {
                Destroy(collision.gameObject.GetComponentInParent<Player>().transform.GetChild(i).gameObject);
            }

            Destroy(gameObject);
        }
    }
}

