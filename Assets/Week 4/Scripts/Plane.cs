using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Plane : MonoBehaviour
{
    public List<Vector2> points;
    public float newPointThreshold = 0.2f;
    Vector2 lastPos;
    LineRenderer lineRenderer;
    Vector2 currentPos;
    Rigidbody2D rb2D;
    public float speed = 1;
    public AnimationCurve landing;
    float landingtimer;

   void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        rb2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        currentPos = transform.position;
        if (points.Count > 0 )
        {
            Vector2 direction = points [0] - currentPos;
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            rb2D.rotation = -angle;
        }
        rb2D.MovePosition(rb2D.position + (Vector2)transform.up * speed * Time.deltaTime);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            landingtimer += 0.5f * Time.deltaTime;
            float interpolation = landing.Evaluate(landingtimer);
            if (transform.localScale.z < 0.1f)
            {
                Destroy(gameObject);
            }
            transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, interpolation);
        }
        {
            
        }
        lineRenderer.SetPosition(0, transform.position);
        if (points.Count > 0 )
        {
            if(Vector2.Distance(currentPos, points[0]) < newPointThreshold)
            {
                points.RemoveAt(0);

                for (int i = 0; i < lineRenderer.positionCount - 2; i++)
                {
                    lineRenderer.SetPosition(i, lineRenderer.GetPosition(i + 1));
                }
                if(lineRenderer.positionCount != 0 )
                {
                    lineRenderer.positionCount--;
                }
               
            }
        }
    }
   void OnMouseDown()
    {
        points = new List<Vector2>();
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        points.Add(newPosition);
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
    }
    void OnMouseDrag()
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Vector2.Distance(lastPos, newPosition) > newPointThreshold)
        {
            points.Add(newPosition);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition(lineRenderer.positionCount - 1, newPosition);
            lastPos = newPosition;
        }

    }
}
