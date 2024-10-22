using UnityEngine;

public class GameplayManager : MonoBehaviour
{
   [SerializeField] private GameObject deathScren;

   private void Start()
   {
      GameEvents.Current.OnPlayerDeath += SetActiveDeathScreen;
   }

   private void OnDestroy()
   {
      GameEvents.Current.OnPlayerDeath -= SetActiveDeathScreen;
   }
   private void SetActiveDeathScreen()
   {
      deathScren.SetActive(true);
   }
}
