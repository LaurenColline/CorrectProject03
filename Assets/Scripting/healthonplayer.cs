using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class healthonplayer : MonoBehaviour
{
    [SerializeField] private int _currentHealth = 100;

    [SerializeField] private AudioSource _EnemeyDeath;

    [SerializeField] private ParticleSystem _Particle;

    Rigidbody rb;
    // Start is called before the first frame update

    private FloatingHealthbar healthbar;

    public int maxHealth = 100;
    private int currentHealth;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        healthbar = GetComponentInChildren<FloatingHealthbar>();
    }

    private void Start()
    {
        currentHealth = maxHealth;

    
    }

    public void TakeDamage(int CoinDamage)
    {
        currentHealth -= CoinDamage;
       // _currentHealth = _currentHealth - CoinDamage;
        healthbar.UpdateHealthBar(currentHealth,maxHealth);

      
        if (currentHealth <= 0)
        {

            Die();
            // Player is dead, handle accordingly (e.g., restart level, game over screen).
            Debug.Log("Player is dead!");
        }

        void Die()
        {
            Player(transform.position);
            Destroy(gameObject);
        }

        void Player(Vector3 position)
        {
            transform.position = position;
        }
    }
}

