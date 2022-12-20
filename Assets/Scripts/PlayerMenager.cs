using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMenager : MonoBehaviour
{
    private Transform Player2;
    private Vector3 startMousePos, startPlayerPos;
    private bool moveThePlayer;
    // [Range(0f,1f)] public float maxSpeed;
    private float velocity;
    private float maxSpeed;
    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        Player2 = transform;
        maxSpeed = 0.05f;


    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            moveThePlayer = true;

            Plane newPlan = new Plane(Vector3.up, 0f);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (newPlan.Raycast(ray, out var distance))
            {
                startMousePos = ray.GetPoint(distance);
                startPlayerPos = Player2.position;
            }

        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveThePlayer = false;
        }

        if (moveThePlayer)
        {
            Plane newPlan = new Plane(Vector3.up, 0f);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (newPlan.Raycast(ray, out var distance))
            {
                Vector3 mouseNewPos = ray.GetPoint(distance);
                Vector3 MouseNewPos = mouseNewPos - startMousePos;
                Vector3 DesirePlayerPos = MouseNewPos + startPlayerPos;

                DesirePlayerPos.x = Mathf.Clamp(DesirePlayerPos.x, -4.5f, 4.5f);
                DesirePlayerPos.z = Mathf.Clamp(DesirePlayerPos.z, Player2.position.z, float.MaxValue);



                Player2.position = new Vector3(Mathf.SmoothDamp(Player2.position.x, DesirePlayerPos.x, ref velocity, maxSpeed), Player2.position.y, Mathf.MoveTowards(Player2.position.z, DesirePlayerPos.z, maxSpeed));
            }
        }



    }


   
}
