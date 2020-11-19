using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonView : MonoBehaviour
{
   public float mouseSensitivity = 100f;
   public Transform playerBody;
   float xRotation = 0f;
   public Vector3 offset;
   public bool inverted_y;
    public bool inverted_x;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerBody.position+offset;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity* Time.deltaTime;
        xRotation += mouseY*(inverted_y?1:-1);
        xRotation = Mathf.Clamp(xRotation,-50f,50f);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX*(inverted_x?-1:1));
    }
}
