#include <Stepper.h>
#include <SerialCommand.h>
//#include <EEPROM.h>
#include <SoftwareSerial.h>
#define TX 11
#define RX 10
#define RS485_DIR 4

#define RS485_WRITE 1
#define RS485_READ 0

#define DEMO_MODE 0

SoftwareSerial mySoftSerial = SoftwareSerial(RX, TX);    // The SoftwareSerial Object
SerialCommand SCmd;
String inputstring = "";
boolean stringComplete = false;
int test;
int byteReceived;
int byteSend;

//#define EEPROM_ADDRESS 20

#define CODE_IDLE 1000
#define CODE_HOMING_SUCCESS 900
#define CODE_HOMING_TIMEOUT 800
#define CODE_LEARN_SUCCESS 700
#define CODE_LEARN_ERROR 600

#define HOMING_ON_ANALOG 350 //factory calibrated, under this consider kena
#define HOMING_STEPPING_DELAY 6 //ms
#define STEPPING_DELAY 4//ms
#define LEARN_STEPPING_DELAY 0//ms

#define NUM_OF_STEP 2064
#define HOMING_TIMEOUT 10000 //ms

#define HOMED 1
#define NOT_HOMED 0

#define HOMING_PIN A6
#define ANAREF1V1 1
#define ANAREF5 0
//dilihati dari dePan device
#define CW -1
#define CCW 1
#define LED_POW 5

#define ONE_PEAK_COUNTERWEIGHT 1
#define ONE_PEAK_NEEDLE 0

//========================================================================
#define portOfPin(P)\
  (((P)>=0&&(P)<8)?&PORTD:(((P)>7&&(P)<14)?&PORTB:&PORTC))
#define ddrOfPin(P)\
  (((P)>=0&&(P)<8)?&DDRD:(((P)>7&&(P)<14)?&DDRB:&DDRC))
#define pinOfPin(P)\
  (((P)>=0&&(P)<8)?&PIND:(((P)>7&&(P)<14)?&PINB:&PINC))
#define pinIndex(P)((uint8_t)(P>13?P-14:P&7))
#define pinMask(P)((uint8_t)(1<<pinIndex(P)))

#define pinAsInput(P) *(ddrOfPin(P))&=~pinMask(P)
#define pinAsInputPullUp(P) *(ddrOfPin(P))&=~pinMask(P);digitalHigh(P)
#define pinAsOutput(P) *(ddrOfPin(P))|=pinMask(P)
#define digitalLow(P) *(portOfPin(P))&=~pinMask(P)
#define digitalHigh(P) *(portOfPin(P))|=pinMask(P)
#define isHigh(P)((*(pinOfPin(P))& pinMask(P))>0)
#define isLow(P)((*(pinOfPin(P))& pinMask(P))==0)
#define digitalState(P)((uint8_t)isHigh(P))
//========================================================================

#define c1 -3.01486975923733E-12
#define c2 4.7522475206047E-10
#define c3 3.29197643802136E-07
#define c4 -0.000114721369863765
#define c5 0.0158936235522449
#define c6 -0.80604289540763
#define c7 16.2675715624794

Stepper myStepper(NUM_OF_STEP, 6, 8, 7, 9);

//---------------------------------configuration variable for temperature-------------------------------------//


//const bool disable_averaging = true;

//const float master_offset = .1; //in degrees, global offsetting the whole angle offset
//const float angle_offset[4] = { 2.11 , 1.8836 , 4.0116 , 4.151}; //sensor factory offst, in degrees

//const uint16_t sensor_offset_master = 0; //in count, offsetting in motor count (if needed (ADV))
//
////constant for temperature
//const float effective_dial_angle = 280.0;
//const float dial_min_unit = 0.0;
//const float dial_max_unit = 200.0;
//const bool isLinearScale = 1;
//const String idName = "temp";
//-------------------------------------------------------------------------------------------------//

/*
  //---------------------------------configuration variable for pressure-------------------------------------//

  //auto triggered one peak mode, but one have to specified what that oeak is for each sensor
  bool onePeakMode[4] = {ONE_PEAK_COUNTERWEIGHT, ONE_PEAK_COUNTERWEIGHT, ONE_PEAK_COUNTERWEIGHT, ONE_PEAK_COUNTERWEIGHT};
  bool disable_averaging = true;

  float master_offset = -5.5; //in degrees, global offsetting the whole angle offset
  float angle_offset[4] = { -4.222 , 1.8836 , 4.0116 , 4.151}; //sensor factory offst, in degrees

  uint16_t sensor_offset_master = 0; //in count, offsetting in motor count (if needed (ADV))

  //constant FOR PRESSURE
  float effective_dial_angle = 270.0;
  float dial_min_unit = 0.0;
  float dial_max_unit = 25.0;
  bool isLinearScale=1;
  String idName="press";
  //-------------------------------------------------------------------------------------------------//

*/


