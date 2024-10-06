using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Image playerHealthBar;
    private float healthAmount =100f;
    public Image playerAmmoBar;
    private float ammoAmount =10;
    private float maxAmmo = 10; 
    public void UpdateHealthBarUIAfterTakingDamage(float damage)
    {
        healthAmount -= damage;
        playerHealthBar.fillAmount = healthAmount / 100;
    }
    public void UpdateAmmoBarUIAfterFiring()
    {
        ammoAmount --;
        playerAmmoBar.fillAmount =  ammoAmount  / 10; 
    }
    public void ResetAmmoBarUIAfterReloading()
    {
        ResetAmmoAmount();
        playerAmmoBar.fillAmount = 1;
    }
    public void ResetPlaytHealthBarUIAfterHealing()
    {
        healthAmount = 100f;
        playerHealthBar.fillAmount = 1;
    }
    public void ResetAmmoAmount()
    {
        ammoAmount = maxAmmo;
    }
}
