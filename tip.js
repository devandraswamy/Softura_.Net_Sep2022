const compute=()=>{
    let tot=document.getElementById("bill").value;
    let tip=document.getElementById("tip").value;

    let tottip=((tot/100)*tip)


    document.getElementById("op").innerHTML="the total bill amount is"+tot+" And The Tip amout is"+tottip;

}