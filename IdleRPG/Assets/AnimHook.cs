
using UnityEngine;

public class AnimHook : MonoBehaviour
{
    [SerializeField] private GameObject playerDmgCollider;
    public void ActivateDmgCollider()
    {
        playerDmgCollider.SetActive(true);
    }

    public void DeactivateDmgCollider()
    {
        playerDmgCollider.SetActive(false);
    }
}
