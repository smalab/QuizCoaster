using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ2_1 : MonoBehaviour
{
    // public GameObject ResultQ1.1;
    public Text rltQ2_1;
    public string ResQ2_1;
    // Use this for initialization
    void Start()
    {

        if (AnsQ1.q3 == 1)
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