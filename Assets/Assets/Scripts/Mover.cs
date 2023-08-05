using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] int moveSpeed = 5;

    //[SerializeField] float xValue = 0.05f;
    [SerializeField] float yValue = 0;
    //[SerializeField] int zValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(xValue * moveSpeed, yValue, zValue * moveSpeed);
    }
}
