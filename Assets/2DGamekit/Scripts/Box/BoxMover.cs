using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    private Vector2 m_vector;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_vector = new Vector2(0,0);
    }

    void FixedUpdate()
    {
        m_Rigidbody.AddForce(m_vector);
    }

    public void AddVerticalForce(float force)
    {
        m_vector = new Vector2(m_vector.x, force);
    }

    public void AddHorizontalForce(float force)
    {
        m_vector = new Vector2(force, m_vector.y);
    }

}
