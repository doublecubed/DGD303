using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class CharacterAnimator : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponentInChildren<Animator>();
    }

    public void Walk(float input)
    {
        _animator.SetBool("walking", input != 0);
        _animator.SetFloat("walkDirection", input > 0 ? 1f : -1f);
    }

    public void Die()
    {
        _animator.SetTrigger("die");
    }

    public void Throw()
    {
        _animator.SetTrigger("throw");
    }
}
