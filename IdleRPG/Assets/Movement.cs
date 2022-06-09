
using UnityEngine;


public class Movement : MonoBehaviour
{
    [SerializeField] private Player player;


    private void Update()
    {
        if (player.currentState == "Walk")
        {
            Move();
        }

        if (player.currentState == "Idle" || player.currentState == "Battle")
        {
            StopMoving();
        }                   
    }

    public void Move()
    {
        this.transform.Translate(player.MovementSpeed,0,0,Space.World);
        player.traveledDistance += player.MovementSpeed * Time.deltaTime;
    }

    public void StopMoving()
    {
        this.transform.Translate(0, 0, 0);
    }
}
