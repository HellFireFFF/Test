using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindQuest : MonoBehaviour
{

    public Quest quest;
    public float distanceUntilTrigger;
    public string nameOfGameObject;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        if (!quest.completed && quest.isQuestAccepted && Vector3.Distance(this.transform.position, player.transform.position) <= distanceUntilTrigger)
        {
            Debug.Log("Close Enough");
           for (int i = 0; i < quest.goals.Count; i++)
            {
                Debug.Log("Checking Goals");
                if (quest.goals[i].goal.name.Contains(nameOfGameObject))
                {
                    quest.goals[i].completed = true;
                    //quest.goals[i].countCurrent ++;
                    GameObject.Find("Questlog").GetComponent<Questlog>().CheckAddProgress(quest.goals[i].goal); //checks if the current goal is part of a quest and sets the quest to finsihed if true
                }
            }
        }

    }
}
