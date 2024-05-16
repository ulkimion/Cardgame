using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>(); 
    //public CardDatabase cardDatabase;
    public int displayId;
    public int id;
    public string cardName;
    public int cost;
    public int damage;
    public string cardDescription;
    public int bullet;

    public Text cardNameText;
    public Text costText;
    public Text damageText;
    public Text descriptionText;
    //public Text bulletText;

    // Start is called before the first frame update
    void Start()
    {
        displayCard[0] = CardDatabase.cardList[displayId];
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName.ToString();
        cost = displayCard[0].cost;
        damage = displayCard[0].damage;
        cardDescription = displayCard[0].cardDescription;
        bullet = displayCard[0].bullet;

        cardNameText.text = cardName.ToString();
        costText.text = cost.ToString();
        damageText.text = damage.ToString();
        descriptionText.text = cardDescription.ToString();
        //bulletText.text = " " + bullet;
    }
}
