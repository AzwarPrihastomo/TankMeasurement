
/*-----( Import needed libraries )-----*/
#include <SoftwareSerial.h>
/*-----( Declare Constants and Pin Numbers )-----*/
#define SSerialRX        10  //Serial Receive pin
#define SSerialTX        11  //Serial Transmit pin

#define SSerialTxControl 3   //RS485 Direction control

#define RS485Transmit    HIGH
#define RS485Receive     LOW

#define Pin13LED         13


/*-----( Declare objects )-----*/
SoftwareSerial RS485Serial(SSerialRX, SSerialTX); // RX, TX

/*-----( Declare Variables )-----*/
// setup Serial input string
String inputstring = "";
boolean stringComplete = false;

String inputstring1 = "";
boolean stringComplete1 = false;

int test;

int byteReceived;
int byteSend;


void setup()   /****** SETUP: RUNS ONCE ******/
{
  // Start the built-in serial port, probably to Serial Monitor
  Serial.begin(9600); 
  RS485Serial.begin(9600);   // set the data rate 
  
  pinMode(Pin13LED, OUTPUT);   
  pinMode(SSerialTxControl, OUTPUT);    
  
  digitalWrite(SSerialTxControl, RS485Receive);  // Init Transceiver   
  
  // Start the software serial port, to another device


}//--(end setup )---


void loop()   /****** LOOP: RUNS CONSTANTLY ******/
{
  serialEvent();
  serialEvent1();
  if (stringComplete == true)
   {
     //respond
     //----------------------------------------------------------------------
     digitalWrite(SSerialTxControl, RS485Transmit);  // Enable RS485 Transmit
     delay(10);
     RS485Serial.print(inputstring);
     delay(100);
     digitalWrite(SSerialTxControl, RS485Receive);  // Disable RS485 Transmit
      //---------------------------------------------------------------------
     //clean up
     inputstring = "";
     stringComplete = false;
   }

   if (stringComplete1 == true)
   { 
     Serial.print(inputstring1);
     inputstring1 = "";
     stringComplete1 = false;
   }  
}

//serial event 0
void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    // add it to the inputString:
    inputstring += inChar;
    // if the incoming character is a newline, set a flag
     // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete = true;
    }
  }
}

//serial event 1
void serialEvent1() {
  while (RS485Serial.available()) {
    // get the new byte:
    char inChar = (char)RS485Serial.read();
    // add it to the inputString:
    inputstring1 += inChar;
    // if the incoming character is a newline, set a flag
     // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete1 = true;
    }
  }
}
