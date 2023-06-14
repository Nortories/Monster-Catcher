using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        // MonsterSpawner enemeyData =_enemey.GetComponent<MonsterSpawner>();
        // (string,int, MonsterClass) enemyTypeAndIndex = enemeyData.GetMonsterData();
        // string type = enemyTypeAndIndex.Item1;
        // int enemyIndex = enemyTypeAndIndex.Item2;
        // MonsterClass jsonData = enemyTypeAndIndex.Item3;
        
        // Debug.Log(jsonData);
        Debug.Log("The fight button was pressed!");
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
