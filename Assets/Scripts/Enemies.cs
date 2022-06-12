using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    public float health;

    public float speed;

    public float timeBetweenAttacks;

    public float damage;


    [HideInInspector]
    public Transform player;
   public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <=0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(health);
    }
}
