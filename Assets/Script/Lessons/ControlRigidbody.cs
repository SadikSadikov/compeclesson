﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lessons
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidbodySettings _rigidbodySettings;

        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceKeyDown)
            {
                _rigidbody.AddForce(_rigidbodySettings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
