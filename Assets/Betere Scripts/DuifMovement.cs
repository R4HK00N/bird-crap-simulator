using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class DuifMovement : MonoBehaviour
{
    public GameObject kak;
    public Transform kakSpawn;
    Vector3 kakPosition;

    public CharacterController controller;
    public Transform cam;

    public float turnSmoothTime = 0.1f;

    public float speed = 5f;
    float turnSmoothvelocity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
    }
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothvelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        kakPosition = kakSpawn.position;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(kak, kakPosition, Quaternion.identity);
        }
    }
}
