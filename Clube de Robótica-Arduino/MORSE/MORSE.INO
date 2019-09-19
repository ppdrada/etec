int pinLed = 3;
int pinLed2 = 11;
String message = "sos";
String morseMessage;

int incomingByte = 0;

void setup() {
  
  pinMode(pinLed, OUTPUT);
  Serial.begin(2400);

  message.toUpperCase();

  for(int i = 0; i < message.length(); i++){
    
      String letra;
      letra = letraCodificada(message.charAt(i));
      morseMessage += letra; 
         
  }

  Serial.print(morseMessage); 

  for(int i = 0; i < morseMessage.length(); i++){

    if(morseMessage.charAt(i) == '.'){
      Serial.print("ponto");
      //digitalWrite(pinLed, HIGH);
      analogWrite(pinLed, 10);
      delay(200);
      //digitalWrite(pinLed, LOW);
      analogWrite(pinLed, 0);
      delay(200);
    } else {

      if(morseMessage.charAt(i) == '-'){
        Serial.print("TRAÇO");
        //digitalWrite(pinLed2, HIGH);
        analogWrite(pinLed, 255);
        delay(200);
        //digitalWrite(pinLed2, LOW);
        analogWrite(pinLed, 0);
        delay(200);
      } else {

        Serial.print("ESPAÇO");
        delay(300);
        
      }
      
    }
    
  }
 
}

void loop() {
    
    // send data only when you receive data:
        if (Serial.available() > 0) {
                // read the incoming byte:
                incomingByte = Serial.read();

                // say what you got:
                Serial.print("I received: ");
                Serial.println(incomingByte, DEC);

                if(incomingByte == 48){
                  digitalWrite(pinLed, HIGH);
                }

                if(incomingByte == 49){
                  digitalWrite(pinLed, LOW);
                }

                delay(500);
                
        }
  
  
}

String letraCodificada(char letra){

  switch(letra){
    
     case 'A':
      return ".-";
    break;

     case 'B':
      return "-...";
    break;

     case 'C':
      return "-.-.";
    break;

     case 'D':
      return "-..";
    break;

     case 'E':
      return ".";
    break;

     case 'F':
      return "..-.";
    break;

     case 'G':
      return "--.";
    break;

     case 'H':
      return "....";
    break;

     case 'I':
      return "..";
    break;

     case 'J':
      return ".---";
    break;

     case 'K':
      return "-.-";
    break;

     case 'L':
      return ".-..";
    break;

     case 'M':
      return "--";
    break;

     case 'N':
      return "-.";
    break;

     case 'O':
      return "---";
    break;

     case 'P':
      return ".--.";
    break;

     case 'Q':
      return "--.-";
    break;

     case 'R':
      return ".-.";
    break;

     case 'S':
      return "...";
    break;

     case 'T':
      return "-";
    break;

     case 'U':
      return "..-";
    break;

     case 'V':
      return "...-";
    break;

     case 'W':
      return ".--";
    break;

     case 'X':
      return "-..-";
    break;

     case 'Y':
      return "-.--";
    break;

     case 'Z':
      return "--..";
    break;

    default:
      return "@";

  }
}


