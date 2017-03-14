#pragma strict

public var obj1:Transform;
public var obj2:Transform;
public var obj3:Transform;
public var i=0;
public var n:int;
public var tReal:float; 
public var iTimer = 2.0f;

function Start () {

}

function FixedUpdate () {
	coFunc();
}

function coFunc (){
	iTimer-=Time.deltaTime;
	if(iTimer<=0)
	{
		switch (i) {
		
		case 0:Instantiate(obj1,transform.position,transform.rotation);break;

		case 1:Instantiate(obj2,transform.position,transform.rotation);break;

		case 2:Instantiate(obj3,transform.position,transform.rotation);break;
		}
		i = (i + 1) % n;
		iTimer=tReal;
	}	
}