using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;

    private float movement;
    private float rotation;


    public Rigidbody rb;
    public MeshRenderer[] childs;

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    private void Update()
    {
        Movement();
        if (movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().moveSpeed);
        }

        if (rotation !=0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotateSpeed);
        }
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
