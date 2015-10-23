using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AnsQ4 : MonoBehaviour
{
    public static int q1;
    public static int q2;
    public static int q3=0;
    public Dropdown DropDown1;
    public Dropdown DropDown2;

    public void start()
    {
        DropDown1 = GetComponent<Dropdown>();
        DropDown2 = GetComponent<Dropdown>();
    }

    public void getAns()
    {
        AnsQ4.q1 = DropDown1.value;
        AnsQ4.q2 = DropDown2.value;
        if (AnsQ4.q1 == 2)
        {
            AnsQ4.q1 = 1;
        }
        else
        {
            AnsQ4.q1 = 0;
        }

        if (AnsQ4.q2 == 1)
        {
            AnsQ4.q2 = 1;
        }
        else
        {
            AnsQ4.q2 = 0;
        }
        if (AnsQ4.q1 ==1 && AnsQ4.q2 == 1)
        {
            AnsQ4.q3 = 1;
        }
        Debug.Log(AnsQ4.q1);
        Debug.Log(AnsQ4.q2);
    }

}
