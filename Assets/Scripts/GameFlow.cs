using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform squareObj;
    public static string currentTurn = "w";
    public static string ULchange = "n";
    public static int totalWhite = 0;
    public static int totalBlack = 0;

    void Start()
    {
        for (float y = 5; y > -5; y -= 1.27f)
        {
            for (float x = -4; x < 5; x += 1.27f)
            {
                Instantiate(squareObj, new Vector2(x, y), squareObj.rotation);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
