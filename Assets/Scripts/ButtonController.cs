using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerClickHandler
{
    #region Delegates and Events
    public delegate void Damage(int damage);
    public static event Damage MakeDamage;

    public delegate void RefreshLifeUI();
    public static event RefreshLifeUI RefreshLifeUIElement;
    #endregion

    [SerializeField]
    private int damageQuantity;

    // Method triggered when the button is clicked
    public void OnPointerClick(PointerEventData eventData)
    {
        MakeDamage?.Invoke(damageQuantity);
        RefreshLifeUIElement?.Invoke();
    }
}
