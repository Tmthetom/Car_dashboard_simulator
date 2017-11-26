/* Setting */

// Communicaton
#define baudRate 9600
#define inBufferSize 50

// Pins (PWM)
#define speedPin 5
#define revolutionPin 6
#define fuelPin 10
#define temperaturePin 11

// Range of values
#define speedMaxRange 240
#define revolutionMaxRange 7000
#define fuelMaxRange 100
#define temperatureMaxRange 100

/* Strings */

char stringSpeed = 'S';
char stringRevolutions = 'R';
char stringFuel = 'F';
char stringTemperature = 'T';
String inMessage;

/* Values */

int inValue = 0;
int pwmValue = 0;
bool inComplete = false;

/* Setup before start */
void setup() {

	// Allocation
	inMessage.reserve(inBufferSize);

	// Start communication
	Serial.begin(baudRate);
	Serial.println("Connected!");
}

/* Main program loop */
void loop() {
	if (inComplete && inMessage.length() != 0) {

		// Process incoming data
		inValue = inMessage.substring(1, inMessage.length()).toInt();  // Get value

		// Show data for function
		if (inMessage.charAt(0) == stringSpeed) setPinValue(speedPin, speedMaxRange);
		else if (inMessage.charAt(0) == stringRevolutions) setPinValue(revolutionPin, revolutionMaxRange);
		else if (inMessage.charAt(0) == stringFuel) setPinValue(fuelPin, fuelMaxRange);
		else if (inMessage.charAt(0) == stringTemperature) setPinValue(temperaturePin, temperatureMaxRange);

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
