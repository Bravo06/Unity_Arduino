const int inputPinX = A0;
const int inputPinY = A1;
const int buttonPin = 4;

int buttonState = 0;

void setup() {
  Serial.begin(9600);
  
  pinMode(inputPinX, INPUT);
  pinMode(inputPinY, INPUT);
  pinMode(buttonPin, INPUT);
}

void loop() {
  float xValue = (analogRead(A0) / 1023.0 * 2.0) - 1.0;
  float yValue = (analogRead(A1) / 1023.0 * 2.0) - 1.0;

  buttonState = digitalRead(buttonPin);

  Serial.print(xValue + 0.02);
  Serial.print(",");
  Serial.print(yValue);
  Serial.print(",");
  Serial.println(buttonState);

  delay(1);
}
