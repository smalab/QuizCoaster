using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ3 : MonoBehaviour
{
    public static int q1;
    public static int q2;
    public Dropdown DropDown1;
    public Dropdown DropDown2;

    public void start()
    {
        DropDown1 = GetComponent<Dropdown>();
        DropDown2 = GetComponent<Dropdown>();
    }

    public void getAns()
    {
        AnsQ3.q1 = DropDown1.value;
        AnsQ3.q2 = DropDown2.value;
        if (AnsQ3.q1 == 4)
        {
            AnsQ3.q1 = 1;
        }
        else
        {
            AnsQ3.q1 = 0;
        }

        if (AnsQ3.q2 == 3)
        {
            AnsQ3.q2 = 1;
        }
        else
        {
            AnsQ3.q2 = 0;
        }
        Debug.Log(AnsQ3.q1);
        Debug.Log(AnsQ3.q2);
    }

}
