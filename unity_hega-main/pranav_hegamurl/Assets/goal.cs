using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public winloose winlooseScript;

    private void OnTriggerEnter(Collider other)
    {
        winlooseScript.WinLevel();
    }
}
