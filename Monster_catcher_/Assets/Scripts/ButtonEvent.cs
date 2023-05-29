using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
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
    }
}
