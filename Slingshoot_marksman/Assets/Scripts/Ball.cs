using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public GameObject effect;
    // public GameObject ballPrefab;
    // Rigidbody2D ball;
    // public Transform Hook;// điểm bắn spring 
    // public Transform Idle;//điểm ball nghỉ 
    // Vector3 currentPosition;


    // // public float ReleaseTime = .15f;
    // public float maxDragDistance = 2f;
    // private bool isPressed = false;
    // private float circleRadius;//bán kính bóng

    // public LineRenderer catapultLineFront;//dây trên hay còn là dây phải
    // public LineRenderer catapultLineBack;// dây dưới = dây trái
    // private Ray leftCatapultToProjectile;//đường tia 

    void Start(){
        // GameObject boom = Instantiate(effect, Vector3.zero , Quaternion.identity) as GameObject;
    }
    void Update(){
        if (transform.position.y < -5.3f ) {
            Destroy(gameObject);
        }
    }
    // // Start is called before the first frame update
    // void Start() {
    //     LineRendererSetUp();
    //     circleRadius = 0.33f;
    //     leftCatapultToProjectile = new Ray(catapultLineFront.transform.position, Idle.transform.position);// Ray là đường, tia bắt đầu từ cata và hướng về zero
    //     CreateBall();
    // }
    // void CreateBall() {
    //     if (ball == null) {
    //     ball = Instantiate(ballPrefab).GetComponent<Rigidbody2D>();
    //     ball.transform.position = Idle.position;
    //     ball.GetComponent<Rigidbody2D>().isKinematic = true;
    //     ball.GetComponent<Collider2D>().enabled = false;
    //     LineRendererUpdate();
    //     }
    // }
    // // Update is called once per frame
    // void Update()
    // {
    //     if(isPressed) {
    //         Vector3 mousePosition = Input.mousePosition;
    //         mousePosition.z = 10;
    //         currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    //         currentPosition = Hook.position +  Vector3.ClampMagnitude(currentPosition - Hook.position, maxDragDistance);
    //         ball.transform.position = currentPosition;
    //         LineRendererUpdate();
    //         // if(Vector3.Distance(mous, Hook.position ) > maxDragDistance) {
    //         //     ball.position = Hook.position + (mous - Hook.position).normalized * maxDragDistance;
    //         // }
    //     }

    //     LineRendererUpdate();
    // }
     
    // void LineRendererSetUp() {
    //     if(catapultLineFront == null) {
    //         Debug.LogError("no");
    //     }
    //     catapultLineFront.SetPosition(0, catapultLineFront.transform.position);
    //     catapultLineBack.SetPosition(0, catapultLineBack.transform.position);
    //     catapultLineFront.sortingLayerName = "ForeGround";
    //     catapultLineBack.sortingLayerName = "ForeGround";
    //     catapultLineFront.sortingOrder = 3;
    //     catapultLineBack.sortingOrder = 1;
    // }
    // void LineRendererUpdate() {
    //     Vector2 catapultToProjectile = currentPosition - catapultLineFront.transform.position;// điểm hiện tại của bóng và vị trí đầu dây phải
    //     leftCatapultToProjectile.direction = catapultToProjectile;// đặt hướng của Ray => để dây di chuyển theo bóng
    //     Vector3 holdPoint = leftCatapultToProjectile.GetPoint(catapultToProjectile.magnitude + circleRadius);//trả về điểm cách gốc 1 khoảng distance dọc theo tia Ray
    //     catapultLineFront.SetPosition(1, holdPoint);
    //     catapultLineBack.SetPosition(1, holdPoint);

    // }
    //  void Shoot() {
    //     ball.isKinematic = false;
    //     Vector3 ballForce = (currentPosition - Hook.position) * 6.0f * -1;
    //     ball.velocity = ballForce;
    //     ball = null;
    //     // ballCollider = null;
    //     if(ball == null) 
    //     Invoke("CreateBall", 2);
    // }
    // private void OnMouseDown() {
    //     isPressed = true;
    //     ball.isKinematic = true;
    // }
    // private void OnMouseUp() {
    //     isPressed = false;
    //     ball.isKinematic = false;
    //     Shoot();
    // }
     void OnCollisionEnter2D(Collision2D other) {
        GameObject boom = Instantiate(effect, transform.position, Quaternion.identity) as GameObject;
        Destroy(this.gameObject);
        Destroy(boom, 0.5f);
        
        
    }

    }
