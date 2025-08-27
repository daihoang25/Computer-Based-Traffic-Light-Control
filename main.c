#include <16f887.h>
#include <stdio.h>
#fuses NOMCLR, INTRC_IO, NOBROWNOUT, NOLVP
#use delay(clock=8M)
#use rs232(UART1, baud=9600, xmit=PIN_C6, rcv=PIN_C7) 
#define data       PIN_D0 // D0 xuat dua du lieu vao ic595
#define clk        PIN_D1 // Xung Clk co cannh len o hc595 se day bit vao
#define shiftOut   PIN_D2 // D2 co xung clock se day du lieu ra cac cong output cua ic595 tung bit mot
#define Red_A      PIN_C0
#define Yellow_A   PIN_C1
#define Green_A    PIN_C2
#define Red_B      PIN_C3
#define Yellow_B   PIN_C4
#define Green_B    PIN_C5

char buffer[8], c;
int index = 0;
int1 flag_data=0;//co kiem tra xem da nhan duoc ki tu ket thuc chuoi nhan duoc
unsigned int8 i;

#int_rda
void _Interrupt_RDA(void)
{
   c=getchar();//gan tam gia tri nhan duoc vao bien c
   if(c=='~')
   {
      flag_data=1;//ket thuc qua trinh truyen nhan du lieu voi may tinh   
      //index=0;//reset he so mang ve 0
   }
   else
   {
      buffer[index]=c;//nap du lieu nhan duoc vao cac phan tu mang
      index++;//tang he so mang len 1
   }   
}

const unsigned char led7seg[10] = {0XC0,0XF9,0XA4,0XB0,0X99,0X92,0X82,0XF8,0X80,0X90};

unsigned int8 L1a, L1b, L2a, L2b;

// Day du lieu ra cong DS cua ic595
void Out_byte (unsigned int8 Out)
{
   unsigned int8 i = 0;
   #bit bitData = Out.7; // Day du lieu tu bit cao ra ic595
   for (i = 0; i < 8; i++)
   {
      output_bit(data, bitData);
      output_low(clk); output_high(clk); // Tao canh len xung clock
      Out = Out << 1;
   }
}

void OutToLed()
{
   Out_byte(L1a);
   Out_byte(L1b);
   Out_byte(L2a);
   Out_byte(L2b);
   output_low(shiftOut); output_high(shiftOut); // Day cac bit ngo ra cua ic595 ra cac LED (xung len cua ST_CP)
}

// Giai ma LED 7 doan
void LED_decoder1(unsigned int x)
{
   L1a = led7seg[x/10]; // Hang chuc. VD: 26s thi L1a = 2 ung voi ma trong chuoi led7seg
   L1b = led7seg[x%10]; // Hang don vi. VD: 26/10 du 6 thi 6 ung voi ma trong chuoi led7seg
}

void LED_decoder2(unsigned int x)
{
   L2a = led7seg[x/10]; // Hang chuc. VD: 26s thi L1a = 2 ung voi ma trong chuoi led7seg
   L2b = led7seg[x%10]; // Hang don vi. VD: 26/10 du 6 thi 6 ung voi ma trong chuoi led7seg
}

void main()
{
beginLoop:
setup_oscillator(OSC_8MHZ);                    // Set internal oscillator to 8MHz
unsigned int i = 0;
//set_tris_C(0); // PortC: Output
//set_tris_D(0); // PortD: Output
int8 step1, step2, step3, step4;
ENABLE_INTERRUPTS(INT_RDA);//cho phep ngat uart(ngat truyen nhan du lieu)
ENABLE_INTERRUPTS(GLOBAL);//cho phep ngat toan cuc
 while(TRUE)
   {
   if (flag_data == 1)
   {
   // Tinh toan thoi gian cac step
   step1 = (buffer[0]-48)*10 + (buffer[1]-48); 
   step2 = (buffer[2]-48)*10 + (buffer[3]-48);
   step3 = (buffer[4]-48)*10 + (buffer[5]-48);
   step4 = (buffer[6]-48)*10 + (buffer[7]-48);
      // Step1: Red_A & Green_B ON
      for (i = 0; i < step1 ; i++)
      {
         printf("RedA_GreenB\n\r");
         output_high(Red_A); output_low(Yellow_A); output_low(Green_A);
         output_high(Green_B); output_low(Yellow_B); output_low(Red_B);
         LED_decoder1(step1 +step2 - i); LED_decoder2(step1 - i);
         OutToLed();
         delay_ms(1000);
      }
      
      // Step2: Red_A & Yellow_B ON
      for (i = 0; i < step2; i++)
      {
         printf("RedA_YellowB\n\r");
         output_high(Red_A); output_low(Yellow_A); output_low(Green_A);
         output_high(Yellow_B); output_low(Green_B); output_low(Red_B);
         LED_decoder1(step2 - i); LED_decoder2(step2 - i);
         OutToLed();
         delay_ms(1000);
      }
      
      // Step3: Green_A & Red_B ON
      for (i = 0; i < step3; i++)
      {
         printf("GreenA_RedB\n\r");
         output_high(Green_A); output_low(Yellow_A); output_low(Red_A);
         output_high(Red_B); output_low(Yellow_B); output_low(Green_B);
         LED_decoder1(step3 + step4 - i); LED_decoder2(step3 - i);
         OutToLed();
         delay_ms(1000);
      }
      
      // Step4: Yellow_A & Red_B ON
      for (i = 0; i < step4; i++)
      {
         printf("YellowA_RedB\n\r");
         output_high(Yellow_A); output_low(Red_A); output_low(Green_A);
         output_high(Red_B); output_low(Yellow_B); output_low(Green_B);
         LED_decoder1(step4 - i); LED_decoder2(step4 - i);
         OutToLed();
         delay_ms(1000);
      }
   }
   else goto beginLoop;
}
}
