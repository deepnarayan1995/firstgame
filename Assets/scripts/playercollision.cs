using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public GameObject sparkEffect;

    public playermovement pmv;
    public HealthandEnergy health;
    
    public float damage = 25f;

    public ParticleSystem chargedImpact, healthimpact;

    public GameObject healthLoss, energyLoss;

    //this is the audio Script
    public AudioManager playaudio;

    void OnCollisionEnter(Collision colInfo)
    {
        if (colInfo.collider.tag == "obs")
        {
            playaudio.PlayCollision();
            health.TakeDamage(damage);
            StartCoroutine(ShowCollisionIndicator());
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "level1GEM")
        {
            playaudio.PlayEnergy();
            Destroy(other.gameObject);
            health.currentenergy += 30;
            health.isEnergyReset = true;
            chargedImpact.Play();
        }
        if(other.tag == "Level1HealthGem")
        {
            playaudio.PlayHealthGain();
            Destroy(other.gameObject);
            health.currenthealth += 25;
            healthimpact.Play();
        }
    }

    IEnumerator ShowCollisionIndicator()
    {
        healthLoss.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        healthLoss.SetActive(false);
        energyLoss.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        energyLoss.SetActive(false);
    }


}
