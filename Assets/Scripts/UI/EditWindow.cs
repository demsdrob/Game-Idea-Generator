using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EditWindow : MonoBehaviour/*, IEventIteration*/
{
    /*[Header("Elements Controller")]
    public ElementInfo _elements;
    public Transform _contentParent;

    [Header("UI")]
    public TMP_InputField _inputField;
    public Button _addElement;
    public Button _closeWindow;

    private void Start()
    {
        if (_elements == null) return;

        GameObject g = _contentParent.GetChild(0).gameObject;
        for (int i = 0; i < _elements._content.Count; i++) SetNewElement(g, _elements._content[i]);
        Destroy(g);

        _addElement.onClick.AddListener(AddElement);
        _closeWindow.onClick.AddListener(CloseWindow);
    }
    public void EventTrigger(string function)
    {
        Invoke(function, 0);
    }
    void SetNewElement(GameObject prefab, string textInfo)
    {
        Transform instance = Instantiate(prefab, _contentParent.transform).transform;
        instance.GetChild(0).GetComponent<TextMeshProUGUI>().text = textInfo;
    }

    #region UI Buttons
    void AddElement()
    {
        if (_inputField.text != null && !_elements._content.Contains(_inputField.text))
        {
            _elements._content.Add(_inputField.text);
            if (_contentParent.childCount > 0) 
                SetNewElement(_contentParent.GetChild(0).gameObject, _inputField.text);
            _inputField.text = "";
        }
        else
            Debug.Log("Info is not valid");
    }
    public void QuitElement(TextMeshProUGUI element)
    {
        int num = _elements._content.IndexOf(element.text);
        _elements._content.RemoveAt(num);
        Destroy(_contentParent.transform.GetChild(num).gameObject);
    }
    void CloseWindow()
    {
        Destroy(this.gameObject);
    }
    #endregion*/
}