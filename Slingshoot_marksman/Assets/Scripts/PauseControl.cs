using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{
    // private bool isPause = false;
    public Text textButton;

    public GameObject panel;
    [SerializeField]
    private GameObject diceCrab;

    [SerializeField]
    private GameObject diceChick;
    [SerializeField]
    private GameObject diceShrimp;
    // Start is called before the first frame update
    void Start()
    {
       // Time.timeScale = 1;
        
    }

    public void Pause(){
       
        textButton.text = "Play";
        diceCrab.GetComponent<Animator>().enabled = false;
        diceShrimp.GetComponent<Animator>().enabled = false;
        diceChick.GetComponent<Animator>().enabled = false;
        StartCoroutine(waitGame());
        
    
    }
    IEnumerator waitGame()
    {
    
        yield return new WaitForSeconds(3);
        panel.SetActive(false);
    }
}
