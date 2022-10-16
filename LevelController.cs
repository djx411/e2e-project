using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelController : MonoBehaviour
{
    public Continent[] continents;

    public Button[] continentButtons;

    public GameObject menu;


    public float time;
    public TextMeshProUGUI timeText;

    public float cashMoney;
    public float cashGen;
    public TextMeshProUGUI cashText;

    public float publicImage;
    public float imageLossRate;
    public Image imageFill;

    public float temp;
    // tempIncreaseRate is 100x rate of increase
    public float tempIncreaseRate;
    public Image tempFill;

    public float resourceUsageRate;


    private bool stop;


    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        stop = true;
        cashMoney = 100000;
        publicImage = 100;
        temp = 60;
        tempIncreaseRate = (float)0.01;
        resourceUsageRate = 500;
        cashText.text = "Cash Money: "+cashMoney.ToString("0");
        cashGen = 50;

    }

    bool checkResourcesLeft(){
        for(int i = 0; i < 6; i++){
            if(continents[i].resourcesUsed < continents[i].resources){
                return true;
            }
        }
        return false;
    }

    void endGame(int i){
        stop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(temp > 70){
            endGame(1);
        }else if(!checkResourcesLeft()){
            endGame(2);
        }else if(publicImage <= 0){
            endGame(3);
        }
        if(stop) return;
        time+=Time.deltaTime/10;
        for (int i=0; i<continents.Length; i++)
        {
            if (continents[i].present)
            {
                if (continents[i].resourcesUsed < continents[i].resources)
                {
                    cashMoney += cashGen * (Time.deltaTime);
                    continents[i].cashGenerated += cashGen * (Time.deltaTime/60);
                    continents[i].resourcesUsed += 10*resourceUsageRate * (Time.deltaTime/60);
                    continents[i].infectedFill.fillAmount = continents[i].resourcesUsed / continents[i].resources;
                }

            }
        }
        timeText.text = "Year: " + time.ToString("0");
        temp += (float) 0.5 * tempIncreaseRate * (Time.deltaTime/60); 
        publicImage -= (float) (imageLossRate * 0.00001);
        tempFill.fillAmount = (temp - 60)/10;
        imageFill.fillAmount = publicImage/100;
        cashText.text = "Cash Money: "+cashMoney.ToString("0");
    }

    public void upgradeMenu(){
        menu.SetActive(true);
    }
    public void exitMenu(){
        menu.SetActive(false);
        stop = false;
    }

    public void StartGame(int index)
    {
        stop=false;
        continents[index].present = true;
        continents[index].animator.SetTrigger("infected");
        
        for (int i=0; i<continents.Length;i++)
        {
            continentButtons[i].enabled=false;
        }
        
    }
}