//---------------------------------configuration variable for level V2-------------------------------------//
//const String idName = "level"; //id name for level
//const bool disable_averaging = true; //disable or enable averaging
//const bool isLinearScale = 0; //non linear mapping for level gauge
//const float master_offset = 9; //in degrees, affect measurement angle
//const float angle_offset[4] = { 2.11 - 36.047 , 1.8836 - 32.681 - 2.0 , 4.0116 - 34.809 , 4.151 - 36.693}; //sensor factory offst, in degrees
//const float effective_dial_angle = 0.0; //unnessecaru in level, but need in compile time
//const float dial_max_unit = 0.0;//unnessecaru in level, but need in compile time
//const float dial_min_unit = 0.0;//unnessecaru in level, but need in compile time
//const uint16_t sensor_offset_master = 0; //in count, offsetting in motor count (if needed (ADV))
//const float K_FACTOR = 0.55;
//const uint8_t HYSTERESIS = 10;
//const uint8_t OUTLIERS_THRESHOLD = 8; //in degrees, +- value
//const uint8_t ONE_PEAK_ADJUSTER_THRESHOLD = 10;
//---------------------------------------------------------------------------------------------------------//

//-----------------------------CONFIGURATION FOR PRESSURE v2-----------------------------------------------//
//const String idName = "press"; //id name for pressure
//const bool disable_averaging = true; //disable or enable averaging
//const bool isLinearScale = 1; // linear mapping for pressure gauge
//const float master_offset = 9; //in degrees, affect measurement angle
//const float angle_offset[4] = { 2.11 - 36.047 , 1.8836 - 32.681 - 2.0 , 4.0116 - 34.809 , 4.151 - 36.693}; //sensor factory offst, in degrees
//const float effective_dial_angle = 270.0;
//const float dial_min_unit = 0.0;
//const float dial_max_unit = 25.0;
//const uint16_t sensor_offset_master = 0; //in count, offsetting in motor count (if needed (ADV))
//const float K_FACTOR = 0.55;
//const uint8_t HYSTERESIS = 10;
//const uint8_t OUTLIERS_THRESHOLD = 8; //in degrees, +- value
//const uint8_t ONE_PEAK_ADJUSTER_THRESHOLD = 10;
//---------------------------------------------------------------------------------------------------------//

//-----------------------------CONFIGURATION FOR temperature v2-----------------------------------------------//
const String idName = "temp"; //id name for temp
const bool disable_averaging = true; //disable or enable averaging
const bool isLinearScale = 1; // linear mapping for temperature gauge
const float master_offset = 9; //in degrees, affect measurement angle
const float angle_offset[4] = { 2.11 - 36.047 , 1.8836 - 32.681 - 2.0 , 4.0116 - 34.809 , 4.151 - 36.693}; //sensor factory offst, in degrees
const float effective_dial_angle = 280.0;
const float dial_min_unit = 0.0;
const float dial_max_unit = 200.0;
const uint16_t sensor_offset_master = 0; //in count, offsetting in motor count (if needed (ADV))
const float K_FACTOR = 0.55;
const uint8_t HYSTERESIS = 10;
const uint8_t OUTLIERS_THRESHOLD = 8; //in degrees, +- value
const uint8_t ONE_PEAK_ADJUSTER_THRESHOLD = 10;
const float dumVal = 10.0; //dummy value for demo mode
//---------------------------------------------------------------------------------------------------------//

//one peak mode will be selected when compare to other sensor, default counterweight because, posterior knowledge: needle is harder to see
int onePeakMode[4] = {ONE_PEAK_COUNTERWEIGHT, ONE_PEAK_COUNTERWEIGHT, ONE_PEAK_COUNTERWEIGHT, ONE_PEAK_COUNTERWEIGHT};

const int sensor_range_min[4] = {50, 50, 50, 50};
const uint16_t sensor_offset[4] = {int(-NUM_OF_STEP / 8), int(-NUM_OF_STEP * 3 / 8), int( -NUM_OF_STEP * 5 / 8), int(-NUM_OF_STEP * 7 / 8)};

bool sensor_error[4] = {0, 0, 0, 0};
//sensor
uint16_t sensor_max[4] = {0, 0, 0, 0};
uint16_t sensor_min[4] = {1023, 1023, 1023, 1023};

//schmitt trigger
uint16_t middle_threshold[4];
uint16_t upper_threshold[4];
uint16_t lower_threshold[4];

//important, we use this as calculation base
uint16_t falling_edge[4][2];
uint16_t rising_edge[4][2];

uint16_t pulse_width[4][2];
uint16_t pulse_center[4][2];

float straightness[4];

float output_unit[4];

float deg_unit_min;
float deg_unit_max;
uint16_t jarum_calc[4];

float output_angle[4];

//saveData mySaveData ;
//default : sensor sense 2 peak
bool isOnePeakMode[4] = {false, false, false, false};

