using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tokencon : MonoBehaviour
{
    public string curColor;
    void Start()
    {
        curColor = gameObject.tag;
        GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(activateDelay());
    }

    void Update()
    {
        if(gameObject.tag == "UL")
        {
            if((GameFlow.ULchange == "y") && (curColor =="b"))
            {
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
                gameObject.tag = "w";
                GameFlow.totalBlack -= 1;
                GameFlow.totalWhite += 1;
            }

            if ((GameFlow.ULchange == "y") && (curColor == "w"))
            {
                GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                gameObject.tag = "b";

                GameFlow.totalBlack += 1;
                GameFlow.totalWhite -= 1;
            }

            if ((GameFlow.ULchange == "r") && (curColor == "b"))
            {
                gameObject.tag = "b";
            }

            if ((GameFlow.ULchange == "y") && (curColor == "w"))
            {
                gameObject.tag = "w";
            }

        }

    }

    IEnumerator activateDelay()
    {
        yield return new WaitForSeconds(2);
        GetComponent<CircleCollider2D>().enabled = true;
    }
}
