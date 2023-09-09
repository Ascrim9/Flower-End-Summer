using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace FlowerEndSummer
{
    public class ObserverTest : MonoBehaviour
    {
        [SerializeField] public EventBase eventbase;

        private void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("ObjserverTest");
            }
        }
    }
}