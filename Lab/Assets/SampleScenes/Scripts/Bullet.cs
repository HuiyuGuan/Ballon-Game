using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 30f;
    public Rigidbody2D  rb;

    public float dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * 5 * Time.deltaTime * (dir > 0 ? 1 : -1));
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ballon")
        {
            Destroy(gameObject);
        }
    }
}
