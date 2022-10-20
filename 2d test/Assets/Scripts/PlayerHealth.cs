using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
       health= maxHealth;
    }

    // Update is called once per frame
   public void TakeDamage(int amout)
    {
        health -= amout;
        if(health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
