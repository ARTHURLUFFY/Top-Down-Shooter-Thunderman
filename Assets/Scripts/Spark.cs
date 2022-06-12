using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float damage;

    public GameObject explosion;

    private void Start()
    {
        Invoke("DestroySpark", lifeTime);
    }

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void DestroySpark()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<Enemies>().TakeDamage(damage);
            
        }
        DestroySpark();
    }
}
