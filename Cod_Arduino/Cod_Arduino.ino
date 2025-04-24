#include "DHT.h"
#define DHTPIN 4
#define DHTTYPE DHT11

DHT dht(DHTPIN, DHTTYPE);

const int pinPotenciometro = A0;
#define pinLed  13

float valuePotenciometro = 0;
float temperatura, umidade;

char dataReceivedSerial = "";

void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(pinLed,OUTPUT);
  
}

void loop() {
  temperatura = dht.readTemperature();
  umidade = dht.readHumidity();

  valuePotenciometro = analogRead(pinPotenciometro);

  Serial.print(valuePotenciometro * (5.0 / 1023.0));
  Serial.print("/");
  Serial.println(temperatura);

  if (Serial.available() > 0) {
    dataReceivedSerial = Serial.read();
    if (dataReceivedSerial == '8') {
      digitalWrite(pinLed, HIGH);
      Serial.println("LED Ativado");
    } else if (dataReceivedSerial == '9') {
      digitalWrite(pinLed, LOW);
      Serial.println("LED Desativado");
    }
  }

  delay(1000);
}