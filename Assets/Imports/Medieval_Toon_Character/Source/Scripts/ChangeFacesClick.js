#pragma strict
var faceAnimations:PlayFaceAnimations;
var totalEyeExpressions:int=7;
var totalMouthExpressions:int=7;
function Start () {
	faceAnimations=gameObject.GetComponent(PlayFaceAnimations);
}

function Update () {
	if (Input.GetKeyDown(KeyCode.R)){
		if (faceAnimations.Eye < totalEyeExpressions) faceAnimations.Eye+=1;
		else faceAnimations.Eye=0;
	}

	if (Input.GetKeyDown(KeyCode.Q)){
	    if (faceAnimations.Eye > 0) faceAnimations.Eye-=1;
	    else faceAnimations.Eye=totalEyeExpressions;
	}
	//if (Input.GetMouseButtonDown(1)){
	//	if (faceAnimations.Mouth < totalMouthExpressions) faceAnimations.Mouth+=1;
	//	else faceAnimations.Mouth=0;
	//}
}