char buff[40];
uint16_t edge_find[4];
int code;
float angle1;

int homing(int dir = CCW, bool retract = 1) {
  // changeAnalogRef(ANAREF5);
  power_led(1);
  code = CODE_IDLE;
  if (retract) {
    move_stepper(-100 * dir, 10);
  }
  Serial.println(F("HOMING START"));
  unsigned long initial_time = millis();
  while (millis() - initial_time < HOMING_TIMEOUT) {
    if (readHoming() == HOMED) {
      myStepper.step(CW * dir);
      delay(HOMING_STEPPING_DELAY);
    } else {
      myStepper.step(CCW * dir);
      delay(HOMING_STEPPING_DELAY);
      if (readHoming() == HOMED) {
        //success homing
        code = CODE_HOMING_SUCCESS;
        break;
      }
    }
  }
  if (code == CODE_IDLE) {
    code = CODE_HOMING_TIMEOUT;
    Serial.println(F("HOMING TIMEOUT!"));
  } else {
    Serial.println(F("HOMING SUCCESS"));
  }
  Serial.println(analogRead(HOMING_PIN));
  disable_motor();
  //power_led(0);
  //a bit hack
  // changeAnalogRef(ANAREF1V1);
  return code;
}

void disable_motor() {
  //just to make sure everython ggoes off, might oose postion a bit
  digitalWrite(6, LOW);
  digitalWrite(7, LOW);
  digitalWrite(8, LOW);
  digitalWrite(9, LOW);
  // Serial.println("Motor Disabled");
}

int outliers_detection() {
  //RANSAC algorithm, BY DEGREE
  int sumOfError = 0;
  int sumEachNode[4] = {0, 0, 0, 0};

  Serial.println(F("One Peak Adjuster"));
  for (int i = 0; i < 4; i++) {
    if (isOnePeakMode[i] == true) {
      //Serial.println(i);

      //if only one peak detected, check to another sensor that has 2 peak reading
      float accum_angle;
      int cnt = 0;
      //iterate through sensor
      for (int a = 0; a < 4; a++) {
        //if the sensor is sensIng two peak, use this as calculate
        if (isOnePeakMode[i] == false) {
          cnt++;
          float new_angle = (output_angle[i] - 180.0);
          //deal with wrapping angle
          if (new_angle < 0) {
            new_angle += 360;
          }
          float delta = abs(new_angle - output_angle[a]);
          if (delta <= ONE_PEAK_ADJUSTER_THRESHOLD) {
            accum_angle += new_angle;
          }
        }
      }
      if (cnt != 0) {
        output_angle[i] = accum_angle / cnt;
      }
    }
  }
  // Serial.println(F("------"));
  Serial.println(output_angle[0]);
  Serial.println(output_angle[1]);
  Serial.println(output_angle[2]);
  Serial.println(output_angle[3]);


  Serial.println(F("Outliers Detection"));


  for (int i = 0; i < 4; i++) {
    for (int s = 0; s < 4; s++) {
      if (output_angle[s] < output_angle[i] + OUTLIERS_THRESHOLD && output_angle[s] > output_angle[i] - OUTLIERS_THRESHOLD) {
        sumEachNode[i]++;
      }
    }
    sprintf(buff, "S%d SUM%d", i, sumEachNode[i]);
    Serial.println(buff);
  }


  for (int i = 0; i < 3; i++) {
    if ( sumEachNode[i] != sumEachNode[i + 1]) {
      //ada minimum
      int location = find_minimum(sumEachNode, 4);
      sensor_error[location] = 1;
      int lets_find_this_value = sumEachNode[location];

      int encounter = 1;
      //cari ada yang sama dengan minimum lagi enggak
      for (int f = 0; f < 4; f++) {
        if (sumEachNode[f] == lets_find_this_value) {
          encounter++;
          sensor_error[f] = 1;
        }
      }
      break;
    }
  }

  return checkSensorError();

}

void move_stepper(int steps, int speeds) {
  Serial.print(F("MOVING STEPPER"));
  Serial.println(steps);
  myStepper.setSpeed(speeds);
  myStepper.step(steps);
  // disable_motor();
}

void led_cmd() {
  char *arg;
  arg = SCmd.next();

  if (arg != NULL)
  {
    if (arg [0] == '1') {
      //
      power_led(1);
    }
    else if (arg[0] == '0') {
      // Serial.println("LED OFF");
      power_led(0);
    }
    else {
      Serial.println(F("Wrong Command"));
    }

  }
  else {
    Serial.println(F("No arguments"));
  }
}

void read_main_cmd() {
  char *arg;
  arg = SCmd.next();

  if (arg != NULL)
  {
    if (arg [0] == '1') {
      //
      read_main(1);
    }
    else if (arg[0] == '0') {
      // Serial.println("LED OFF");
      read_main(0);
    }
    else {
      Serial.println(F("Wrong Command"));
    }

  }
  else {
    Serial.println(F("No arguments"));
  }
}

