using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    [Header(
             "Bullet Controller" +
             "Luka Ivicevic, 101131244." +
             "Date Last Modified: October 20, 2020" +
             "The bullet Controller class, handles bullet movement, checks bounds" +
             "Changed the transform positions to .x from .y, changed the vector3's that are called to have the speed and such use the 'float x' instead of the 'float y'"
     )]

    [Header("Bullet Speed")]
    public float horizontalSpeed;

    [Header("Bullet Bounds Check")]
    public float horizontalBoundary;

    [Header("Bullet Manager")]
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //Changed the vector3 so that the speed is the first variable instead of the second
        transform.position += new Vector3(horizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        //Changed the transform position from .y to .x
        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
