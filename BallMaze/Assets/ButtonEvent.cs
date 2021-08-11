using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{   
    public GameObject Spieler1;
    public GameObject Spieler2;
    public GameObject Menu;
    public void weiterButton(){
        Spieler1.SetActive(true);
        Spieler2.SetActive(true);
        Menu.SetActive(false);
    }
    public void verlassenButton(){
        SceneManager.LoadScene(0);
    }
}
