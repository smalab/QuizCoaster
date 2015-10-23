using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ2 : MonoBehaviour
{
    public static int q1;
    public static int q2;
    public static int q3;
    public static int q4;
    public Dropdown DropDown1;
    public Dropdown DropDown2;
    public Dropdown DropDown3;
    public Dropdown DropDown4;

    public void start()
    {
        DropDown1 = GetComponent<Dropdown>();
        DropDown2 = GetComponent<Dropdown>();
        DropDown3 = GetComponent<Dropdown>();
        DropDown4 = GetComponent<Dropdown>();
    }

    public void getAns()
    {
        AnsQ2.q1 = DropDown1.value;
        AnsQ2.q2 = DropDown2.value;
        AnsQ2.q3 = DropDown3.value;
        AnsQ2.q4 = DropDown4.value;
        if (AnsQ2.q1 == 1)
        {
            AnsQ2.q1 = 1;
        }
        else
        {
            AnsQ2.q1 = 0;
        }

        if (AnsQ2.q2 == 2)
        {
            AnsQ2.q2 = 1;
        }
        else
        {
            AnsQ2.q2 = 0;
        }
        if (AnsQ2.q3 == 0)
        {
            AnsQ2.q3 = 1;
        }
        else
        {
            AnsQ2.q3 = 0;
        }

        if (AnsQ2.q4 == 0)
        {
            AnsQ2.q4 = 1;
        }
        else
        {
            AnsQ2.q4 = 0;
        }
        Debug.Log(AnsQ2.q1);
        Debug.Log(AnsQ2.q2);
    }

}
