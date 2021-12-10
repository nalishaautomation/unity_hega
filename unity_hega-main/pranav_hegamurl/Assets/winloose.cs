using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winloose : MonoBehaviour
{
    // Start is called before the first frame update

    private bool gameEnded;
    public void WinLevel()
    {
        Debug.Log("YOu Win!");
    }


    public void LooseLevel()
    {
        if (!gameEnded)
        {
            Debug.Log("YOu loose!");
            gameEnded = true;
        }
    }
}
