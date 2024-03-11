using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player.Core.Movement
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] float max_vel;
        [SerializeField] float speed;
        [SerializeField] float turnRate;
        [SerializeField] Transform visual;
        [SerializeField] Rigidbody RB_Player;
        Transform _viewCameraTransform;
        Vector3 _targetDir;
        // Start is called before the first frame update
        void Start()
        {
            _viewCameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
        }

        // Update is called once per frame
        void Update()
        {
            _targetDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
            rotate();
        }

        private void FixedUpdate()
        {
            move();
        }

        void move()
        {
            if (_targetDir != Vector3.zero && RB_Player.velocity.magnitude < max_vel)
            {
                RB_Player.AddForce(visual.forward * speed, ForceMode.Impulse);
            }
        }

        void rotate()
        {
            if (_targetDir != Vector3.zero)
            {
                var camF = _viewCameraTransform.forward; var camR = _viewCameraTransform.right;
                camF.y = 0; camR.y = 0;
                _targetDir = (_targetDir.z * camF) + (_targetDir.x * camR);
                visual.localRotation = Quaternion.Slerp(visual.rotation, Quaternion.LookRotation(_targetDir.normalized, Vector3.up), speed/turnRate);
            }
        }

    }
}
