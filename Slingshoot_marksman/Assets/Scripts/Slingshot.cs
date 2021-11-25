using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    // public GameObject effect;
    public LineRenderer[] lineRenderer;
    public Transform[] stripPosition;
    public Transform center;
    public Transform idlePosition;
    public Vector3 currentPosition;

    // public float ground;//vị trí đất
    // public float piramidMax; // ko chạm vào kim tự tháp
    public float maxLenght;
    bool isMouseDown;

    public GameObject ballPrefab;
    Rigidbody2D ball;
    Collider2D ballCollider;

    public float ballPositionOffset;//phần bù
    public float force;
    void Start()
    {
        lineRenderer[0].positionCount = 2;
        lineRenderer[1].positionCount = 2;
        lineRenderer[0].SetPosition(0, stripPosition[0].position);
        lineRenderer[1].SetPosition(0, stripPosition[1].position);

        CreateBall();
    }

    void CreateBall() {
        ball = Instantiate(ballPrefab).GetComponent<Rigidbody2D>();
        ballCollider = ball.GetComponent<Collider2D>();
        ballCollider.enabled = false;
        ball.isKinematic = true;
        // ball.transform.position = idlePosition.position;
        ResetStrip();
    }
    void Update()
    {
        if(isMouseDown) {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;
            currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            currentPosition = center.position +  Vector3.ClampMagnitude(currentPosition - center.position, maxLenght);//đảm bảo độ lớn vector ko dài hơn maxlength
            //thêm center.position để đảm bảo vector trùng với hướng ban đầu
            // currentPosition = ClamBoundary(currentPosition);
            SetStrip(currentPosition);
            if (ballCollider) {
                ballCollider.enabled = true;
            }
        }
        else 
        {
            ResetStrip();
        }
    }
    private void OnMouseDown() {
        isMouseDown = true;
    }
    private void OnMouseUp() {
        isMouseDown = false;
        Shoot();
    }
    void Shoot() {
        ball.isKinematic = false;
        Vector3 ballForce = (currentPosition - center.position) * force *-1 + Vector3.left*6;
        ball.velocity = ballForce;// public Vector3 velocity - độ thay đổi mỗi giây
        ball = null;
        ballCollider = null;
        Invoke("CreateBall", 1);

    }
    void ResetStrip() {
        currentPosition = idlePosition.position;
        SetStrip(currentPosition);
    }
    void SetStrip(Vector3 position) {
        lineRenderer[0].SetPosition(1, position);
        lineRenderer[1].SetPosition(1, position);

        if(ball) 
        {
        
        Vector3 dir = position - center.position;
        ball.transform.position = position + dir.normalized * ballPositionOffset;
        // ball.transform.right = -dir.normalized;// transform.right thì rotated sẽ change direction còn Vector3.right thì không
        }
        
    }
    
    // Vector3 ClamBoundary(Vector3 vector) {
    //     vector.y = Mathf.Clamp(vector.y, ground, 100);
    //     vector.x = Mathf.Clamp(vector.x, -100, piramidMax);
    //     return vector;
    // }
    
}

