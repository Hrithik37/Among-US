using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
   public float mouseSensitivity = 100f;
   public Transform playerBody;
   float xRotation = 0f;
   float yRotation = 0f;
   public Vector3 offset;
   public bool inverted_y;
    public bool inverted_x;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        yRotation=playerBody.transform.rotation.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity* Time.deltaTime;
        xRotation += mouseY*(inverted_y?1:-1);
        xRotation = Mathf.Clamp(xRotation,-45f,50f);

        yRotation-=mouseX*(inverted_y?1:-1);
        Vector3 temp=offset;
        temp.x=offset.z*Mathf.Sin(yRotation*Mathf.PI/180);
        temp.z=offset.z*Mathf.Cos(yRotation*Mathf.PI/180);
        transform.position = playerBody.position+temp;

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX*(inverted_x?-1:1));
    }
}
