#include <Servo.h>

Servo myservo;  // cria um objeto do tipo servo para controlar o servo motor.
// doze objetos servo podem ser criados na maioria das placas.

int pos = 0;    // variável que guarda a posição do servo.

void setup() {
  myservo.attach(9);  // anexa o servo no pino 9 para o objeto servo.
  myservo.write(pos); // diz ao servo para ir a posição guardada na variável "pos" que é 0 no início do programa.
  Serial.begin(9600); // define a taxa de dados em bits por segundo (baud) para transmissão de dados serial.
}

void loop() {
  
  while(Serial.available() > 0)                // loop que dura enquanto existem bytes para serem lidos.
  {
    int number = Serial.readString().toInt();  // lê e os bytes disponíveis e retorna uma string que logo após é convertida para int. 
    Serial.println(number);                    // escreve o número recebido no monitor serial.
    irpara(number);                            // chama o método irpara que move o servo para o ângulo passado nos parametros.
  }
  
}

//método que move o servo até o angulo passado como parametro.
void irpara(int angulo){

  if(angulo > pos)                      // se o ângulo desejado é maior que o ângulo atual do servo...   
  {                
    for (pos; pos < angulo; pos += 1) { // vai do ângulo atual do servo até o ângulo desejado no sentido anti-horário de 1 em 1. 
                                        
      myservo.write(pos);               // diz ao servo para ir para a posição na variável 'pos'.
      delay(10);                        // espera 10ms para o servo chegar até a posição.
    }
  }
  else                                  // se o ângulo desejado é menor que o ângulo atual do servo... 
  {
    for (pos; pos > angulo; pos -= 1) { // vai do ângulo atual do servo até o ângulo desejado no sentido horário de 1 em 1.
      
      myservo.write(pos);               // diz ao servo para ir para a posição na variável 'pos'.
      delay(10);                        // espera 10ms para o servo chegar até a posição.
    }
  }
}

