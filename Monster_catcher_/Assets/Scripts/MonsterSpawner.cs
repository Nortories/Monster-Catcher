using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Sets attributes to gameObject from JsonFile
public class MonsterSpawner : MonoBehaviour
{
    // attributes of gameObject
    [SerializeField] TextAsset JsonFile;
    [SerializeField] string monsterType;
    public SpriteRenderer spriteRenderer;
    public string _name;
    public float _height;
    public int _power;
    public int _health;
    public string _personality;
    public int _aggressionLevel;
    public int _rarity;

    void Start()
    {

        // Read in JsonFile converting to object of MonsterClass  (In a list of Monster classes)
        MonsterClass monsterData = JsonUtility.FromJson<MonsterClass>(JsonFile.text);


            Monster[] typeOfMonster;

            // Passes in monsterType from [SerializeField] Monster(s) within MonsterClass[]
            switch(monsterType){
                case "stone":
                typeOfMonster = monsterData.stone;
                break;

                case "water":
                typeOfMonster = monsterData.water;
                break;

                default:
                typeOfMonster = monsterData.stone;
                break;
            }

            // Generate a rand number of length of monsters in list
            int randSelector = Random.Range(0, (typeOfMonster.Length));

            // Gen rand monster of TYPE
            Monster enemy = typeOfMonster[randSelector];

            // Gets sprite in the "Sprites/" folder thats labed the name of the monster 
            // Uses Resources folder inside of assests. This helps insure the path
            Sprite sprite = Resources.Load<Sprite>("Sprites/" + enemy._name);
            // replaces sprite with selected monsters _name
            spriteRenderer.sprite = sprite;

            // Set values from randomly selected Monster
            _name = enemy._name;
            _height = enemy._height;
            _power = enemy._power;
            _health = enemy._health;
            _personality = enemy._personality;
            _aggressionLevel = enemy._aggressionLevel;
            _rarity = enemy._rarity;

            Debug.Log($"Monster Spawned {typeOfMonster[randSelector]._name}");
            Debug.Log($"Health = {typeOfMonster[randSelector]._health}");
    }
}
