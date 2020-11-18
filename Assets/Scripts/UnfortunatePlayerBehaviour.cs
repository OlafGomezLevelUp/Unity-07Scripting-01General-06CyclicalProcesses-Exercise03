public class UnfortunatePlayerBehaviour : PlayerBase
{
    private void Awake()
    {
        lifeSystem.ResetLifePointsToMax();
    }
}
