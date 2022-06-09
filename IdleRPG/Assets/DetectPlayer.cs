using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    public float laserLength = -20f;
    public float stopDistance = 2f;
    public float distanceToPlayer = 0f;
    public string Detected = "";

    public LayerMask layerMaskToShootAt;
    
   
    void Update()
    {
        
        Detection();
    }

    public void Detection()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left, laserLength, layerMaskToShootAt);
        if (hit.collider != null)
        {
            Debug.Log("RayHit: " + hit.collider.tag);
            Detected = hit.collider.tag;
            distanceToPlayer = hit.distance;
            //Debug.Log("Distance: " + hit.distance);
            if (hit.distance <= stopDistance && hit.collider.CompareTag("Player"))
            {
                enemy.currentState = "Battle";
                enemy.inBattle = true;
                Debug.Log("Attack Player");
            }
            else
            {
                enemy.inBattle = false;
            }
        }
    }


    private void OnDrawGizmos()
    {
        Debug.DrawRay(transform.position, Vector2.left * laserLength, Color.green);
    }
}
