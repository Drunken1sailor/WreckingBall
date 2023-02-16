using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wreckingBall : MonoBehaviour
{
	public HingeJoint movingToBreak;
	public bool odd = true;
	
    public void MoveToDestroy (){
		if(odd){
			if(Input.GetMouseButtonDown(0)){	
				JointSpring temp1 = movingToBreak.spring;
				temp1.targetPosition = -30f;
				movingToBreak.spring = temp1;
				odd = false;
			}
		}
		else if(Input.GetMouseButtonDown(0)){	
			JointSpring temp = movingToBreak.spring;
			temp.targetPosition = 30f;
			movingToBreak.spring = temp;
			odd = true;
		}
	}
}
