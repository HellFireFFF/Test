using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowHealth : MonoBehaviour
{

    public Text ui;

    protected string uiText = "";

    public GameObject player;

    protected float playerHealthRightNow;
    protected string playerHealthRightNowText;

    protected float playerHealthFull;
    protected string playerHealthFullText;

    public void Start()
    {



    }

    public void Update()
    {

        playerHealthRightNowText = playerHealthRightNow.ToString();
        playerHealthFullText = playerHealthFull.ToString();
        playerHealthRightNow = player.GetComponent<Stats>().currentHitpoints;
        playerHealthFull = player.GetComponent<Stats>().baseHitpoints + player.GetComponent<Stats>().hitpointsBonus;

        ShowHealthPlayer();
        ui.text = uiText;

    }

    public void ShowHealthPlayer()
    {

       uiText = playerHealthRightNow + "/" + playerHealthFull;

    }

}
