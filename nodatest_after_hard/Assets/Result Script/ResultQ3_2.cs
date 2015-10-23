using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ3_2 : MonoBehaviour
{
    // public GameObject ResultQ1.1;
    public Text rltQ3_2;
    public string ResQ3_2;
    // Use this for initialization
    void Start()
    {

        if (AnsQ2.q1 == 1)
        {
            ResQ3_2 = "〇";
        }
        else
        {
            ResQ3_2 = "×";
        }

        rltQ3_2.text = ResQ3_2;

    }
}