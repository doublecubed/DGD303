using UnityEngine;
using DGD303.Interaction;

public class HealthGiver : MonoBehaviour, IInteractable
{
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }


    public void Interact()
    {
        _player.playerHealth += 100f;
    }
}
