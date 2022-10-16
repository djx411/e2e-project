using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{


    public LevelController LevelController;

    public GameObject[] agUpgrades;
    public GameObject[] maUpgrades;
    public GameObject[] oilUpgrades;
    public GameObject[] expUpgrades;

    public Button[] agButton;
    public Button[] maButton;
    public Button[] oilButton;
    public Button[] expButton;

    public int[] agCosts;
    public int[] maCosts;
    public int[] oilCosts;
    public int[] expCosts;


    public int cur = 1;



    public void purchaseAgUpgrade(int i){
        Debug.Log(i);
        if(LevelController.cashMoney > agCosts[i]){

            LevelController.cashMoney -= agCosts[i];
            agButton[i].interactable = false;
            switch(i){
                case 0:
                    LevelController.cashGen *= (float)1.2;
                    LevelController.tempIncreaseRate += (float)1;
                    LevelController.resourceUsageRate += (float)1;
                    LevelController.imageLossRate += (float)1;
                    break;
                case 1:
                    LevelController.cashGen += (float)1000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate += (float)1;
                    break;
                case 2:
                    LevelController.cashGen *= (float)1.2;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate *= (float)2;
                    break;
                case 3:
                    LevelController.cashGen += (float)5000;
                    LevelController.tempIncreaseRate += (float)1;
                    LevelController.resourceUsageRate += (float)1;
                    LevelController.imageLossRate += (float)1;
                    break;
                case 4:
                    LevelController.cashGen += (float)10000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)2;
                    LevelController.imageLossRate += (float)0;
                    break;
                case 5:
                    LevelController.cashGen *= (float)2;
                    LevelController.tempIncreaseRate += (float)2;
                    LevelController.resourceUsageRate += (float)2;
                    LevelController.imageLossRate += (float)0;
                    break;
                case 6:
                    LevelController.cashGen += (float)0;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate -= (float)1;
                    break;
                case 7:
                    LevelController.cashGen *= (float)1.5;
                    LevelController.tempIncreaseRate += (float)1;
                    LevelController.resourceUsageRate += 1;
                    LevelController.imageLossRate *= (float) 1.5;
                    break;
                case 8:
                    LevelController.cashGen += (float)250000;
                    LevelController.tempIncreaseRate += (float)1;
                    LevelController.resourceUsageRate += (float)1;
                    break;
                case 9:
                    LevelController.cashGen *= (float)2;    
                    LevelController.tempIncreaseRate += (float)1.0;
                    LevelController.resourceUsageRate += (float)1;
                    LevelController.imageLossRate += (float)1;
                    break;
                
                
            }
        }
    }

    public void purchaseMaUpgrade(int i){
        if(LevelController.cashMoney > maCosts[i]){
            LevelController.cashMoney -= maCosts[i];
            maButton[i].interactable = false;
            switch(i){
                case 0:
                    LevelController.cashGen *= (float)1.4;
                    LevelController.tempIncreaseRate += (float)1;
                    LevelController.resourceUsageRate += (float)1;
                    LevelController.imageLossRate += (float)0;
                    break;
                case 1:
                    LevelController.cashGen += (float)10000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate += (float)1;
                    break;
                case 2:
                    LevelController.cashGen *= (float)1.2;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate *= (float)2;
                    break;
                case 3:
                    LevelController.cashGen += (float)50000;
                    LevelController.tempIncreaseRate *= (float)1.3;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate += (float)2;
                    break;
                case 4:
                    LevelController.cashGen += (float)100000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate += (float)8;
                    break;
                case 5:
                    LevelController.cashGen += (float)100000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate += (float)12;
                    break;
                case 6:
                    LevelController.cashGen += (float)25000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate -= (float)2;
                    break;
                case 7:
                    LevelController.cashGen *= (float)1.2;
                    LevelController.tempIncreaseRate += (float)2;
                    LevelController.resourceUsageRate += 3;
                    LevelController.imageLossRate += (float) 1.5;
                    break;
                case 8:
                    LevelController.cashGen *= (float)1.4;
                    LevelController.tempIncreaseRate += (float)15;
                    LevelController.resourceUsageRate += (float)15;
                    LevelController.imageLossRate *= (float) 1.5;
                    break;
                case 9:
                    LevelController.cashGen *= (float)2;
                    LevelController.tempIncreaseRate += (float)2;
                    LevelController.resourceUsageRate += (float)2;
                    LevelController.imageLossRate += (float)2;
                    break;
                
                
            }
        }
    }
    public void purchaseOilUpgrade(int i){
        if(LevelController.cashMoney > oilCosts[i]){
            LevelController.cashMoney -= oilCosts[i];
            oilButton[i].interactable = false;
            switch(i){
                case 0:
                    LevelController.cashGen *= (float)1.6;
                    LevelController.tempIncreaseRate += (float)1;
                    LevelController.resourceUsageRate += (float)1;
                    LevelController.imageLossRate += (float)0;
                    break;
                case 1:
                    LevelController.cashGen += (float)500000;
                    LevelController.tempIncreaseRate += (float)20;
                    LevelController.resourceUsageRate += (float)20;
                    LevelController.imageLossRate += (float)0;
                    break;
                case 2:
                    LevelController.cashGen *= (float)1.6;
                    LevelController.tempIncreaseRate += (float)25;
                    LevelController.resourceUsageRate += (float)25;
                    LevelController.imageLossRate *= (float)2;
                    break;
                case 3:
                    LevelController.cashGen *= (float)1.7;
                    LevelController.tempIncreaseRate *= (float)1.3;
                    LevelController.resourceUsageRate += (float)30;
                    LevelController.imageLossRate += (float)0;
                    break;
                case 4:
                    LevelController.cashGen += (float)0;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate -= (float)5;
                    break;
                case 5:
                    LevelController.cashGen += (float)1000000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)50;
                    LevelController.imageLossRate += (float)20;
                    break;
                case 6:
                    LevelController.cashGen += (float)100000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate -= (float)10;
                    break;
                case 7:
                    LevelController.cashGen *= (float)1.2;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += 0;
                    LevelController.imageLossRate *= (float) 1.5;
                    break;
                case 8:
                    LevelController.cashGen += (float)500000;
                    LevelController.tempIncreaseRate += (float)0;
                    LevelController.resourceUsageRate += (float)0;
                    LevelController.imageLossRate *= (float) 1.5;
                    break;
                case 9:
                    LevelController.cashGen *= (float)2;
                    LevelController.tempIncreaseRate *= (float)2;
                    LevelController.resourceUsageRate *= (float)2;
                    LevelController.imageLossRate *= (float)2;
                    break;
                
                
            }
        }
    }
    public void purchaseExpUpgrade(int i){
        if(LevelController.cashMoney > expCosts[i]){
            LevelController.cashMoney -= expCosts[i];
            expButton[i].interactable = false;
            LevelController.continents[i].present = true;
            LevelController.continents[i].animator.SetTrigger("infected");
        }
    }


    void reset(){
        if(cur == 1){
            for(int i = 0; i < agUpgrades.Length; i++){
                agUpgrades[i].SetActive(false);
            }
        }
        if(cur == 2){
        for(int i = 0; i < maUpgrades.Length; i++){
            maUpgrades[i].SetActive(false);
        }
        }
        if(cur == 3){
        for(int i = 0; i < oilUpgrades.Length; i++){
            oilUpgrades[i].SetActive(false);
        }}
        if(cur == 4){        
        for(int i = 0; i < expUpgrades.Length; i++){
            expUpgrades[i].SetActive(false);
        }}
    }

    public void ag(){
        reset();
        cur = 1;
        for(int i = 0; i < agUpgrades.Length; i++){
            agUpgrades[i].SetActive(true);
        }
    }
    public void ma(){
        reset();
        cur = 2;
        for(int i = 0; i < maUpgrades.Length; i++){
            maUpgrades[i].SetActive(true);
        }
    }
    public void oil(){
        reset();
        cur = 3;
        for(int i = 0; i < oilUpgrades.Length; i++){
            oilUpgrades[i].SetActive(true);
        }
    }

    public void checkExp(){
        for(int i = 0; i < 6; i++){
            if(LevelController.continents[i].present){
                expButton[i].interactable = false;
            }
        }
    }

    public void exp(){
        reset();
        cur = 4;
        for(int i = 0; i < expUpgrades.Length; i++){
            expUpgrades[i].SetActive(true);
        }
        checkExp();
    }

    // Start is called before the first frame update
    void Start()
    {  
        cur = 2;
        reset();
        cur = 3;
        reset();
        cur = 4;
        reset();
        cur = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
