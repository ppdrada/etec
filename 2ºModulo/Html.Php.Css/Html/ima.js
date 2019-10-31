function fnZonear()
{
	var imgs = document.getElementsByTagName('img'), nCont = 0;
	for(nCont; nCont < 9; nCont++)
	{
		imgs[nCont].style.left = parseInt(Math.random() * 1000) + 'px';
		imgs[nCont].style.top = parseInt(Math.random() * 450)  + 'px';
	} 
}
function fnPega(oEvento){
	//Salert("Solta essa porra");
}