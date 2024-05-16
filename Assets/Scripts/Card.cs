using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{

public int id;
public string cardName;
public int cost;
public int damage;
public string cardDescription;
public int bullet; //bullet 0 = no, bullet 1 = yes

public Card()
{

}

public Card(int Id, string CardName, int Cost, int Damage, string CardDescription, int Bullet)
{
id = Id;
cardName = CardName;
cost = Cost;
damage = Damage;
cardDescription = CardDescription;
bullet = Bullet;
}


}
