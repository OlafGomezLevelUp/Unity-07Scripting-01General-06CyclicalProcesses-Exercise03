using UnityEngine;
using UnityEngine.UI;

public class LifeUIBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text lifeIndicator;
    PlayerBase unfortunateBastard;

    #region Unity Methods

    private void OnEnable()
    {
        ButtonController.RefreshLifeUIElement += RefreshLifeIndicator;
    }

    private void OnDisable()
    {
        ButtonController.RefreshLifeUIElement -= RefreshLifeIndicator;
    }

    private void Awake()
    {
        unfortunateBastard = GetComponent<PlayerBase>();
    }

    private void Start()
    {
        RefreshLifeIndicator();
    }
    #endregion

    private void RefreshLifeIndicator()
    {
        lifeIndicator.text = unfortunateBastard.CurrentLifePoints().ToString();
    }
}
