using System.Collections;
using UnityEngine;
using Firebase;
using Firebase.Firestore;

public class FirebaseInitializer : MonoBehaviour
{
    public FirebaseApp app;
    public FirebaseFirestore firestore;
    
    void Awake() => StartCoroutine(FixDependency());
    private IEnumerator FixDependency()
    {
        var task = FirebaseApp.CheckAndFixDependenciesAsync();
        yield return new WaitUntil(() => task.IsCompleted);

        if(task.Result == DependencyStatus.Available)
        {
            app = FirebaseApp.DefaultInstance;
            firestore = FirebaseFirestore.DefaultInstance;
            print("Firebase Initilized");
        }
        else
        {
            print(string.Format("Could not resolve all Firebase dependencies: {0}", task.Result));
        }
    }
}