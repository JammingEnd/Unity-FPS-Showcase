using UnityEngine;

[CreateAssetMenu(fileName = "new Gun", menuName = "Guns/Gun")]
public class Gun : ScriptableObject
{
    public string gunName;
    public GameObject gunPrefab;

    [Header("Stats")] public int minimunDamage;
    public int maximumDamage;
    public float maximumRange;

    public virtual void OnLeftMouseDown(Transform cameraPos)
    {
    }

    public virtual void OnLeftMouseHold(Transform cameraPos)
    {
    }
    public virtual void OnRightMouseDown() { }

    protected void Fire(Transform cameraPos)
    {
        RaycastHit whatIHit;
        if (Physics.Raycast(cameraPos.position, cameraPos.transform.forward, out whatIHit, Mathf.Infinity))
        {
            Idamageable damageable = whatIHit.collider.GetComponent<Idamageable>();
            if (damageable != null)
            {
                float normalizedDistance = whatIHit.distance / maximumRange;
                if (normalizedDistance <= 1)
                {
                    damageable.DealDamage(Mathf.RoundToInt(Mathf.Lerp(maximumDamage, minimunDamage, normalizedDistance)));
                }
            }
        }
    }
    
}