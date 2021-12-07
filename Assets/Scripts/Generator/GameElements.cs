using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;
using Firebase.Extensions;
using TMPro;

public class GameElements : MonoBehaviour
{
    [SerializeField] private FirebaseInitializer fbInit;

    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TMP_Dropdown dropdown;

    public void Button()
    {
        CollectionReference collection = fbInit.firestore.Collection("Game_Idea_Generator");
        DocumentReference docRef = collection.Document("Environment");

        docRef.GetSnapshotAsync().ContinueWithOnMainThread(task =>
        {
            DocumentSnapshot snapshot = task.Result;

            if (snapshot.Exists)
            {
                //Get VALUES from DB
                
                string username = snapshot.GetValue<string>("username");
                text.SetText(username);
                
                dropdown.ClearOptions();
                //Get Array
                string[] array = snapshot.GetValue<string[]>("type");
                dropdown.AddOptions(new List<string>(array));
                
                print("success");
            }
            else
            {
                print("failed");
            }
        });
    }


    /*public GameObject _elementPrefab, _editMenu;
    public List<ScriptableCard> _elements;

    [HideInInspector] public bool _roll;
    public List<Sprite> _icons;

    private void Awake()
    {
        _roll = false;

        if (_elementPrefab == null || _elements.Count == 0) return;

        for (int i = 0; i < _elements.Count; i++)
        {
            ElementInfo prefab = Instantiate(_elementPrefab, transform.GetChild(1)).GetComponent<ElementInfo>();
            prefab._cardElements = _elements[i];
        }
    }
    public void GenerateGame()
    {
        if (_roll) return;

        Transform parent = transform.GetChild(1);

        for (int i = 0; i < parent.childCount; i++)
        {
            ElementInfo element = parent.GetChild(i).GetComponent<ElementInfo>();
            element.StartCoroutine(element.SelectRandomElement(_icons));
        }

        _roll = true;
        GameObject instace = Instantiate(new GameObject("objeto"), transform);
    }
    static public void CreateEventTrigger(GameObject script, GameObject ui, string functionName)
    {
        var interact = script.GetComponent<IEventIteration>();

        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => { interact.EventTrigger(functionName); });
        ui.GetComponent<EventTrigger>().triggers.Add(entry);
    }*/
}