using UnityEngine;
using DGD303.Interaction;

public class EnergyGiver : MonoBehaviour, IInteractable 
{
    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }


    public void Interact()
    {
        _player.playerEnergy += 100f;
    }
}
