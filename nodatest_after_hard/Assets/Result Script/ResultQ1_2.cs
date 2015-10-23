using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ1_2 : MonoBehaviour
{
    // public GameObject ResultQ1.1;
    public Text rltQ1_2;
    public string ResQ1_2;
    // Use this for initialization
    void Start()
    {

        if (AnsQ1.q2 == 1)
        {
            ResQ1_2 = "〇";
        }
        else
        {
            ResQ1_2 = "×";
        }

        rltQ1_2.text = ResQ1_2;

    }
}