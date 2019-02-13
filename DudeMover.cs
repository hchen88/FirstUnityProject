using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// MonoBehavior is behaviors that your write
public class DudeMover : MonoBehaviour 
{


    public float moveSpeedX;
    public float moveSpeedY;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float deltaY = moveSpeedY * verticalInput * Time.deltaTime;
        float deltaX = moveSpeedX * horizontalInput * Time.deltaTime; 
        //Time.deltaTime account for change in real time like in pub g ,m/s * m = m

        //transform.position = transform.position + new Vector3(0.1f, 0, 0);
        transform.position += new Vector3(deltaX, deltaY, 0);
    }
}
