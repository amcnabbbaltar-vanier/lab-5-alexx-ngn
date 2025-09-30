using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void GotHit()
    {
        animator.SetTrigger("GotHit");
        
        // Play hit sound when enemy gets hit
        if (audioSource != null)
        {
            audioSource.Play();
        }
        // Notify GameManager
        if (GameManager.Instance != null)
        {
            GameManager.Instance.AddScore(1); // Add 1 point per hit
        }
    }
}