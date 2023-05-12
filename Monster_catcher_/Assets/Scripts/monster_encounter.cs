using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monster_encounter : MonoBehaviour
{
    [SerializeField] private Collider2D player;
    [SerializeField] private Scene changeScene;
    private BoxCollider2D monsterCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        monsterCollider = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(changeScene.name);
            //sceneManager changing to new scene not working
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
