using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player Info")]
    [SerializeField] float playerSpeed = 5f;
    //Represents the player's movement speed

    [Header("Movement Info")]
    [SerializeField] float maxPosX = 1.7f;
    [SerializeField] float minPosX = -1.8f;
    //Minimum and maximum position of the player on the x-axis

    private Vector3 _mOffset;

    private float _mZCoord;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * playerSpeed * Time.deltaTime;
        //Player is moving along z-axis

        if (Input.GetMouseButtonDown(0))
        {
            _mZCoord = Camera.main.WorldToScreenPoint(transform.position).z;
            
            _mOffset = transform.position - GetMouseWorldPos();
            //Offset = Gameobject world position - Mouse world position
        }

        if (Input.GetMouseButton(0) && (GetMouseWorldPos().x + _mOffset.x) < maxPosX && (GetMouseWorldPos().x + _mOffset.x) > minPosX)
        {
            transform.position = new Vector3(GetMouseWorldPos().x + _mOffset.x, transform.position.y, transform.position.z);

        }
    }

    private Vector3 GetMouseWorldPos()
    {
        //Mouse position in the 3D world

        Vector3 mousePoint = Input.mousePosition;
        //Mouse's x and y coordinate

        mousePoint.z = _mZCoord;
        //Mouse's z coordinate 

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

}