void homing_cmd() {
  int dir;
  //int speded;
  char *arg;

  arg = SCmd.next();
  if (arg != NULL)
  {
    dir = atoi(arg);  // Converts a char string to an integer
    homing(dir);
    //move_stepper(aNumber);
    //Serial.print("First argument was: ");
    //Serial.println(aNumber);

  }
  else {
    Serial.println(F("No arguments"));
  }
}

float mapping(int x, float a, float b, float c, float d) {
  return float((c * float(x) - c * b + d * b - a * d + b * d) / (a - b));
}

float mapping_nonlinear(float x_in) {
  //approximated function
  float y = 0.0;
  float x = 0.0;

  if (x_in > 180.0 && x_in < 360.0) {
    //    x = x_in-180;
    x = abs(x_in - 360);
  } else {
    x = x_in;
  }

  y = c1 * x * x * x * x * x * x + c2 * x * x * x * x * x + c3 * x * x * x * x + c4 * x * x * x + c5 * x * x + c6 * x + c7;

  if (x_in > 180.0 && x_in < 360.0) {
    y = 100 - y;
  }

  //contraint
  if (y < 0.0) {
    y = 0.0;
  }
  if (y > 100.0) {
    y = 100.0;
  }

  Serial.print(F("Non-linear map "));
  Serial.print(x_in);
  Serial.print(F(" "));
  Serial.println(y);

  return y;
}

bool readHoming() {


  int state = analogRead(HOMING_PIN);
  if (state <= HOMING_ON_ANALOG) {
    return HOMED;
  } else {

    return NOT_HOMED;
    //return HOMED;
  }
  //  return digitalRead(HOMING_PIN);
}

int readDial(bool debug = 0) {
  Serial.println(F("Start read dial"));
  //output falling and rising, not yet offsetted

  //  if (homing() == CODE_HOMING_SUCCESS) {
  //learn();
  // bool debug = 1;
  int sumOfError = 0;
  uint16_t raw_sens[4][5];
  uint16_t averaged_sens[4];
  bool schmitt_state[4];
  int rising_index[4] = {0, 0, 0, 0};
  int falling_index[4] = {0, 0, 0, 0};
  bool schmitt_state_new[4];

  //isi dulu 4 datum awal dari 4 sensor, buat initial averaging
  for (uint8_t i = 0; i < 4; i++ ) {//iterasi sensor
    for (uint8_t index = 0; index  < 5; index++  ) {//iterasi 4 kali sampling
      raw_sens[i][index] = analogRead(i);

    }
    //approx initial condition buat schmitt
    if (raw_sens[i][4] < middle_threshold[i]) {
      schmitt_state[i] = 0;
    }
    else {
      schmitt_state[i] = 1;
    }
  }


  Serial.println(F("PRE SCANNING OK"));

  //scanning
  for (int stepping = 0; stepping < NUM_OF_STEP; stepping++  ) {
    myStepper.step(CW);
    //iterate each sensor
    for (uint8_t i = 0; i < 4; i++  ) {
      if (sensor_error[i] == 0) {
        //averaging rolling buffer
        raw_sens[i][(4  + stepping) % 5] = analogRead(i);

        //averagin, five point rolling average
        uint16_t sumOfFive = 0;

        for (uint8_t id = 0; id < 5; id++  ) {
          //moving average
          sumOfFive  = raw_sens[i][id] + sumOfFive;
        }
        averaged_sens[i] = int(sumOfFive / 5);

        //Disable averaging if sharp pointy peaks is reduced
        if (disable_averaging == true)
        {
          averaged_sens[i] = raw_sens[i][(4  + stepping) % 5];
        }


        if (schmitt_state[i] == 1) {
          if (averaged_sens[i] <= lower_threshold[i])
          {
            schmitt_state_new[i] = 0;
          } else {
            schmitt_state_new[i] = 1;
          }
        } else {
          if (averaged_sens[i] >= upper_threshold[i]) {
            schmitt_state_new[i] = 1;
          } else {
            schmitt_state_new[i] = 0;
          }

        }

        //edge detection

        if (schmitt_state[i] == 0 && schmitt_state_new[i] == 1) {
          //rising edge, hindari index out of range jika ada rising edge banyak
          //    sprintf(buff," statRISING%d S%d %d",i,stepping,rising_index[i]);
          //    Serial.print(buff);
          //   rising_index[i]=rising_index[i]+1;

          if (rising_index[i] > 1) {
            //too many edge, throw error on particular sensor
            sensor_error[i] = 1;
            Serial.print(F("Too many rising ID: "));
            Serial.println(i);
          } else {
            rising_edge[i][rising_index[i]] = stepping;
          }
          rising_index[i]++ ;
        }
        else if (schmitt_state[i] == 1 && schmitt_state_new[i] == 0) {
          //falling edge
          //  sprintf(buff," statFALLING%d S%d %d",i,stepping,falling_index[i]);
          //    Serial.print(buff);
          //    falling_index[i]=falling_index[i]+1;

          if (falling_index[i] > 1) {
            //too many edge, throw error on particular sensor
            sensor_error[i] = 1;
            Serial.print(F("Too many falling ID: "));
            Serial.println(i);
          } else {
            falling_edge[i][falling_index[i]] = stepping;
          }
          falling_index[i]++  ;
        }
        schmitt_state[i] = schmitt_state_new[i];

      }

    }

    //debug = 1;
    if (debug == 1) {
      sprintf(buff, "A %d %d %d %d D %d %d %d %d", averaged_sens[0], averaged_sens[1], averaged_sens[2], averaged_sens[3], schmitt_state_new[0], schmitt_state_new[1], schmitt_state_new[2], schmitt_state_new[3]);
      Serial.println(buff);
    }
    delay(STEPPING_DELAY);
  }


  for (int a = 0; a < 4; a++) {
    //if afrer scan rising index or falling index equal one, then it only detect one peak
    if (rising_index[a] == 1 || falling_index[a] == 1 ) {
      isOnePeakMode[a] = true;
    }

    sprintf(buff, "SEN %d F1:%d F2:%d R1:%d R2:%d", a, falling_edge[a][0], falling_edge[a][1], rising_edge[a][0], rising_edge[a][1]);
    Serial.println(buff);
    //calculateRealUnits();
    //calculate unit

  }
}

