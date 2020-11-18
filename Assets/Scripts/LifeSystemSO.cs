using UnityEngine;

[CreateAssetMenu(fileName = "LifeSystemSO", menuName = "Life")]
public class LifeSystemSO : ScriptableObject
{
    [SerializeField]
    private int lifePoints;

    [SerializeField]
    private int maximumLifePoints;

    public void TakeDamage(int damage)
    {
        lifePoints -= damage;
    }

    public int GetCurrentLifePoints()
    {
        return lifePoints;
    }

    public void ResetLifePointsToMax()
    {
        lifePoints = maximumLifePoints;
    }
}
