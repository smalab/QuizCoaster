using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class textsave : MonoBehaviour {

   public static string player;
    public InputField inputField;


    public void save () {
       textsave.player = inputField.text;
       
        inputField.text = "";
        Debug.Log(textsave.player);
    }
    }