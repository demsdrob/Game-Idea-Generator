using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElementInfo : MonoBehaviour/*, IEventIteration*/
{
    /*[HideInInspector] public ScriptableCard _cardElements;
    [HideInInspector] public List<string> _content;

    private Image _icon;
    private TextMeshProUGUI _text;
    private ElementsCtrl _ctrl;

    private void Start()
    {
        #region Cards Information
        GetComponent<Image>().color = _cardElements._cardColor;
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = _cardElements._tittle;
        transform.GetChild(2).GetComponent<TextMeshProUGUI>().text = _cardElements._description;

        _content = new List<string>(_cardElements._elements);
        #endregion

        #region UI Elements
        _icon = transform.GetChild(1).GetChild(0).GetComponent<Image>();
        _text = transform.GetChild(1).GetChild(1).GetComponent<TextMeshProUGUI>();

        _icon.gameObject.SetActive(false);
        _text.gameObject.SetActive(false);
        #endregion

        #region Event System
        _ctrl = GetComponentInParent<ElementsCtrl>();
        ElementsCtrl.CreateEventTrigger(this.gameObject, transform.GetChild(0).GetChild(0).gameObject, "EditCard");
        #endregion
    }
    public IEnumerator SelectRandomElement(List<Sprite> icons)
    {
        yield return null;

        _icon.gameObject.SetActive(true);
        _text.gameObject.SetActive(false);

        int randomIcon;

        for (int i = 0; i < 50; i++)
        {
            do randomIcon = Random.Range(0, icons.Count); while (_icon.sprite == icons[randomIcon]);

            _icon.sprite = icons[randomIcon];
            yield return new WaitForSeconds(0.05f);
        }

        _icon.gameObject.SetActive(false);
        _text.gameObject.SetActive(true);

        _ctrl._roll = false;
        _text.text = _content[Random.Range(0, _content.Count)];
    }
    public void EditCard()
    {
        Instantiate(_ctrl._editMenu, transform.parent.parent).GetComponent<EditWindow>()._elements = this;
    }
    public void EventTrigger(string function)
    {
        Invoke(function, 0);
    }*/
}