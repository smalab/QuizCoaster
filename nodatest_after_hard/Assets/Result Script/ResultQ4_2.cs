using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ResultQ4_2 : MonoBehaviour
{
    public Text rltQ4_2;
    public string ResQ4_2;
    // Use this for initialization
    void Start()
    {

        if (AnsQ2.q3== 1)
        {
            ResQ4_2 = "〇";
        }
        else
        {
            ResQ4_2 = "×";
        }

        rltQ4_2.text = ResQ4_2;

    }
}