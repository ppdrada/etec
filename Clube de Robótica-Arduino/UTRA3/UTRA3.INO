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
  Serial.println(soma(4,6));
}

int soma(int x, int y){
  return x + y;
}