void initLearn() {
  // sensor_max[] = {0, 0, 0, 0};
  //sensor_min[] = {1023, 1023, 1023, 1023};
  for (int i = 0; i < 4; i++  ) {
    sensor_max[i] = 0;
    sensor_min[i] = 1023;
    sensor_error[i] = 0;
    isOnePeakMode[i] = false;
  }
}

int learn() {
  initLearn();
  Serial.println(F("LEARN START"));
  uint16_t raw[4];
  int code;
  bool isHomed = 0;

  for (int stepping = 0; stepping < NUM_OF_STEP; stepping++  ) {
    // stepMotor(1);
    // Serial.println(stepping);
    myStepper.step(CCW);
    for (uint8_t i = 0; i < 4; i++  ) {
      raw[i] = analogRead(i);
      if (raw[i] < sensor_min[i]) {
        sensor_min[i] = raw[i];
      }
      if (raw[i] > sensor_max[i]) {
        sensor_max[i] = raw[i];
      }
    }
    delay(LEARN_STEPPING_DELAY);
    if (isHomed == 0 && readHoming() == HOMED ) {
      isHomed = 1;
    }
    // sprintf(buff, "%d %d %d %d", raw[0], raw[1], raw[2], raw[3]);
    //   Serial.println(buff);
  }
  //  if (readHoming() == NOT_HOMED) {
  //Serial.println("LEARN ERROR CANNOT REACH POS");
  //    code = CODE_LEARN_SUCCESS;
  //  } else {
  if (isHomed == 0) {
    code = CODE_LEARN_ERROR;
  }
  else {
    Serial.println(F("LEARN END"));
    sprintf(buff, "MAX: %d %d %d %d", sensor_max[0], sensor_max[1], sensor_max[2], sensor_max[3]);
    Serial.println(buff);
    sprintf(buff, "MIN: %d %d %d %d", sensor_min[0], sensor_min[1], sensor_min[2], sensor_min[3]);
    Serial.println(buff);
    code = CODE_LEARN_SUCCESS;
    //  }
  }
  disable_motor();
  return code;
  //calculateParams();
}

int checkSensorValidity() {
  int sumOfError = 0;
  for (int i = 0; i < 4; i++) {
    if (sensor_max[i] - sensor_min[i] < sensor_range_min[i]) {
      sensor_error[i] = 1;
      sumOfError++;
      sprintf(buff, "ERROR RANGE ID %d", i);
      Serial.println(buff);
    }
  }
  return sumOfError;
}

void calculateParams() {
  for (uint8_t i = 0; i < 4; i++  ) {
    middle_threshold[i] = int(sensor_min[i]  + (sensor_max[i] - sensor_min[i]) * K_FACTOR);
    upper_threshold[i] = middle_threshold[i]  + HYSTERESIS;
    lower_threshold[i] = middle_threshold[i] - HYSTERESIS;
    sprintf(buff, "PARAMS ID:%d M:%d U:%d L:%d", i, middle_threshold[i] , upper_threshold[i], lower_threshold[i]);
    Serial.println(buff);
  }

}

int find_minimum(int a[], int n) {
  int c, min, index;

  min = a[0];
  index = 0;

  for (c = 1; c < n; c++) {
    if (a[c] < min) {
      index = c;
      min = a[c];
    }
  }

  return index;
}

