/* Setting */

// Pins
#define speedPin 5
#define revolutionPin 6

// Communicaton
#define baudRate 9600
#define inBufferSize 200

/* Strings */

char stringSpeed = 'S';
char stringRevolutions = 'R';
String inMessage;

/* Delays */

int speedDelay = 0;
int revolutionsDelay = 0;

/* Values */

long inValue = 0;
bool inComplete = false;

/* Setup before start */
void setup() {

	// Pin mode
	pinMode(speedPin, OUTPUT);
	pinMode(revolutionPin, OUTPUT);

	// Allocation
	inMessage.reserve(inBufferSize);

	// Start communication
	Serial.begin(baudRate);
	//Serial.println("Connected!");
}

/* Main program loop */
void loop() {

	// Control dashboard
	//setClockValue(speedPin, speedDelay);
	setClockValue(revolutionPin, revolutionsDelay);

	// When values changed
	if (inComplete && inMessage.length() != 0) {

		// Process incoming data
		inValue = inMessage.substring(1, inMessage.length()).toInt();  // Get value

		// Show data for function
		if (inMessage.charAt(0) == stringSpeed) speedDelay = inValue;
		else if (inMessage.charAt(0) == stringRevolutions) revolutionsDelay = inValue;

		// Flag message processed
		inMessage = "";
		inComplete = false;
	}
}

/* Set value for selected clock */
void setClockValue(int pin, int delayValue) {

	// Do impuls for one second
	digitalWrite(pin, HIGH);
	delay(1);
	digitalWrite(pin, LOW);

	// Wait selected interval (to show selected value)
	// If is here because limitations of delayMicroseconds()
	if (delayValue < 16300) delayMicroseconds(delayValue);  // Microseconds
	else delay(delayValue / 1000);  // Miliseconds
}

/* Read from serial (serial interrput) */
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
