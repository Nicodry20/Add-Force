using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootingForce;
    public float rotationSpeed;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(- rotationSpeed * Time.deltaTime, 0, 0);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
