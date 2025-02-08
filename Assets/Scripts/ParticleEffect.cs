using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    public ParticleSystem effect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}