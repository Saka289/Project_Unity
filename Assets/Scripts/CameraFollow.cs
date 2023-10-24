using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransfrom;
    public float speed;

    // tạo ra 4 giá trị để lưu kích cỡ màn hình tránh việc nhìn ra bên ngoài background
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        //set the current position of the camera to be equal to the player's position.
        transform.position = playerTransfrom.position;  
    }

    // Update is called once per frame
    void Update()
    {
       if(playerTransfrom != null)
        {
            // kiềm chế
            float clampedX = Mathf.Clamp(playerTransfrom.position.x, minX, maxX);
            float clampedY = Mathf.Clamp(playerTransfrom.position.y, minY, maxY);
            transform.position = Vector2.Lerp(transform.position, new Vector2(clampedX,clampedY), speed);
        }
    }
}
