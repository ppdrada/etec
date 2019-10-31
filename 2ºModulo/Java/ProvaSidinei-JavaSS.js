function temp(esc1,esc2,valor) 
{ 
parseFloat(valor); 

if(esc1 == 'C' && esc2 == 'K') // De C para K 
{ 
var ckvalor = parseFloa(valor) + parseFloat(273.15); 
return ckvalor.toFixed(2); 
} 
if(esc1 == 'c' && esc2 == 'k') //c k 
{ 
var ckvalor = parseFloat(valor) + parseFloat(273.15); 
return ckvalor.toFixed(2); 
} 


if( esc1 == 'K' && esc2 == 'C')// De K para C 
{ 
var kcvalor = parseFloat(valor) - parseFloat(273.15); 
return kcvalor.toFixed(2); 
} 
if( esc1 =='k' && esc2 == 'c')// k c 
{ 
var kcvalor = parseFloat(valor) - parseFloat(273.15); 
return kcvalor.toFixed(2); 
} 


if(esc1 == 'C' && esc2 == 'F')// De C para F 
{ 
var cfvalor = ((9*valor)/5)+32; 
return cfvalor.toFixed(2); 
} 
if(esc1 == 'c' && esc2 == 'f')//c f 
{ 
var cfvalor = ((9*valor)/5)+32; 
return cfvalor.toFixed(2); 
} 


if(esc1 == 'F' && esc2 == 'C')// De F para C 
{ 
var fcvalor = 5*((valor-32)/9); 
return fcvalor.toFixed(2); 
} 
if(esc1 == 'f' && esc2 =='c')// f c 
{ 
var fcvalor = 5*((valor-32)/9); 
return fcvalor.toFixed(2); 
} 


if(esc1 == 'K' && esc2 == 'F')// De K para F 
{ 
var kf = parseFloat(valor) - parseFloat(273.15); 
var kfvalor = parseFloat((kf*1.8) + 32); 
return kfvalor.toFixed(2); 
} 
if(esc1 =='k' && esc2 == 'f')// k f 
{ 
var kf = parseFloat(valor) - parseFloat(273.15); 
var kfvalor = parseFloat((kf*1.8) + 32); 
return kfvalor.toFixed(2); 
} 


if(esc1 == 'F' && esc2 == 'K')// De F para K 
{ 
var fkvalor = ((valor-32)/1.8) + 273.15; 
return fkvalor.toFixed(2); 
} 
if(esc1 == 'f' && esc2 == 'k')// f k 
{ 
var fkvalor = ((valor-32)/1.8) + 273.15; 
return fkvalor.toFixed(2); 
} 
return false; 

}

