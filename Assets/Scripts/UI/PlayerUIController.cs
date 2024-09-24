using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image playerHealthBar;
    private float healthAmount =100f;
    public Image playerAmmoBar;

    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealthBarUIAfterTakingDamage(float damage)
    {
        healthAmount -= damage;
        playerHealthBar.fillAmount = healthAmount / 100;
    }
}
