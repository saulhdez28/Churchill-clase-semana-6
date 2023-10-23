using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    float speed = 10.0F;

    [SerializeField]
    float lifeTime = 3.0F;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void FixedUpdate()
    {
        rb.velocity = transform.up * speed;
    }
}
