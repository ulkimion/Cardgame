using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ScriptableCardDatabase : ScriptableObject
{
    public int id;
    public string cardName;
    public int cost;
    public int damage;
    public string cardDescription;
    public int bullet;
}