void calculateRealUnits() {
  Serial.println(F("Real unit Calc"));
  //output: positional straightness, posisi jarum, posisi counter, width jarum, width counter yang sudah di normalisasi
  //check sensor error
  uint16_t edge_find[4];
  //offset sensor check, and normaliize
  for (uint8_t i = 0; i < 4; i++  ) {

    if (sensor_error[i] == 0) {
      if (isOnePeakMode[i] == false) {
        edge_find[0] =  falling_edge[i][0];
        edge_find[1] =  falling_edge[i][1];
        edge_find[2] =  rising_edge[i][0];
        edge_find[3] =  rising_edge[i][1];
        int location = find_minimum(edge_find, 4);
        sprintf(buff, "LOC%d %d", i, location);
        Serial.println(buff);
        if (!(location == 3 || location == 2)) {
          //berarti ini kepotong, di proses dulu

          pulse_width[i][0] = falling_edge[i][0] + (NUM_OF_STEP - rising_edge[i][1]);
          pulse_width[i][1] = falling_edge[i][1] - rising_edge[i][0];
          pulse_center[i][0] = ((pulse_width[i][0] / 2) + rising_edge[i][1]) % NUM_OF_STEP;
          pulse_center[i][1] = (pulse_width[i][1] / 2) + rising_edge[i][0];
        } else {
          //grafik enggak kepotong, berarti sensor awalnya tidak terletak pada jarum/counter weight
          //Serial.println("gak kepotong");
          pulse_width[i][0] = falling_edge[i][0] - rising_edge[i][0];
          pulse_width[i][1] = falling_edge[i][1] - rising_edge[i][1];
          pulse_center[i][0] = (pulse_width[i][0] / 2) + rising_edge[i][0];
          pulse_center[i][1] = (pulse_width[i][1] / 2) + rising_edge[i][1];
        }


        //normalisasi grafik, pakai sensor offset
        for (int J = 0; J < 2; J++) {
          pulse_center[i][J] = (pulse_center[i][J] - sensor_offset[i]) % NUM_OF_STEP;
        }

        sprintf(buff, "S%d PW1=%d PC1=%d PW2=%d PC2=%d", i, pulse_width[i][0], pulse_center[i][0], pulse_width[i][1], pulse_center[i][1]);
        Serial.println(buff);

        //hitung jarak antara, harusnya 180 derajat, NUM_OF_STEPS/2
        /* if (pulse_center[i][0] < pulse_center[i][1]) {
           straightness[i] = (pulse_center[i][1] - pulse_center[i][0]) / (NUM_OF_STEP / 2);
          } else {
           straightness[i] = (pulse_center[i][0] - pulse_center[i][1]) / (NUM_OF_STEP / 2);
          }*/




      } else {
        //one peak mode
        if (falling_edge[i][0] < rising_edge[i][0]) {
          //kepotong grafiknya
          pulse_width[i][0] = falling_edge[i][0] + (NUM_OF_STEP - rising_edge[i][0]);
          pulse_center[i][0] = ((pulse_width[i][0] / 2) + rising_edge[i][0]) % NUM_OF_STEP;
        }
        else {
          //enggak kepotong
          pulse_width[i][0] =  falling_edge[i][0] - rising_edge[i][0] ;
          pulse_center[i][0] = (pulse_width[i][0] / 2) + rising_edge[i][0];
        }

        //offset 180 derajat kalo yang kedetk itu one peak dan di set counterweight
        if (onePeakMode[i] == ONE_PEAK_COUNTERWEIGHT) {
          pulse_center[i][0] = (pulse_center[i][0] + (NUM_OF_STEP / 2)) % NUM_OF_STEP;
        }

        //normalisasi grafik, pakai sensor offset
        pulse_center[i][0] = (pulse_center[i][0] - sensor_offset[i]) % NUM_OF_STEP;
        sprintf(buff, "S%d PW1=%d PC1=%d", i, pulse_width[i][0], pulse_center[i][0]);
        Serial.println(buff);

      }

      //choose which one is needle
      if (isOnePeakMode[i] == false) {
        if ((pulse_width[i][0] < pulse_width[i][1])) {
          jarum_calc[i] = pulse_center[i][0] - sensor_offset_master;
        } else {
          jarum_calc[i] = pulse_center[i][1] - sensor_offset_master;
        }
      } else {
        //we dont havE to choose if the sensor is on one peak mode
        jarum_calc[i] = pulse_center[i][0] - sensor_offset_master;
      }

      sprintf(buff, "NEEDLE%d %d", i, jarum_calc[i]);
      Serial.println(buff);


      // output_unit[i] = (jarum_calc * (unit_max - unit_min) - mcd * (unit_max - unit_min) + unit_min * (mcu - mcd)) / (mcu - mcd);
      deg_unit_min = float(0.5 * (360.0 - effective_dial_angle));
      deg_unit_max = float(360.0 - deg_unit_min);

      angle1 = float(360.0 * (float(jarum_calc[i]) / float(NUM_OF_STEP)));
      angle1 = float(360.0 - angle1 + angle_offset[i] + master_offset);
      // char str_temp[6];
      //dtostrf(angle1, 4, 2, str_temp);
      sprintf(buff, "ANGLE%d ", i);
      Serial.print(buff);
      Serial.print(angle1, 3);
      //     printFloat(angle1, 3);
      Serial.println("");
      output_angle[i] = angle1;

      if (isLinearScale == 1) {

        output_unit[i] = mapping(angle1, deg_unit_max, deg_unit_min, dial_max_unit, dial_min_unit);
        //if compensate straigthness on then IDK
      }
      else {
        //mapping buat si rotogauge
        output_unit[i] = mapping_nonlinear(angle1);

      }
      //just add one more protection
      if (pulse_width[i][0] < 0 || pulse_width[i][1] < 0) {
        // sensor_error[i] = 1;
        //just 1 pucak yang ke detek

      }

    }
  }
  //does not necessarry
  Serial.print(F("OUTPUT MASTER = "));
  float total = 0;
  int noterrsum = 0;

  for (int p = 0; p < 4; p++) {
    if (sensor_error[p] == 0) {
      // total_angle+=output_angle[p];
      total += output_unit[p];
      noterrsum++;
    }
    //Serial.println(noterrsum);
  }
  total = float(total / noterrsum);
  Serial.println(total, 3);

  //  printFloat(total, 3);
  //Serial.println();a
}

