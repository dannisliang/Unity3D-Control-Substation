#pragma strict

function Start () {

}

function Update () {

if(transform.position.z >2.1){
transform.Translate(0,0,-0.05);
print(transform.position.z);
}
}
