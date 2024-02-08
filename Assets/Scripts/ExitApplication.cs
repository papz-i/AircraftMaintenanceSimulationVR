using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    public void exitgame()
    {
        Debug.Log("You pressed the exit button.");
        Application.Quit();
    }
}
