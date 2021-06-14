using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class probecon : MonoBehaviour
{
   void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 2);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="e")
        {
            GameFlow.ULchange = "r";
            Destroy(gameObject);
        }

        if (other.tag == GameFlow.currentTurn)
        {
            GameFlow.ULchange = "y";
            Destroy(gameObject);
        }

        if (other.tag != GameFlow.currentTurn)
        {
            other.tag = gameObject.tag;
        }


    }
}
