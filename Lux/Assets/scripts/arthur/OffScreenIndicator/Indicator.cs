using UnityEngine;
using UnityEngine.UI;


public class Indicator : MonoBehaviour
{
    [SerializeField] private IndicatorType indicatorType;
    private Image indicatorImage;

    public bool Active
    {
        get
        {
            return transform.gameObject.activeInHierarchy;
        }
    }

    public IndicatorType Type
    {
        get
        {
            return indicatorType;
        }
    }

    void Awake()
    {
        indicatorImage = transform.GetComponent<Image>();
    }

    public void SetImageColor(Color color)
    {
        indicatorImage.color = color;
    }

    public void Activate(bool value)
    {
        transform.gameObject.SetActive(value);
    }
}

public enum IndicatorType
{
    BOX,
    ARROW
}
