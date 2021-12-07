using UnityEngine;
using UnityEngine.UI;

public class GridOrientation : MonoBehaviour
{
    /*private GridLayoutGroup _glg;
    private RectTransform _rect;
    public int _lenthCount;

    private void Awake()
    {
        _glg = GetComponent<GridLayoutGroup>();
        _rect = GetComponent<RectTransform>();
        _lenthCount = 3;
    }
    void Update()
    {
        if(Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            ChangeOrientation(2, 3);
        }
        else if(Input.deviceOrientation == DeviceOrientation.LandscapeLeft || Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            ChangeOrientation(1, 5);
        }
    }
    void ChangeOrientation(int lines, int lenth)
    {
        _glg.constraintCount = lines;
        _lenthCount = lenth;

        float width = _rect.rect.width;
        _glg.cellSize = new Vector2(width / _lenthCount, width / _lenthCount);
    }*/
}