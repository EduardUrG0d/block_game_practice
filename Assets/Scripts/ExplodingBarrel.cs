using UnityEngine;

public class ExplodingBarrel : MonoBehaviour
{
    public GameObject explosionEffect;
    public float explosionRadius = 3f;
    public float explosionForce = 500f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Explode();
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, Quaternion.identity);
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        foreach (Collider2D obj in colliders)
        {
            if (obj.GetComponent<Rigidbody2D>())
            {
                obj.GetComponent<Rigidbody2D>().AddForce(Vector2.up * explosionForce);
            }
        }

        Destroy(gameObject);
    }
}