using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthandEnergy : MonoBehaviour
{
    public Image energy, life;

    public float maxhealth;
    [HideInInspector]
    public float currenthealth;

    public float maxenergy;
    [HideInInspector]
    public float currentenergy;

    public playermovement pmv;

    public GameObject lowEnInd, CriticalHlth;
    [HideInInspector]
    public bool isEnergyReset;

    bool isGameOver;

    public Text healthText, energyText;

    //this is the audio Script
    public AudioManager playaudio;

    public gamemanager GM;

    void Awake()
    {
        currenthealth = maxhealth;
        currentenergy = 100;
        isEnergyReset = true;
        isGameOver = false;
    }

    void Update()
    {
        if (isGameOver) return;

        if(currentenergy <= 0 && !isGameOver)
        {
            //currentenergy = 0;
            //playaudio.PlayGameover();
            //isGameOver = true;
            //pmv.enabled = false;
            //GM.GameOverOutofEnergy();
        }

        healthText.text = currenthealth.ToString("0");
        energyText.text = currentenergy.ToString("0");

        if (currentenergy <= 25 && isEnergyReset)
        {
            StartCoroutine(LowEnIndicator());
            isEnergyReset = false;
        }

        if (currentenergy > 0)
        {
            pmv.enabled = true;
        }

        
        StartCoroutine(energydecrease());
        
    }

    public void TakeDamage(float amount)
    {
        currentenergy -= 20f;
        currenthealth -= amount;
        float currentpct = (float)currenthealth / (float)maxhealth;
        life.fillAmount = currentpct;
    }



    IEnumerator energydecrease()
    {
        yield return new WaitForSeconds(1f);
        currentenergy -= 0.2f;
        float decrease_rate = (float)currentenergy / (float)maxenergy;
        energy.fillAmount = decrease_rate;
    }

    IEnumerator LowEnIndicator()
    {
        lowEnInd.SetActive(true);
        yield return new WaitForSeconds(2f);
        lowEnInd.SetActive(false);
    }

    void gameoverForenergyloss()
    {
        
        pmv.enabled = false;
    }
}
