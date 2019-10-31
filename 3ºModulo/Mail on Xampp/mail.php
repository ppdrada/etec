<?php
$assunto = $_POST['mensagem'];
$corpo = "
Assnto: ".$_POST['mensagem']."
Email: ".$_POST['email']."

";

mail('pedrolopesdesouza51@gmail.com', $assunto, $corpo, 'from:pedrolopesdesouza15@gmail.com');
echo 'Seus dados foram enviados com sucesso';


// Configure sendmail on xampp
//------------------------------------------------------
// php.ini file

//SMTP=smtp.gmail.com
//smtp_port=587
//sendmail_from = mail@gmail.com
//sendmail_path = "\"C:\xampp\sendmail\sendmail.exe\" -t"
//-----------------------------------------------------
//sendmail.ini file
//
//smtp_server=smtp.gmail.com
//smtp_port=587
//error_logfile=error.log
//debug_logfile=debug.log
//auth_username=mail@gmail.com
//auth_password=yourpassword
//force_sender=mail@gmail.com
//-----------------------------------------------------
//PHP file code
//
//"angle bracket open"?php
////the subject
//$sub = "Your subject";
////the message
//$msg = "Your message";
////recipient email here
//$rec = "example@gmail.com";
////send email
//mail($rec,$sub,$msg);
//"angle bracket open"
//

?>