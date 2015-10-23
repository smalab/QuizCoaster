using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Q2_ans : MonoBehaviour {
    public Text rltQ2_1;
    public string ResQ2_1;
    // Use this for initialization
    void Start()
    {

        if (AnsQ3.q1 == 1)
        {
            ResQ2_1 = "〇";
        }
        else
        {
            ResQ2_1 = "×";
        }

        rltQ2_1.text = ResQ2_1;
    }
    }
