using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    // Start is called before the first frame update
     GameObject[] point;
    void Start()
    {
        point = GameObject.FindGameObjectsWithTag("tree1");
        // point[1] = GameObject.FindGameObjectsWithTag("tree2");
        // point[2] = GameObject.FindGameObjectsWithTag("tree3");
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("log normal");
        transform.localPosition += new Vector3(-2.2f, -1, 0) * Time.deltaTime; // vận tốc = vector3(-2,0,0)
        //transform.localPosition = transform.localPosition + Vector3.left * Time.deltaTime * 2;
        transform.localEulerAngles += new Vector3(0, 0, 90) * Time.deltaTime;
        if(transform.localPosition.y < -5.3f) {
            transform.localPosition = point[Random.Range(0,2)].transform.localPosition;
        }

    }
}
