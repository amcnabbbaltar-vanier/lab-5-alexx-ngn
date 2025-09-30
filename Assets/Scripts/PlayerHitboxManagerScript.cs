using UnityEngine;

public class PlayerHitboxManagerScript : MonoBehaviour
{
    public Collider[] attackColliders; // Array to hold multiple attack colliders
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false; // Disable collider at start
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableHitbox()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = true;
        }
    }

    public void DisableHitbox()
    {
        foreach (Collider attackCollider in attackColliders)
        {
            attackCollider.enabled = false;
        }
    }
}
