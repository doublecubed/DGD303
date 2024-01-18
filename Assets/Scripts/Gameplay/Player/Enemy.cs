using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region VARIABLES

    public float health;
    public float maxHealth;

    #endregion

    #region MOONOBEHAVIOUR

    private void Start()
    {
        health = maxHealth;
    }

    #endregion

    #region METHOD

    public void UpdateHealth(float amount)
    {
        health += amount;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    #endregion

}
