using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado_Damage : MonoBehaviour
{
    public int damage;
    public Player_health playerHealth;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("I got Hit!");
            playerHealth.TakeDamage(damage);
        }
    }
}
