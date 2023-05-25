using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float moveSpeed = 5;
    public float mouseSpeed = 5;
    private float mouseVertical = 0;
    private float mouseHorizontal = 0;

    // Start is called before the first frame update
    void Start()
    {
       // characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        mouseHorizontal += Input.GetAxis("Mouse X") * mouseSpeed;
        mouseVertical += Input.GetAxis("Mouse Y") * mouseSpeed;
        Camera.main.transform.localRotation = Quaternion.Euler(mouseHorizontal, mouseVertical,0);
        float forwardMove = Input.GetAxis("Vertical");
        float sideMove = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(sideMove,0,forwardMove);
        characterController.Move(direction * Time.deltaTime * moveSpeed);
    }
}

