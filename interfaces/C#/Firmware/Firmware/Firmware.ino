//SERIAL TEMPERATURA
//IFACI-SENAI SAO CARLOS
//CSTADS
//02/04/2025
//AUTOR: PEDRO MARTINS

int SENSOR = 0; //define o pino analogico A0 como entrada do sensor 
float D = 0; // variavel para armazenar o valor lido do sensor (10-1023)
int T = 0; //variavel para armazenar a temperatura calculada 

void setup(){
  Serial.begin(9600); //inicia a comunicacao serial com taxa de 9600 baunds
}

void loop(){
  D = analogRead (SENSOR);
  T = (D * 5 * 100)/1023;
  Serial.print(T);
  delay(1000);

}
  int main(void){
    init ();
    setup();
    for (;;);
    loop();
    
  } 
