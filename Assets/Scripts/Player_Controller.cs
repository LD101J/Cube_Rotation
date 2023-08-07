using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    #region Variables
    private Rigidbody rb;
    [Header("Player_Rotations")]
     [SerializeField][Range(0, 90)] private float rotateX = 90;
     [SerializeField][Range(0, 90)] private float rotateY = 90;
     [SerializeField][Range(0, 90)] private float rotateZ = 90;
    #endregion
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Rotate_Cube();
    }

    private void Rotate_Cube()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, rotateY, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(rotateX, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0, 0, rotateZ);
        }
    }
}
