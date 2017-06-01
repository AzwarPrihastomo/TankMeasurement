
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
int test;

int byteReceived;
int byteSend;


void setup()   /****** SETUP: RUNS ONCE ******/
{
  // Start the built-in serial port, probably to Serial Monitor
  Serial.begin(9600); 
  pinMode(Pin13LED, OUTPUT);   
  pinMode(SSerialTxControl, OUTPUT);    
  
  digitalWrite(SSerialTxControl, RS485Receive);  // Init Transceiver   
  
  // Start the software serial port, to another device
  RS485Serial.begin(4800);   // set the data rate 

}//--(end setup )---


void loop()   /****** LOOP: RUNS CONSTANTLY ******/
{
  digitalWrite(Pin13LED, HIGH);  // Show activity
  if (Serial.available())
  {
    byteReceived = Serial.read();
    
    digitalWrite(SSerialTxControl, RS485Transmit);  // Enable RS485 Transmit   
    RS485Serial.write(byteReceived);          // Send byte to Remote Arduino
    digitalWrite(Pin13LED, LOW);  // Show activity    
    delay(1);
    digitalWrite(SSerialTxControl, RS485Receive);  // Disable RS485 Transmit       
  }
  
  if (RS485Serial.available())  //Look for data from other Arduino
   {
    digitalWrite(Pin13LED, HIGH);  // Show activity
    byteReceived = RS485Serial.read();    // Read received byte
    inputstring += (char)byteReceived;
    if (byteReceived == '\n')
      stringComplete = true;
    digitalWrite(Pin13LED, LOW);  // Show activity   
   }

   if (stringComplete == true)
   {
     Serial.print(inputstring);
     //respond
     inputhandle(inputstring);
     //clean up
     inputstring = "";
     stringComplete = false;
   }
}

void const inputhandle(String & inputstring) 
{
    if (inputstring.indexOf("temp:data?") != -1)
    {
      delay(100);

      digitalWrite(SSerialTxControl, RS485Transmit);
      RS485Serial.println("temp:ComAccepted");
      delay(100);
      digitalWrite(SSerialTxControl, RS485Receive);
      
      test++;
      digitalWrite(SSerialTxControl, RS485Transmit);
      RS485Serial.print("temp:data=");
      RS485Serial.println(test);
      delay(100);
      digitalWrite(SSerialTxControl, RS485Receive);
      if(test > 100)
        test = 0;
    }
}
