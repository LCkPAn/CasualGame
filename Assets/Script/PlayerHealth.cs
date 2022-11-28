using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth pi;

    public GameObject score;
    private int playerHealth = 3;
    public Image[] hearts;

    

    private bool isDead = false;

    private void Update()
    {
        if (isDead)
        {
            return;
        }
    }
    private void Awake()
    {
        pi = this;
    }
    public void SetHealth(int val)
    {
        // mettre à jour la vie du joueur 
        playerHealth += val;
        if (playerHealth > 3)
        {
            playerHealth = 3;
        } 
        if(playerHealth <= 0)
        {
            playerHealth = 0;
            Debug.Log("mort");
            Death();
        }
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        // On vide la barre de vie
        foreach(Image img in hearts)
        {
            img.enabled = false;
        }
        // Coeur à l'écran
        for (int i=0; i<playerHealth; i++)
        {
            hearts[i].enabled = true;
        }
    }
    
    private void Death()
    {
        Time.timeScale = 0;
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
    
}
