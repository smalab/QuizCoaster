using UnityEngine;
using System.Collections;

public class test : MonoBehaviour
{
    public void ClickTest()
    {
        Application.LoadLevel("Nodatest_2");
        Debug.Log("Clicked.");
    }
}