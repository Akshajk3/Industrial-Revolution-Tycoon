using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Mchine : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject outputItem;
    public float spawnTimer;
    public float value = 0;
    public float addValue;
    public float maxTeirs;
    public GameObject teir1Light;
    public GameObject teir2Light;
    public GameObject teir3Light;
    public TextMeshPro priceText;

    public ParticleSystem upgradeParticle;
    public ParticleSystem moneyParticle;

    public AudioSource upgradeSFX;

    public int spawnCost;

    public int upgradePrice;
    public int upgradeMultiplier;

    public float teirCounter = 0;

    private MachineManager mc;

    private void Start()
    {
        mc = this.GetComponentInParent<MachineManager>();
        InvokeRepeating("GenerateMoney", 1, 1);
        teir1Light.SetActive(false);
        teir2Light.SetActive(false);
        teir3Light.SetActive(false);
        priceText.gameObject.SetActive(false);
        upgradePrice = spawnCost * upgradeMultiplier;

    }

    private void FixedUpdate()
    {
        priceText.text = "$" + upgradePrice.ToString();
        if(mc.money >= upgradePrice)
        {
            priceText.color = Color.green;
        }
        else if(mc.money < upgradePrice)
        {
            priceText.color = Color.red;
        }

        if(teirCounter >= maxTeirs)
        {
            priceText.gameObject.SetActive(false);
        }

        priceText.text = "Upgrade: " + "$" + upgradePrice.ToString() + "\n" + "Profit: " + "$" + (value + addValue).ToString();
        
    }

    public void GenerateMoney()
    {
        Debug.Log("Added " + value + " from " + this.gameObject.name + " You will become rich");
        mc.money += value;
        moneyParticle.Play();
    }

    public void UpagradeMachine()
    {
        if(mc.money >= upgradePrice && teirCounter < maxTeirs)
        {
            upgradeSFX.Play();
            upgradeParticle.Play();
            teirCounter += 1;
            value += addValue;
            upgradePrice *= upgradeMultiplier;
            if(teirCounter == 0)
            {
                teir1Light.SetActive(false);
                teir2Light.SetActive(false);
                teir3Light.SetActive(false);
            }
            else if(teirCounter == 1)
            {
                teir1Light.SetActive(true);
                teir2Light.SetActive(false);
                teir3Light.SetActive(false);
            }
            else if(teirCounter == 2)
            {
                teir1Light.SetActive(false);
                teir2Light.SetActive(true);
                teir3Light.SetActive(false);
            }
            else if(teirCounter == 3)
            {
                teir1Light.SetActive(false);
                teir2Light.SetActive(false);
                teir3Light.SetActive(true);
            }
        }
    }

    public void EnterRange()
    {
        if(teirCounter < maxTeirs)
        {
            priceText.gameObject.SetActive(true);
        }
        else
        {
            priceText.gameObject.SetActive(false);
        }
    }

    public void ExitRange()
    {
        priceText.gameObject.SetActive(false);
    }

}
