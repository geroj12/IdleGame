using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    public float laserLength = 50f;
    public float stopDistance = 2f;
    public float distanceToEnemy = 0f;
    public string Detected = "";

    [SerializeField] private Player player;

    public LayerMask layerMaskToShootAt;


    void Update()
    {
        Detection();
    }


    public void Detection()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right,laserLength, layerMaskToShootAt);
        if (hit.collider != null)
        {
            Debug.Log("RayHit: " + hit.collider.tag);
            Detected = hit.collider.tag;
            distanceToEnemy = hit.distance;
            //Debug.Log("Distance: " + hit.distance);
            if (hit.distance <= stopDistance && hit.collider.tag == "Enemy")
            {
                player.currentState = "Battle";
                player.inBattle = true;
                Debug.Log("Attack Enemy");
            }                     
        }

        if (hit.collider == null)
        {
            player.inBattle = false;
            Detected = "";
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, Vector2.right * laserLength, Color.red);
    }

}
