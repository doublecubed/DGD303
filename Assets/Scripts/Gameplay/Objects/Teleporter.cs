using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DGD303.Interaction;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour, IInteractable
{
    public string TargetLevelName;

    public void Interact()
    {
        SceneManager.LoadScene(TargetLevelName);
    }
}