void displayResult() {
  float total = 0, total_angle = 0;
  int noterrsum = 0;
  //final averaging
  for (int p = 0; p < 4; p++) {
    if (sensor_error[p] == 0) {
      total_angle += output_angle[p];
      total += output_unit[p];
      noterrsum++;
    }

  }
  total = float(total / noterrsum);
  total_angle = float(total_angle / noterrsum);

  //printFloat485(total, 3);
  Serial.print(F("OUTPUT UNIT: "));
  Serial.println(total, 4);
  Serial.print(F("OUTPUT ANGLE: "));
  Serial.println(total_angle, 4);
  mode485(RS485_WRITE);
  mySoftSerial.print(idName + ":data=");
  //printFloat485(total, 3);
  mySoftSerial.println(total);
  mode485(RS485_READ);
}

int checkSensorError() {
  int sumOfError = 0;
  for (int i = 0; i < 4; i++) {
    if (sensor_error[i] == 1) {

      sprintf(buff, "ERROR SIGNAL ID %d", i);
      Serial.println(buff);
      sumOfError++;
    }
  }
  return sumOfError;
}

void power_led(bool stat) {
  if (stat) {
    digitalWrite(5, HIGH);
    Serial.println(F("LED ON"));
  }
  else {
    digitalWrite(5, LOW);
    Serial.println(F("LED OFF"));
  }
}


void step_move() {
  int aNumber;
  int speded;
  char *arg;

  arg = SCmd.next();
  if (arg != NULL)
  {
    aNumber = atoi(arg);
  }
  else {
    Serial.println(F("No arguments"));
  }

  arg = SCmd.next();
  if (arg != NULL)
  {
    speded = atoi(arg);
    move_stepper(aNumber, speded);


  }
  else {
    Serial.println(F("No arguments"));
  }
}

void read_main(bool debug) {
  //move_stepper(100, 10);
  power_led(1);
  mode485(RS485_WRITE);
  mySoftSerial.println(F("press:ComAccepted"));
  mode485(RS485_READ);
  if (homing(CW, true) == CODE_HOMING_SUCCESS) {
    if (learn() == CODE_LEARN_SUCCESS) {
      if (checkSensorValidity() != 4) {
        calculateParams();
        readDial(debug);
        if (checkSensorError() != 4) {
          calculateRealUnits();
          if (outliers_detection() != 4) {
            //finish!
            displayResult();
          } else {
            Serial.println(F("Outliers Detection Fail"));
            mode485(RS485_WRITE);
            mySoftSerial.println(F("<ERR:500>"));
            mode485(RS485_READ);
          }
        } else {
          //throw errow, no valid sensor after reading, falling/rising too many
          Serial.println(F("No valid sensor after reading"));
          mode485(RS485_WRITE);
          mySoftSerial.println(F("<ERR:100>"));
          mode485(RS485_READ);
          homing(CW, false);
        }
      } else {
        //throw wrrow, no valid sensor after learning, range too narrow
        Serial.println(F("No valid sensor after learning"));
        mode485(RS485_WRITE);
        mySoftSerial.println(F("<ERR:200>"));
        mode485(RS485_READ);
        move_stepper(-100 , 10);
        homing(CW, false);

      }
    } else {
      //throw error, learning not succed, motor cannot reach target position
      Serial.println(F("Learning not succed"));
      mode485(RS485_WRITE);
      mySoftSerial.println(F("<ERR:300>"));
      mode485(RS485_READ);
      homing(CCW, false); //jangan pake maju dulu
    }
  } else {
    //throw error,first homing not succed, maybe problem with motor
    mode485(RS485_WRITE);
    mySoftSerial.println(F("<ERR:400>"));
    mode485(RS485_READ);
    Serial.println(F("Homing Fail"));
  }
  //success
  // Serial.println("Output:");
  //output_unit[0] = 100.002;
  //Serial.println(output_unit[0]);
  // Serial.println(output_unit[1]);
  // Serial.println(output_unit[2]);
  // Serial.println(output_unit[3]);

  //succed or not, turn off motor and led
  disable_motor();
  power_led(0);
}

