using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{   
    //button creation for main screen
    [SerializeField] Button huntButton;
    [SerializeField] Button houseButton;
    [SerializeField] Button statsButton;
    [SerializeField] Button exitButton;


    void Start()
    {
        huntButton.onClick.AddListener(ToModeHunt);
        //houseButton.onClick.AddListener();
        //statsButton.onClick.AddListener();
        //exitButton.onClick.AddListener();
    }


    private void ToModeHunt()//calls hunt gamemode page
    {
        SceneLoader.Instance.LoadModeHunt();
    }

}
