/* Setting */

// Communicaton
#define baudRate 9600
#define inBufferSize 50

// Pins
#define speedPin 5
#define revolutionPin 6
#define fuelPin 10
#define temperaturePin 11

// Range of values
#define speedMaxRange 240
#define revolutionsMaxRange 7000
#define fuelMaxRange 100
#define temperatureMaxRange 100

// Range of blink
#define blinkMaxVal 5
#define blinkMinVal 500

/* Strings */

char stringSpeed = 'S';
char stringRevolutions = 'R';
char stringFuel = 'F';
char stringTemperature = 'T';
String inMessage;

/* Speeds */
int speedDelay = 0;
int revolutionsDelay = 0;
int fuelDelay = 0;
int temperatureDelay = 0;

/* Values */

int inValue = 0;
int pwmValue = 0;
long blinkDelay = 0;
bool inComplete = false;

/* Setup before start */
void setup() {

	// Pin mode
	pinMode(speedPin, OUTPUT);
	pinMode(revolutionPin, OUTPUT);
	pinMode(fuelPin, OUTPUT);
	pinMode(temperaturePin, OUTPUT);

	// Allocation
	inMessage.reserve(inBufferSize);

	// Start communication
	Serial.begin(baudRate);
	Serial.println("Connected!");
}

/* Main program loop */
void loop() {

	// Control dashboard
	blink(speedPin);

	// When values changed
	if (inComplete && inMessage.length() != 0) {

		// Process incoming data
		inValue = inMessage.substring(1, inMessage.length()).toInt();  // Get value

		// Show data for function
		if (inMessage.charAt(0) == stringSpeed) setBlinkValue();
		
		/*if (inMessage.charAt(0) == stringSpeed) setPinValue(speedPin, speedMaxRange);
		else if (inMessage.charAt(0) == stringRevolutions) setPinValue(revolutionPin, revolutionsMaxRange);
		else if (inMessage.charAt(0) == stringFuel) setPinValue(fuelPin, fuelMaxRange);
		else if (inMessage.charAt(0) == stringTemperature) setPinValue(temperaturePin, temperatureMaxRange);*/

		// Flag message processed
		inMessage = "";
		inComplete = false;
	}
}

/* Set speed for selected pin in selected range*/
void setPinValue(int pin, int maxRange) {
	pwmValue = map(inValue, 0, maxRange, 0, 255);  // Map value from clock range to PWM range
	analogWrite(pin, pwmValue);  // Write value
	Serial.println(pwmValue);
}

double a;
double b;

/* TESTING */
void setBlinkValue() {                     
	/*
	if (inValue > 120) blinkDelay = 2;
	else blinkDelay = 150;
	*/
	a = inValue;
	b = (1 / a) * 1000;
	blinkDelay = (long)b;

	Serial.println(inValue);
	Serial.println(blinkDelay);
	Serial.println();
}

/* TESTING */
void blink(int pin) {
	digitalWrite(pin, HIGH);
	delay(1);
	digitalWrite(pin, LOW);
	delay(blinkDelay);
}

/* Serial interrput */
void serialEvent() {
	while (Serial.available()) {
		char inChar = (char)Serial.read();
		inMessage += inChar;
		if (inChar == '\n') {
			inMessage.trim();
			inComplete = true;
		}
	}
}
