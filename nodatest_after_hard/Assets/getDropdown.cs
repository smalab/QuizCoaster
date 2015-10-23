using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getDropdown : MonoBehaviour {
    public static int player_grade;
    public Dropdown Dropdown;

    public void start()
    {
        Dropdown = GetComponent<Dropdown>();
   
    }

    public void getDrop()
    {
        
        getDropdown.player_grade = Dropdown.value;
        Debug.Log(getDropdown.player_grade);
    }

}
