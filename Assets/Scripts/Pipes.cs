using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

public float speed = 5f;
private float leftEdge;



private void Start() 
{
    leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
}
private void Update() 
{
    transform.position += Vector3.left * speed * Time.deltaTime;


    //transform.position += Vector3.left(animationSpeed * Time.deltaTime, 0);


    if (transform.position.x < leftEdge) {
        Destroy(gameObject);
    }
}




}