void unrecognized() {
  Serial.println(F("What?"));
}
void unrecognized485() {
  mode485(RS485_WRITE);
  mySoftSerial.println(F("<ERR:800>"));
  mode485(RS485_READ);
}
void read_anal() {
  Serial.println(analogRead(HOMING_PIN));
}

void setup() {
  // changeAnalogRef(ANAREF1V1);
  // put your setup code here, to run once:
  Serial.begin(19200);
  mySoftSerial.begin(9600);

  mode485(RS485_READ);
  pinMode(LED_POW, OUTPUT);
  pinMode(RS485_DIR, OUTPUT);

  Serial.println(F("START DIAL READER V1.0"));

  // load_memory_cmd();

  mode485(RS485_WRITE);
  mySoftSerial.println(F("<READY>"));
  mode485(RS485_READ);

  Serial.println(F("FW Version 1.2.0"));

  SCmd.addCommand("HOMING", homing_cmd);
  SCmd.addCommand("STEP", step_move);
  SCmd.addCommand("READ", read_main_cmd);
  SCmd.addCommand("READ_HOMING", read_anal);
  SCmd.addCommand("LEARN", learn);
  SCmd.addCommand("LED", led_cmd);

  // SCmd.addCommand("GET_VAR", load_memory_cmd);//load variable
  //  SCmd.addCommand("SET_HOFFSET", set_hoffset_cmd);//set home offset in motor count
  //  SCmd.addCommand("SET_GAUGE_PARAMS", set_ugauge_cmd); //set unit minimum and maximum

  // SCmd.addCommand("SET_GAUGE_DEG", set_gauge_cmd);//set dial effective angle
  //SCmd.addCommand("SET_ID", set_id_cmd); //set type and ID

  SCmd.addDefaultHandler(unrecognized);

  //mainCmd.addCommand("<READ!>", read_main);
  //mainCmd.addCommand("press:data?", read_main);
  // mainCmd.addCommand("<GETID!>", view_id);
  // mainCmd.addCommand("<GETVAR!>", view_params);

  //  mainCmd.addDefaultHandler(unrecognized485);

}

void loop() {
  // put your main code here, to run repeatedly:
  // mainCmd.readSerial();
  SCmd.readSerial();
  if (mySoftSerial.available())  //Look for data from other Arduino
  {
    //   digitalWrite(13, HIGH);  // Show activity
    byteReceived = mySoftSerial.read();    // Read received byte
    inputstring += (char)byteReceived;
    if (byteReceived == '\n')
      stringComplete = true;
    // digitalWrite(13, LOW);  // Show activity
  }
  if (stringComplete == true)
  {
    Serial.println(inputstring);
    //respond
    inputhandle(inputstring);
    //clean up
    inputstring = "";
    stringComplete = false;
  }
}

void mode485(bool mode) {
  //digitalWrite(RS485_DIR, mode);
  if (mode == 1) {
    digitalHigh(RS485_DIR);
  } else {
    digitalLow(RS485_DIR);

  }
}

void changeAnalogRef(bool type) {
  if (type == ANAREF1V1) {
    analogReference(INTERNAL);
  }
  else {
    analogReference(DEFAULT);
  }
  //throw 20 garbage reading after changing ref
  for (int a = 0; a < 20; a++) {
    analogRead(HOMING_PIN);
    analogRead(0);
    analogRead(1);
    analogRead(2);
    analogRead(3);
  }
}

void const inputhandle(String & inputstring)
{
  if (inputstring.indexOf(idName + ":data?") != -1)
  {
    delay(100);
#ifdef DEMO_MODE
    mode485(RS485_WRITE);
    mySoftSerial.print(idName + ":data=");
    //printFloat485(total, 3);
    mySoftSerial.println(dumVal);
    mode485(RS485_READ);
#else
    read_main(0);
#endif
  } else if (inputstring.indexOf("<GETID!>") != -1)
  {
    delay(100);
    //      view_id();
  } else if (inputstring.indexOf("<GETVAR!>") != -1)
  {
    delay(100);
    //    view_params();
  }
}

