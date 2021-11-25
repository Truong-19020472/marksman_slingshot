using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Transform[] points ;
    int diem = 0;
    int lastPoint = -1;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        diem = Random.Range(0, 4);
        lastPoint = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if( Vector3.Distance(transform.position, points[diem].position) <= 0.5f) {
        lastPoint = diem;
        diem = Random.Range(0, 4);
        BirdMove();
        Debug.Log("bug");
        } 
        else BirdMove();
        
    }
    void BirdMove() {
        float angle = Mathf.Atan2(transform.position.y - points[diem].position.y, transform.position.x - points[diem].position.x) * Mathf.Rad2Deg;
//        Debug.Log(angle);
        if(diem > lastPoint) {
            
            transform.localScale = new Vector3(0.58f, 0.59f, 1) ;
            Quaternion rota = Quaternion.Euler(new Vector3(0, 0, angle));
            transform.rotation = rota;
            
        }
        if(diem < lastPoint) {

            transform.localScale = new Vector3(-0.58f, 0.59f, 1);
            Quaternion rota = Quaternion.Euler(new Vector3(0, 0, (180 - angle)));
            transform.rotation = rota;
            
        }

        transform.position = Vector3.MoveTowards(transform.position, points[diem].position, speed * Time.deltaTime); 
    }
}
