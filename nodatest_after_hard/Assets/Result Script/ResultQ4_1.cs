using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ4_1 : MonoBehaviour
{
    public Text rltQ4_1;
    public string ResQ4_1;
    // Use this for initialization
    void Start()
    {

        if (AnsQ2.q2 == 1)
        {
            ResQ4_1 = "〇";
        }
        else
        {
            ResQ4_1 = "×";
        }

        rltQ4_1.text = ResQ4_1;

    }
}