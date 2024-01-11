using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCombat : MonoBehaviour
{
    #region REFERENCES

    private CharacterAnimator _animator;

    #endregion

    #region MONOBEHAVIOUR

    private void Awake()
    {
        _animator = GetComponent<CharacterAnimator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.Throw();
        }
    }

    #endregion
}
