using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    void Start()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public GameObject OptionsPannel;
    public void toggleOptionsPanel(){
        	Animator animator = OptionsPannel.GetComponent<Animator>();

            bool isOpen = animator.GetBool("isOpen");
            animator.SetBool("isOpen", !isOpen);
    }

    public void ResolutionDropdown(int val){
        Debug.Log(Screen.currentResolution);
        if(val == 0 ){
            Debug.Log("2160p");
            Screen.SetResolution(3840, 2160, Screen.fullScreen);
        }
        if(val == 1){
            Debug.Log("1440p");
            Screen.SetResolution(2560, 1440, Screen.fullScreen);
        }
        if(val == 2){
            Debug.Log("1080p");
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        }
        if(val == 2){
            Debug.Log("720p");
            Screen.SetResolution(1280, 720, Screen.fullScreen);
        }
        if(val == 2){
            Debug.Log("480p");
            Screen.SetResolution(845, 480, Screen.fullScreen);
        }
        if(val == 2){
            Debug.Log("360p");
            Screen.SetResolution(640, 360, Screen.fullScreen);
        }
        if(val == 2){
            Debug.Log("240p");
            Screen.SetResolution(426, 240, Screen.fullScreen);
        }
    }
    public void ToggleFullScreen(){
        Screen.fullScreen = !Screen.fullScreen;
    }
    public void startGame() {
        SceneManager.LoadScene(1);
    }
}
