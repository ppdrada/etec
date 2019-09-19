// this constant won't change.  It's the pin number
// of the sensor's output:
const int echoPin0 = 3;
const int ledPin13 = 13;
const int trigPin0 = 2;

void setup() {
  // initialize serial communication:
  pinMode(ledPin13, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  if(getDistance(echoPin0,trigPin0) < 60 ){
    digitalWrite(ledPin13, HIGH);
    Serial.print("Luz!");
  }else{
    digitalWrite(ledPin13, LOW);
    Serial.print("Sem Luz!");
  }
  
//  Serial.print(getDistance(echoPin1,trigPin1));
//  Serial.print("-");
//  Serial.print(getDistance(echoPin2,trigPin2));
//  Serial.print("-");
//  Serial.print(getDistance(echoPin3,trigPin3));
//  Serial.print("-");
//  Serial.print(getDistance(echoPin4,trigPin4));
  Serial.println();
}

long getDistance(int pinNumber, int triggerPin){
  
  long duration;
  
  delay(1);
  
  //Ativa os sensores
  pinMode(triggerPin, OUTPUT);
  digitalWrite(triggerPin, LOW);
  delayMicroseconds(10);
  digitalWrite(triggerPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(triggerPin, LOW);
  
  pinMode(pinNumber, INPUT);
  duration = pulseIn(pinNumber, HIGH);
  
  return microsecondsToCentimeters(duration);
}

long microsecondsToCentimeters(long microseconds)
{
  // The speed of sound is 340 m/s or 29 microseconds per centimeter.
  // The ping travels out and back, so to find the distance of the
  // object we take half of the distance travelled.
  return microseconds / 29 / 2;
}
