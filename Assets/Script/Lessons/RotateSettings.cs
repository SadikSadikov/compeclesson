using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    [CreateAssetMenu(menuName ="Lessons/Lesson1/Rotate Setings")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 50;
        public float Speed { get { return _speed; } }


    }
}
