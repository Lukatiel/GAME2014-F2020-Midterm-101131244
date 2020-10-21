using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [Header(
             "Background Controller" +
             "Luka Ivicevic, 101131244." +
             "Date Last Modified: October 20, 2020" +
             "The background Controller class, handles the background movement, checks bounds, resets the background image when it reachs the bound" +
             "Changed the transform positions to .x from .y, changed the vector3's that are called to have the speed and reset use the 'float x' instead of the 'float y'"
     )]

    //Changed from verticalSpeed and verticalBoundary
    [Header("Background Speed")]
    public float horizontalSpeed;

    [Header("Background Bounds Check")]
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        //Changed from ...Vector3(0.0f, verticalBoundary)
        transform.position = new Vector3(horizontalBoundary, 0.22f);
    }

    private void _Move()
    {
        //Same as in Reset
        transform.position -= new Vector3(horizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        //Changed the transform position from .y to .x
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
