
#include <avr/wdt.h>
#define SSerialTxControl0 2   //RS485 Direction control
#define SSerialTxControl1 3   //RS485 Direction control
#define SSerialTxControl2 4   //RS485 Direction control
#define SSerialTxControl3 5   //RS485 Direction control

#define RS485Transmit    HIGH
#define RS485Receive     LOW

#define Pin13LED         13

String inputstring = "";
boolean stringComplete = false;
String inputstring1 = "";
boolean stringComplete1 = false;
String inputstring2 = "";
boolean stringComplete2 = false;
String inputstring3 = "";
boolean stringComplete3 = false;

/*-----( Declare objects )-----*/
//SoftwareSerial RS485Serial(SSerialRX, SSerialTX); // RX, TX

/*-----( Declare Variables )-----*/
int byteReceived;
int byteSend;

void setup()   /****** SETUP: RUNS ONCE ******/
{
  // Start the built-in serial port, probably to Serial Monitor
  Serial.begin(9600);
  Serial1.begin(9600);
  Serial2.begin(9600);
  Serial3.begin(9600);
  
  pinMode(Pin13LED, OUTPUT);   
  pinMode(SSerialTxControl0, OUTPUT);    
  pinMode(SSerialTxControl1, OUTPUT);  
  pinMode(SSerialTxControl2, OUTPUT);  
  pinMode(SSerialTxControl3, OUTPUT);
  digitalWrite(SSerialTxControl0, RS485Receive);  // Init Transceiver   
  digitalWrite(SSerialTxControl1, RS485Receive);  // Init Transceiver   
  digitalWrite(SSerialTxControl2, RS485Receive);  // Init Transceiver   
  digitalWrite(SSerialTxControl3, RS485Receive);  // Init Transceiver

  wdt_reset();
  wdt_enable(WDTO_8S);

}//--(end setup )---

void loop() {
  // rest the watchdog to detact lockup.
  wdt_reset();
  serialEvent();
  serialEvent1();
  serialEvent2();
  serialEvent3();
   // handle input from serial port
   if (stringComplete == true)
   {
     //respond
     //----------------------------------------------------------------------
     digitalWrite(SSerialTxControl1, RS485Transmit);  // Enable RS485 Transmit
     digitalWrite(SSerialTxControl2, RS485Transmit);  // Enable RS485 Transmit
     digitalWrite(SSerialTxControl3, RS485Transmit);  // Enable RS485 Transmit
     //Serial.print(inputstring);    
     Serial1.print(inputstring);
     Serial2.print(inputstring);
     Serial3.print(inputstring);
     delay(100);
     digitalWrite(SSerialTxControl1, RS485Receive);  // Disable RS485 Transmit\
     digitalWrite(SSerialTxControl2, RS485Receive);  // Disable RS485 Transmit
     digitalWrite(SSerialTxControl3, RS485Receive);  // Disable RS485 Transmit
      //---------------------------------------------------------------------
     //clean up
     inputstring = "";
     stringComplete = false;
   }
   // handle input from serial port 1
   if (stringComplete1 == true)
   {
     digitalWrite(SSerialTxControl0, RS485Transmit);  // Enable RS485 Transmit  
     Serial.print(inputstring1);
     delay(100);
     digitalWrite(SSerialTxControl0, RS485Receive);  // Disable RS485 Transmit
     inputstring1 = "";
     stringComplete1 = false;
   }  
   // handle input from serial port 2
   if (stringComplete2 == true)
   {
     digitalWrite(SSerialTxControl0, RS485Transmit);  // Enable RS485 Transmit  
     Serial.print(inputstring2);
     delay(100);
     digitalWrite(SSerialTxControl0, RS485Receive);  // Disable RS485 Transmit
     inputstring2 = "";
     stringComplete2 = false;
   }
   // handle input from serial port 3
   if (stringComplete3 == true)
   {
     digitalWrite(SSerialTxControl0, RS485Transmit);  // Enable RS485 Transmit  
     Serial.print(inputstring3);
     delay(100);
     digitalWrite(SSerialTxControl0, RS485Receive);  // Disable RS485 Transmit
     inputstring3 = "";
     stringComplete3 = false;
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
  while (Serial1.available()) {
    // get the new byte:
    char inChar = (char)Serial1.read();
    // add it to the inputString:
    inputstring1 += inChar;
    // if the incoming character is a newline, set a flag
     // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete1 = true;
    }
  }
}

//serial event 2
void serialEvent2() {
  while (Serial2.available()) {
    // get the new byte:
    char inChar = (char)Serial2.read();
    // add it to the inputString:
    inputstring2 += inChar;
    // if the incoming character is a newline, set a flag
     // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete2 = true;
    }
  }
}

//serial event 3
void serialEvent3() {
  while (Serial3.available()) {
    // get the new byte:
    char inChar = (char)Serial3.read();
    // add it to the inputString:
    inputstring3 += inChar;
    // if the incoming character is a newline, set a flag
     // so the main loop can do something about it:
    if (inChar == '\n') {
      stringComplete3 = true;
    }
  }
}
