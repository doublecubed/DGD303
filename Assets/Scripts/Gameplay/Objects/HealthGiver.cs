using UnityEngine;
using DGD303.Interaction;

public class HealthGiver : MonoBehaviour, IInteractable
{
    public float healthValue;
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }


    public void Interact()
    {
        _player.UpdateHealth(healthValue);
    }
}
