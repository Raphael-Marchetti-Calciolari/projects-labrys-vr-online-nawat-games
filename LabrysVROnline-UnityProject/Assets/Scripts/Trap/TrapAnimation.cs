using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAnimation : MonoBehaviour
{
    [SerializeField] private Trap trapReference;
    [SerializeField] private Animation activationAnimation;
    [SerializeField] private Animation deactivationAnimation;

    private void Start()
    {
        trapReference.NotifyTrapActivatedStatusChange += PlayAnimation;
    }

    private void PlayAnimation(bool isActivating)
    {
        var animatorRef = gameObject.GetComponent<Animator>();
        animatorRef.Play(isActivating ? activationAnimation.name : deactivationAnimation.name);
    }
}
