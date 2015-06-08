#pragma strict

var speed=5;   
  
//关于鼠标滑轮的参数  
var MouseWheelSensitivity = 0.0001f;   
var MouseZoomMin = -2.4f;   
var MouseZoomMax = 1.0f;  
var normalDistance = -1.1;   
  
//水平和垂直的移动速度  
var horizontalMoveSpeed = 0.1;   
var verticalMoveSpeed = 0.1;   
  
//上左下右的标记  
var topTag = 8;   
var leftTag = 4;   
var botTag = 2;   
var rightTag = 1;  
  
function Start () {  
      
}  
  
function Update () {  
      
    //获取cursor坐标  
    var msPos = Input.mousePosition;  
      
    //边界最小值  
    var widthBorder = Screen.width/50;   
    var heightBorder = Screen.height/50;   
      
    var x = 0.0f;   
    var y = 0.0f;   
      
    //当前鼠标位置标记  
    var posTag = 0;   
      
    if(widthBorder<=msPos.x && msPos.x<=Screen.width-widthBorder &&  
        heightBorder<=msPos.y && msPos.y<=Screen.height-heightBorder)  
    {  
        transform.Translate(x,y,y);   
        Debug.Log("asd"+msPos.x+" "+msPos.y);  
    }  
    else   
    {  
    //  posTag  
    //  
    // 1100 | 1000 | 1001  
    // 0100 | 0000 | 0001  
    // 0110 | 0010 | 0011  
    //  
    // 12   |  8   |  9  
    // 4    |  0   |  1  
    // 6    |  2   |  3  
    //  
        if(msPos.y>Screen.height-heightBorder)  
            posTag = posTag | topTag;   
        if(msPos.x<widthBorder)  
            posTag = posTag | leftTag;  
        if(msPos.y<heightBorder)   
            posTag = posTag | botTag;  
        if(msPos.x>Screen.width-widthBorder)  
            posTag = posTag | rightTag;  
              
        switch(posTag)  
        {  
        case 0: break;   
        case 1: x = horizontalMoveSpeed; break;   
        case 2: y = -verticalMoveSpeed; break;   
        case 3: x = horizontalMoveSpeed; y = -verticalMoveSpeed; break;   
        case 4: x = -horizontalMoveSpeed; break;  
        case 6: x = -horizontalMoveSpeed; y = -verticalMoveSpeed; break;  
        case 8: y = verticalMoveSpeed; break;  
        case 9: x = horizontalMoveSpeed; y = verticalMoveSpeed; break;  
        case 12:x = -horizontalMoveSpeed;y = verticalMoveSpeed; break;  
        default: break;   
        }  
          
        x *= speed*Time.deltaTime;  
        y *= speed*Time.deltaTime;  
          
        //  
        transform.Translate(x, y, y);   
    }  
          
      
}  