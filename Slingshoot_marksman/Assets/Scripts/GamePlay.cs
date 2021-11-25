using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // [SerializeField]
    private GameObject gamePanel;

    public Image chick;
    public Image crab;
    public Image shrimp;
    public Image huu;
    public Image wine;
    public Image fish;
    private GameObject btn;
    public Text txtBtn;
    void Start()
    {
        gamePanel = GameObject.FindGameObjectWithTag("Panel");
        gamePanel.SetActive(true);
        btn = GameObject.FindGameObjectWithTag("Btn");
        

    }
    void hindPanel()
    {
        if(txtBtn.text == "Pause") 
        {
             
        }
    }
    

}
