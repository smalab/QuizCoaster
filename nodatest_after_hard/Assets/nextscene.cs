using UnityEngine;
using System.Collections;

public class nextscene : MonoBehaviour
{
    public int next = 1;
    public void ClickTest()
    {
        Application.LoadLevel(next);
        Debug.Log("Clicked.");
       
    }
}