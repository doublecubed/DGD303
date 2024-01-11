using UnityEngine;
using DGD303.Interaction;

public class EnergyGiver : MonoBehaviour, IInteractable 
{
    public float energyValue;

    private Player _player;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }


    public void Interact()
    {
        _player.UpdateEnergy(energyValue);
    }
}
