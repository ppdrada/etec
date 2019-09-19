#include <Servo.h>

Servo myservo;  // create servo object to control a servo
// twelve servo objects can be created on most boards
int pos = 0;

// this constant won't change.  It's the pin number
// of the sensor's output:

const int echoPin0 = 9;
const int ledPin13 = 13;
const int trigPin0 = 8;

void setup() {
  // initialize serial communication:
  pinMode(ledPin13, OUTPUT);
  myservo.attach(5);
  Serial.begin(9600);
}

void loop()
{
  bianca(getDistance(echoPin0, trigPin0));
  Serial.print(getDistance(echoPin0, trigPin0));
  
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

void bianca (long velocidade){
  
  for (pos = 0; pos <= 180; pos += 1) { // goes from 0 degrees to 180 degrees
    // in steps of 1 degree
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(velocidade / 10);                       // waits 15ms for the servo to reach the position
  }
  for (pos = 180; pos >= 0; pos -= 1) { // goes from 180 degrees to 0 degrees
    myservo.write(pos);              // tell servo to go to position in variable 'pos'
    delay(velocidade / 10); 
  }
}

