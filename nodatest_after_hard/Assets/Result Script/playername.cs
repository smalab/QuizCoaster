using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playername : MonoBehaviour {
   // public GameObject pn;
    public Text nametext;
    // Use this for initialization
    void Start () {
        Debug.Log(textsave.player);
        //nametext = pn.GetComponent<GUIText>();
        nametext.text =textsave.player;
        
    }
}
