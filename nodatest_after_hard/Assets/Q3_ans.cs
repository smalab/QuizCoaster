using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Q3_ans : MonoBehaviour {

    public Text rltQ3_1;
    public string ResQ3_1;
    // Use this for initialization
    void Start()
    {

        if (AnsQ3.q2 == 1)
        {
            ResQ3_1 = "〇";
        }
        else
        {
            ResQ3_1 = "×";
        }

        rltQ3_1.text = ResQ3_1;
    }
    }
