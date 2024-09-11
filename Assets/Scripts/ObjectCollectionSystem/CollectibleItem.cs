using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public int pointValue = 1;
    public AudioClip collectSound;
    public GameObject collectParticlesPrefab;
    public float rotationSpeed = 50f;

    private void Update()
    {
        // Rotación simple del objeto
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Collect(other.gameObject);
        }
    }

    private void Collect(GameObject player)
    {
        ItemManager.Instance.CollectItem(pointValue);

        // Reproducir sonido usando el AudioSource del jugador
        AudioSource playerAudioSource = player.GetComponent<AudioSource>();
        if (playerAudioSource != null && collectSound != null)
        {
            playerAudioSource.PlayOneShot(collectSound);
        }

        // Instanciar y manejar partículas
        if (collectParticlesPrefab != null)
        {
            GameObject particles = Instantiate(collectParticlesPrefab, transform.position, Quaternion.identity);
            ParticleSystem particleSystem = particles.GetComponent<ParticleSystem>();
            if (particleSystem != null)
            {
                // Destruir el objeto de partículas después de que termine la emisión
                float totalDuration = particleSystem.main.duration + particleSystem.main.startLifetime.constantMax;
                Destroy(particles, totalDuration);
            }
            else
            {
                // Si no hay ParticleSystem, destruir después de un tiempo predeterminado
                Destroy(particles, 2f);
            }
        }

        Destroy(gameObject);
    }
}