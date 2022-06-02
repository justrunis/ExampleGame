using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectle : MonoBehaviour
{
    [Min(0f)]
    [SerializeField]
    private float velocity = 10f;


    private Rigidbody rb;
    [SerializeField]
    private int damage;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = transform.forward * velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            EnemyCOntroller enemy = collision.gameObject.GetComponent<EnemyCOntroller>();
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
