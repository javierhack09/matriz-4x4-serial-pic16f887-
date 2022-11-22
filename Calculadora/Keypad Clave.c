#include <16f877a.h>
#FUSES XT,NOPROTECT,NOWDT,NOBROWNOUT,NOPUT,NOLVP
#USE DELAY(CLOCK=4000000)
#use rs232(baud=9600, xmit=pin_c6, rcv=pin_c7, bits=8)
#DEFINE USE_PORTB_KBD

#include <kbd4x4.c>              // Libreria para teclado matricial 4x4
#include <string.h>              // Libreria para manejo de cadenas de caracteres

int i = 0;                       // Contador
char k;                          // Variable donde se almacena la tecla presionada
char clave[4];                   // Almacena la clave

void main()
{
           
   kbd_init();                   // Inicializa el teclado matricial
   port_b_pullups(0xff);         // Habilita las resistencias internas del puerto B
   
   while(true)
   {
      
         k = kbd_getc();         // Lee la tecla presionada
         if(k != 0)
         {
            clave[i] = k;        // Almacena cada carecter en la cadena clave
            printf("%c\n",k);
            i++;
         }
      
   }
}
