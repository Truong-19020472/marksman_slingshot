using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // public GameObject ball;
    // public GameObject circle;
    // private float life = 3;
    public GameObject leafPrefab;
    public GameObject[] tree;
    private GameObject leaf;
    // Start is called before the first frame update
    void Awake()
    {
        // leaf = Instantiate(leafPrefab, tree[0].transform.position, Quaternion.identity);
        //leaf.transform.position = tree[Random.Range(0,2)].transform.position;
        // Vector2 posi = circle.transform.position;
        // Instantiate(ball, circle.GetComponent<Transform>().position, Quaternion.identity);
        // Rigidbody2D ri = circle.gameObject.GetComponent<Rigidbody2D>();

        // StartCoroutine(create());
    }

    // Update is called once per frame
    // void Update()
    // {
    //    leaf.transform.localEulerAngles += new Vector3(0,0,30)*Time.deltaTime;
       
    //    leaf.transform.position += new Vector3(-1, -1 , 0)*Time.deltaTime;
    //    if(leaf.transform.position.x < -5.3f) {
    //        Destroy(leaf.gameObject);
    //    }
    // }
    
    // IEnumerator create(){
    //     while(life > 0) {
    //     yield return new WaitForSeconds(5f);
        
    //         Instantiate(ball, circle.GetComponent<Transform>().position, Quaternion.identity);
    //         life --;
    //    }
    // }
}
