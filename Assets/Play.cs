using UnityEngine;

public class ParticleEffectController : MonoBehaviour
{
    private ParticleSystem particleSystem;

    void Start()
    {
        // Get the Particle System component attached to this GameObject
        particleSystem = GetComponent<ParticleSystem>();
        
        // Ensure the Particle System is not playing at the start
        if (particleSystem != null)
        {
            particleSystem.Stop();
        }
        else
        {
            Debug.LogWarning("No ParticleSystem found on this GameObject.");
        }
    }

    public void ActivateParticleEffect()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
            Invoke("StopParticleEffect", 2f); // Stop after 2 seconds
        }
    }

    private void StopParticleEffect()
    {
        if (particleSystem != null)
        {
            particleSystem.Stop();
        }
    }
}

