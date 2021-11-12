using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTouch : MonoBehaviour
{
    string btnName;
    public Transform lever1,lever2;
    public Animator ball;
    bool b_lever1, b_lever2;

void Start(){
    b_lever1 = false;
    b_lever2 = false;
}

 // Update is called once per frame
 void Update () {
    //  if(Input.GetMouseButtonDown(0)){
    //         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
  if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began ){
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                print(btnName);
                switch (btnName)
                {
                    case "Border_lever1":
                        b_lever1 = b_lever1 ^ true;
                        lever1.Rotate(0,180,0);
                        break;
                    case "Border_lever2":
                        b_lever2 = b_lever2 ^ true;
                        lever2.Rotate(0,180,0);
                        break;
                    case "Border_button":
                        if(b_lever1 && b_lever2){
                            ball.SetTrigger("button_on");
                        }
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}
