using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staff : MonoBehaviour
{
    public GameObject spark;
    public Transform shotPoint;
    public float timeBetweenShots;
    private float shotTime;
    public int rot;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotarion = Quaternion.AngleAxis(angle -134, Vector3.forward);
        Quaternion sparkRotation = Quaternion.AngleAxis(angle - rot, Vector3.forward);
        transform.rotation = rotarion;

        if (Input.GetMouseButton(0))
        {
            if (Time.time >= shotTime)
            {
                Instantiate(spark, shotPoint.position, sparkRotation);
                shotTime = Time.time + timeBetweenShots;
            }
        }
    }
}
