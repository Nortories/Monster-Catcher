using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class monster_encounter : MonoBehaviour
{
    [SerializeField] private Collider2D player;
    [SerializeField] private GameObject playerTag;
    [SerializeField][Range(1, 100)] private int encounterPercent;
    private BoxCollider2D monsterCollider;
    private Collider2D other;
    private static int min = 1;
    private static int max = 1000;


    // Start is called before the first frame update
    void Start()
    {
        monsterCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        EncounterProb();
    }

    private void EncounterProb()
    {
        int randomNum = Random.Range(min, max);
        Debug.Log(randomNum);

        if (randomNum < encounterPercent)
        {
            if (playerTag.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("TestScene");
                //sceneManager changing to new scene not working
            }
        }
    }
}