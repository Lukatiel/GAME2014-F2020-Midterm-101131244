using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header(
             "Enemy Controller" +
             "Luka Ivicevic, 101131244." +
             "Date Last Modified: October 20, 2020" +
             "The Enemy Controller class, handles enemy movement, checks bounds" +
             "Changed the transform positions to .y from .x, changed the vector3's that are called to have the speed and such use the 'float y' instead of the 'float x'"
     )]

    [Header("Enemy Speed")]
    public float horizontalSpeed;

    [Header("Enemy Bounds Check")]
    public float horizontalBoundary;

    [Header("Enemy Direction")]
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
       //Changed the vector3 so that the horizontal speed multiplication is second 
        transform.position += new Vector3(0.0f, horizontalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
       //Changed the boundaries to .y from .x
        
        // check right boundary
        if (transform.position.y >= horizontalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
