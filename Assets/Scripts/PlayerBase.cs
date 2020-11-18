using UnityEngine;

public abstract class PlayerBase : MonoBehaviour
{
    [SerializeField]
    protected LifeSystemSO lifeSystem;

    #region Unity Methods

    protected virtual void OnEnable()
    {
        ButtonController.MakeDamage += lifeSystem.TakeDamage;
    }

    protected virtual void OnDisable()
    {
        ButtonController.MakeDamage -= lifeSystem.TakeDamage;
    }
    #endregion

    public int CurrentLifePoints()
    {
        return lifeSystem.GetCurrentLifePoints();
    }

}
