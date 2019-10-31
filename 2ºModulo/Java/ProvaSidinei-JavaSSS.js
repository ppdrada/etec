function max(temp1,temp2) 
{ 
var temp1 = parseFloat(temp1); 
var t1 = temp1.toFixed(2) 

var temp2 = parseFloat(temp2); 
var t2 = temp2.toFixed(2); 

var kc = parseFloat(t1) + parseFloat(273.15); 
var kcc = kc.toFixed(2); 

var ck = parseFloat(t1) - parseFloat(273.15); 
var ckk = ck.toFixed(2); 

var cf = ((9*t1)/5)+32; 
var cff = cf.toFixed(2); 

var fc = 5*((t1-32)/9); 
var fcc = fc.toFixed(2); 

var fk = ((t1 - 32)/1.8) + parseFloat(273.15); 
var fkk = fk.toFixed(2); 

var kf = parseFloat((ck * 1.8) + 32); 
var kff = kf.toFixed(2); 


if(t2 == kcc) 
{ 
var ck2 = parseFloat(t2) - parseFloat(273.15); 
var ckk2 = ck2.toFixed(2); 
if(t1 == ckk2) 
{ 
return "C para K" 
} 
} 
if(t2 == ckk) 
{ 
var kc2 = parseFloat(t2) + parseFloat(273.15); 
var kcc2 = kc2.toFixed(2); 
if(t1 == kcc2) 
{ 
return "K para C"; 
} 
} 
if(t2 == cff) 
{ 
var fc2 = 5*((t2 - 32)/9); 
var fcc2 = fc2.toFixed(2); 
if(t1 == fcc2) 
{ 
return "C para F"; 
} 
} 
if(t2 == fcc) 
{ 
var cf2 = ((9*t2)/5)+32; 
var cff2 = cf2.toFixed(2); 
if(t1 == cff2) 
{ 
return "F para C"; 
} 
} 
if(t2 == fkk) 
{ 
var k = parseFloat(t2) - parseFloat(273.15); 
var kf2 = parseFloat((k * 1.8 ) + 32); 
var kff2 = kf2.toFixed(2); 
if(t1 == kff2) 
{ 
return "F para K"; 
}	

} 
if(t2 == kff) 
{ 
var fk2 = ((t2 -32)/1.8) + parseFloat(273.15); 
var fkk2 = fk2.toFixed(2); 
if(t1 == fkk2) 
{ 
return "K para F"; 
} 

} 


return "Nenhuma conversão"; 
}