using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;


public class monster_encounter : MonoBehaviour
{
    [SerializeField] private GameObject playerTag;
    [SerializeField][Range(1, 100)] private int encounterPercent;
    [SerializeField] TilemapCollider2D mosterCollider;
    [SerializeField] string sceneName;
    private Collider2D other;
    private static int min = 1;
    private static int max = 10000;


    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (playerTag.gameObject.tag == "Player")
        {
            // Trigger action when colliding with a TilemapCollider2D
            EncounterProb();
        }
    }

    private void EncounterProb()
    {
        int randomNum = Random.Range(min, max);
        Debug.Log(randomNum);

        if (randomNum < encounterPercent)
        {
                SceneManager.LoadScene(sceneName);
                //sceneManager changing to new scene not working
        }
    }
}