int incomingByte;
int pinLed = 3;
String message = "";

void setup() {
  // put your setup code here, to run once:
  Serial.begin(2400);
}

void loop() {
  // put your main code here, to run repeatedly:
  // send data only when you receive data:
  if (Serial.available() > 0) {
    // read the incoming byte:
    incomingByte = (char)Serial.read();
    // say what you got:
    Serial.print("I received: ");
    Serial.println(incomingByte, DEC);

    if(incomingByte == 49){
      digitalWrite(pinLed, HIGH);
    }

    if(incomingByte == 48){
      digitalWrite(pinLed, LOW);
    }

    if(incomingByte == 32){
      message += " ";
    }

    if(incomingByte == 46){
      message += ".";
    }

    if(incomingByte == 45){
      message += "-";
    }

    if(incomingByte == 47){
      message += "/";
    }
    
  }

  Serial.print(message);
  
}
