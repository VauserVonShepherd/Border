using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Damageable : MonoBehaviour, IDamageable<int>{
    protected int maxHealth = 1;
    protected int currentHealth;
    
    public virtual void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {

    }
}
