using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartBird : MonoBehaviour
{
    private int maxHeart = 10;
    private int currentHeart;
    public Slider heartBird;
    private int damage = 2;
    bool isDied;
    // public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        currentHeart = maxHeart;
        heartBird.maxValue = maxHeart;
        heartBird.value = maxHeart;
        isDied = false;
    }

    // Update is called once per frame

    void OnCollisionEnter2D(Collision2D other) {
        currentHeart -= damage;
        heartBird.value = currentHeart;
        if(currentHeart == 0) {
            Destroy(this.gameObject,0.5f);
        }
    }
}
