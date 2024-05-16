using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "Placeholder", 0, 0, "Placeholder", 0));
        cardList.Add(new Card(1, "Steel Bullet", 1, 10, "Do 10 Damage [Bullet]", 1));
        cardList.Add(new Card(2, "Emergency Shield", 1, 0, "Gain 8 Block", 0));
        cardList.Add(new Card(3, "Reload", 0, 0, "Retain, Exhaust. [Reload] 2", 0));
        cardList.Add(new Card(4, "Thinking Ahead", 2, 0, "Gain 20 Block, At the start of your next turn: [Reload] 2", 0));
        cardList.Add(new Card(5, "Fan the Hammer", 2, 0, "[Shoot] 6", 0));
        cardList.Add(new Card(6, "Warning Shot", 0, 0, "Exhaust. Apply 2 [Off-Balance] to all enemies [Bullet]", 1));
        cardList.Add(new Card(7, "Quick fire", 0, 5, "Twice per turn: Draw a card. [Bullet]", 1));
        cardList.Add(new Card(8, "Dodge and shoot", 0, 2, "Do 2 Damage, Gain 4 block, Twice per turn: Draw a card", 0));
        cardList.Add(new Card(9, "Shuffle", 0, 0, "Draw 2 cards, Put 2 cards from your hand a the top of your deck", 0));
        cardList.Add(new Card(10, "Nombre Pendiente", 1, 0, "Gain 12 block, Draw 2 cards", 0));
        cardList.Add(new Card(11, "Force Fields", 2, 0, "Gain 30 defense, you keep your defense for next turn", 0));
        cardList.Add(new Card(12, "Opportunity Dodge", 0, 0, "0 cost, 5 block, Gain 1 energy when discarded", 0));
        cardList.Add(new Card(13, "Hidden Bullet", 2, 0, "At the start of your turn, [Reload] 1", 0));
        cardList.Add(new Card(14, "Void Bullet", 1, 15, "Do 15 Damage. Discard the top 3 cards of your deck [Bullet]", 1));
        cardList.Add(new Card(15, "Dancing Bullet", 1, 10, "Do 10 damage to all enemies. +50% if [Off-Balance]. [Bullet]", 1));
        cardList.Add(new Card(16, "Powered Shot", 1, 0, "[Shoot] 1, Damage +50%, Effects applied twice", 0));
        cardList.Add(new Card(17, "One Two", 1, 0, "[Shoot] 1, if a card was played: [Shoot] 1", 0)); //upgrade [shoot] 2?
        cardList.Add(new Card(18, "Quick Shot", 0, 0, "[Shoot] 1", 0));
        cardList.Add(new Card(19, "Ghost Bullet", 1, 20, "Do 20 damage. Exhaust if played from hand", 0));
        cardList.Add(new Card(20, "Twin Bullet", 1, 10, "Twice per turn: [Shoot 1]. Damage x2 if played by 'Twin Bullet'. [Bullet]", 0));
        cardList.Add(new Card(21, "Requiem", 2, 0, "placeholder", 0));
        cardList.Add(new Card(22, "Electric Bullet", 0, 0, "placeholder ", 1));
        cardList.Add(new Card(23, "Rainbow Bullet", 0, 0, "placeholder ", 1));
        cardList.Add(new Card(24, "Smoke Granade", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(25, "Sniper Rifle", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(26, "Take Aim", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(27, "Preparations", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(28, "Bunker", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(29, "Minigun", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(30, "High Calliber Bullet", 0, 0, "placeholder ", 0));
        cardList.Add(new Card(31, "Shotgun", 0, 0, "placeholder ", 0));
    }

}
