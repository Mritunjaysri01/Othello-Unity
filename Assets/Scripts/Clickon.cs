using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickon : MonoBehaviour
{
    public Transform wtokenObj;
    public Transform btokenObj;
    public Transform probeULOBJ; 
    private void OnMouseDown()
    {
        if (GameFlow.currentTurn == "w")
        {
            Instantiate(wtokenObj, transform.position, wtokenObj.rotation);
            StartCoroutine(waittochangeB());
            //GameFlow.currentTurn = "b";
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(probeULOBJ, transform.position, probeULOBJ.rotation);
            GameFlow.totalWhite += 1;
            Debug.Log("White : " + GameFlow.totalWhite);
        }
        else

        if (GameFlow.currentTurn == "b")
        {
            Instantiate(btokenObj, transform.position, btokenObj.rotation);
            StartCoroutine(waittochangeW());
            // GameFlow.currentTurn = "w";
            GetComponent<BoxCollider2D>().enabled = false;
            Instantiate(probeULOBJ, transform.position, probeULOBJ.rotation);
            GameFlow.totalBlack += 1;
            Debug.Log("Black : " + GameFlow.totalBlack);
        }
    }

    IEnumerator waittochangeW()
    {
        yield return new WaitForSeconds(6);
        GameFlow.currentTurn = "w";
        GameFlow.ULchange = "n";
    }
    IEnumerator waittochangeB()
    {
        yield return new WaitForSeconds(6);
        GameFlow.currentTurn = "b";
        GameFlow.ULchange = "n";
    }

    private void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
    }

    private void OnMouseExit()
    {
       GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
    }
}
