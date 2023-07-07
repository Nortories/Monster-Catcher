
using UnityEngine;
using Firebase.Database;
using Firebase.Auth;
using System.Collections;
using System;

public class DataBaseManager : MonoBehaviour
{
    private DatabaseReference dbReference;
    private string _userID;
    // Start is called before the first frame update
    void Start()
    {
        _userID = SystemInfo.deviceUniqueIdentifier;
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void SaveScore()
    {
        string json = "JsonUtility.ToJson(_currentScore)";
        Debug.Log(json);
        dbReference.Child("score").Child(_userID).SetRawJsonValueAsync(json);
        Debug.Log("scoresaved?");
    }
    public void AddToScore()
    {
        SaveScore();
    }

    // public IEnumerator GetScore(Action<string> onCallback)
    // {
    //     var userScoreDate = dbReference.Child("score").Child(_userID).Child("_score").GetValueAsync();
    //     yield return new WaitUntil(predicate: () => userScoreDate.IsCompleted);
    //     if(userScoreDate != null)
    //     {
    //         DataSnapshot snapshot = userScoreDate.Result;
    //         onCallback.Invoke((snapshot.Value.ToString()));
    //     }   
    // }

    // public void GetUserScore()
    // {
    //     StartCoroutine(GetScore((string score) => 
    //     {
    //         //get score from firebaseDB
    //     }));
    // }
}