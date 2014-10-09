#pragma strict

private var hit : RaycastHit;
private var ray : Ray;
 
function FixedUpdate () {
 
    if(iPhoneInput.touchCount == 1) {
        ray = Camera.main.ScreenPointToRay(iPhoneInput.touches[0].position);
        Debug.DrawLine(ray.origin,ray.direction * 10);
        if(Physics.Raycast(ray.origin, ray.direction * 10,hit)&&hit.transform.name == "Roller Coaster"){
  Debug.Log("hit");
        Application.LoadLevel("rollercoaster2");
        }
    }
}