using UnityEngine;
using UnityEngine.UI;

namespace DGD303.Interaction
{
    public class Interactor : MonoBehaviour
    {
        #region REFERENCES

        private UIManager _uiManager;

        #endregion

        #region VARIABLES

        private bool _canInteract;
        private IInteractable _currentInteractable;

        #endregion

        #region MONOBEHAVIOUR

        private void Start()
        {
            _uiManager = UIManager.Instance;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out IInteractable interactable))
            {
                _canInteract = true;
                _currentInteractable = interactable;
                _uiManager.DisplayInteractionIndicator(true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            _canInteract = false;
            _currentInteractable = null;
            _uiManager.DisplayInteractionIndicator(false);
        }

        private void Update()
        {
            if (_canInteract && Input.GetKeyDown(KeyCode.E))
            {
                InteractWithObject(_currentInteractable);
            }
        }

        #endregion

        #region METHODS

        private void InteractWithObject(IInteractable targetObject)
        {
            targetObject.Interact();
        }

        #endregion
    }
}