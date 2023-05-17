using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class monster_encounter : MonoBehaviour
{
    [SerializeField] private Collider2D player;
    [SerializeField] private int encounterPercent = 50;
    [SerializeField] private float delay = 5;
    private BoxCollider2D monsterCollider;
    [SerializeField] private GameObject playerTag;

    private Collider2D other;
    bool running = false;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        monsterCollider = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerStay2D(Collider2D other)
    {

        running = true;
        // if (running)
        // {
        //     Invoke("EncounterProb", delay);

        //     running = false;
        // }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        running = false;
    }

    private void EncounterProb()
    {
        int min = 0;
        int max = 100;
        if (Random.Range(min, max) < encounterPercent)
        {
            if (playerTag.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("TestScene");
                //sceneManager changing to new scene not working
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    //     while (running)
    //     {
    //         timer += Time.deltaTime;
    //         if (timer > delay)
    //         {
    //             EncounterProb();
    //         }
    //     }
    // }
}
