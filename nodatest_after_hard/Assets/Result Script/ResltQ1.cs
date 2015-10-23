using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResltQ1 : MonoBehaviour {
    // public GameObject ResultQ1.1;
    public Text rltQ1;
    public string ResQ1_1;
    // Use this for initialization
    void Start()
    {

        if (AnsQ1.q1 == 1)
        {
            ResQ1_1 = "○";
        }
        else
        {
            ResQ1_1 = "×";
        }

        rltQ1.text =ResQ1_1;

    }
}