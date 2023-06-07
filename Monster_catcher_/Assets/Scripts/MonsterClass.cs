using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sets class same matching Json format (vars and Json names are casesensitive)
[System.Serializable]
public class MonsterClass
{
    // Sets all monsters of TYPE (ie stone, water) to a list
    public Monster[] stone;
    public Monster[] water;

}

[System.Serializable]
public class Monster
{
    public string _name;
    public float _height;
    public int _power;
    public int _health;
    public string _personality;
    public int _aggressionLevel;
    public int _rarity;

}