using UnityEngine;

public class GuardQuest : MonoBehaviour
{
    [SerializeField] int questReward;
    private bool isComplete;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isComplete == false)
        {
            isComplete = true;
            GameManager.Instance.ChangeCoinsCount(questReward);
        }
    }
}
