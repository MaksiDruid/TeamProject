using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("isAttacking");
        }
    }
}
