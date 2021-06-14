using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textcon : MonoBehaviour
{

    void Update()
    {
        if (gameObject.name == "wscore")
        {
            GetComponent<Text>().text = GameFlow.totalWhite.ToString();
        }
        if (gameObject.name == "bscore")
        {
            GetComponent<Text>().text = GameFlow.totalBlack.ToString();
        }
    }
}

