const int echodireito = 13;
const int echocentro = 12;
const int echoesquerdo= 11;
const int trigPin0 = 9;

void setup() {
  // put your setup code here, to run once:
  Serial.begin (9600);
    
}

void loop() {
  // put your main code here, to run repeatedly:
  Serial.println(RetornaDistancia(trigPin0,echocentro));
  delay(1000);
}

long RetornaDistancia(int trig , int echo){
  
   pinMode(trig, OUTPUT);
   pinMode(echo, INPUT);
    
   digitalWrite(trig, LOW);
   delayMicroseconds(2);
   digitalWrite(trig, HIGH);
   delayMicroseconds(10);
   digitalWrite(trig, LOW);
   
   long pulso = pulseIn(echo, HIGH);
   long milipulso = 340*pulso/1000000/2;
   return mili