using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ButtonEvent : MonoBehaviour
{
    [SerializeField] int sceneIndex;
    [SerializeField] GameObject _enemey;

    public Button fightButton;
    public Button checkButton;
    public Button itemButton;
    public Button runButton;

    // Start is called before the first frame update
    void Start()
    {

        Button fight = fightButton.GetComponent<Button>();
        fight.onClick.AddListener(FightButton);

        Button check = checkButton.GetComponent<Button>();
        check.onClick.AddListener(CheckButton);

        Button item = itemButton.GetComponent<Button>();
        item.onClick.AddListener(ItemButton);

        Button run = runButton.GetComponent<Button>();
        run.onClick.AddListener(RunButton);
        
    }
    
    // Run when fight button is pressed.
    void FightButton()
    {
        // Gets a copy of monster data from encounter Scene enemey
        MonsterSpawner enemeyData =_enemey.GetComponent<MonsterSpawner>();
        (string,int, MonsterClass) enemyTypeAndIndex = enemeyData.GetMonsterData();
        string type = enemyTypeAndIndex.Item1;
        int enemyIndex = enemyTypeAndIndex.Item2;
        MonsterClass jsonData = enemyTypeAndIndex.Item3;
        Monster[] typeOfMonster;

        // Passes in monsterType from encounter Scene enemey
        switch(type){
                case "stone":
                typeOfMonster = jsonData.stone;
                break;

                case "water":
                typeOfMonster = jsonData.water;
                break;

                default:
                typeOfMonster = jsonData.stone;
                break;
            }
        // set var of copyed monster data to caughtEnemey
        Monster caughtEnemey = typeOfMonster[enemyIndex];

        // add unique id to monsters name before converting to json
        DateTime DT = DateTime.Now;
        caughtEnemey._id = ($"_id-{DT.ToString()}");

        // set caughtEnemy Data back to Json format
        string json = JsonUtility.ToJson(caughtEnemey);

        // PUT json to DB

        

        Debug.Log(json);
        Debug.Log("The fight button was pressed!");
        // Scene change back to map
        RunButton();
    }
    void CheckButton()
    {
        Debug.Log("The check button was pressed!");
    }
    void ItemButton()
    {
        Debug.Log("The item button was pressed!");
    }
    void RunButton()
    {
        Debug.Log("The run button was pressed!");
        SceneManager.LoadScene(sceneIndex);
    }
}
