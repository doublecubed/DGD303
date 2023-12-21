using UnityEngine;

namespace DGD303.Interaction
{
    public class Interactable : MonoBehaviour
    {
        #region REFERENCES

        private Player _player;

        #endregion

        #region MONOBEHAVIOUR

        private void Start()
        {
            _player = FindObjectOfType<Player>();
        }

        #endregion

        public void Interact()
        {
            _player.playerHealth += 50;
            Debug.Log("Thank you for interacting with me");
        }
    }
}