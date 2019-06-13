using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Unit")]
public class Unit : ScriptableObject
{
    enum CHARACTERISTIC
    {
        offensive,
        defensive, 
        random
    }

    [SerializeField] private string unitName;
    [SerializeField] private Sprite displayIcon;
    [SerializeField] private string description;
    [SerializeField] private int health;
    [SerializeField] private int mana;
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private CHARACTERISTIC characteristic;

    private Unit[] enemies;
    private Unit[] friends;

    public string Name { get => unitName; set => unitName = value; }
    public Sprite DisplayIcon { get => displayIcon; set => displayIcon = value; }
    public string Description { get => description; set => description = value; }
    public int Health { get => health; set => health = value; }
    public int Mana { get => mana; set => mana = value; }
    public int Attack { get => attack; set => attack = value; }
    public int Defense { get => defense; set => defense = value; }
    private CHARACTERISTIC Characteristic { get => characteristic; set => characteristic = value; }
    public Unit[] Enemies { get => enemies; set => enemies = value; }
    public Unit[] Friends { get => friends; set => friends = value; }

    public void TakeDamage(int value)
    {

    }

    public void TakeTurn()
    {
        if(characteristic == CHARACTERISTIC.defensive)
        {
            //figure out which one of your allies got lowest hp and heal them
        }
        else if(characteristic == CHARACTERISTIC.offensive)
        {
            //attack the toughest opponent
        }
        else
        {
            //attack random opponent
        }
    }
}
