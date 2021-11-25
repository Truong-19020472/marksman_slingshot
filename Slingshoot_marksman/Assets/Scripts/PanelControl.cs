using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PanelControl : MonoBehaviour
{
    // public Button btn;
    private GameObject diceCrab;
    private GameObject diceChick;
    private GameObject diceShrimp;
    
    public Image crab;
    public Image shrimp;
    public Image fish;
    public Image chick;
    public Image wine;
    public Image huu;

    public Sprite cua;
    public Sprite ca;
    public Sprite ga;
    public Sprite tom;
    public Sprite deer;

    [SerializeField]
    private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        diceCrab = GameObject.FindGameObjectWithTag("diceCrab");
        diceChick = GameObject.FindGameObjectWithTag("diceChick");
        diceShrimp = GameObject.FindGameObjectWithTag("diceShrimp");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(txt.text == "Play") {
            isWhat(diceCrab);
            isWhat(diceChick);
            isWhat(diceShrimp);
            StartCoroutine(result());
        }
    }
    IEnumerator result() {
        yield return new WaitForSeconds(2f);
    }

    void isWhat(GameObject diceRandom) {
        if(diceRandom.GetComponent<SpriteRenderer>().sprite == cua)  {
            crab.GetComponent<Outline>().enabled = true;
            return;
        }
        if(diceRandom.GetComponent<SpriteRenderer>().sprite == ca) {
            fish.GetComponent<Outline>().enabled = true;
            return;
        }
        if(diceRandom.GetComponent<SpriteRenderer>().sprite == ga) {
            chick.GetComponent<Outline>().enabled = true;
            return;
        }
        if(diceRandom.GetComponent<SpriteRenderer>().sprite == deer) {
            huu.GetComponent<Outline>().enabled = true;
            return;
        }
        if(diceRandom.GetComponent<SpriteRenderer>().sprite == tom) {
            shrimp.GetComponent<Outline>().enabled = true;
            return;
        }
        else
        {
            wine.GetComponent<Outline>().enabled = true;
        } 
    }
}
