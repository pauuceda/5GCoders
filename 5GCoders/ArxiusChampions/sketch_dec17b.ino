#include <Wire.h>
#include <LCD.h>
#include <LiquidCrystal_I2C.h>
#include <Keypad.h>

#define I2C_ADDR 0x27

LiquidCrystal_I2C pantalla(I2C_ADDR, 2, 1, 0, 4, 5, 6, 7);

const byte filas = 4;
const byte columnas = 4;
byte pinsFila[filas] = {7, 6, 5, 4};
byte pinsColumna[columnas] = {3, 2, 1, 0};

char teclas[filas][columnas] = {
  {'1', '2', '3', ' '},
  {'4', '5', '6', '+'},
  {'7', '8', '9', '-'},
  {'*', '0', '/', '='}
};

char tecla;
String numero;
int numeroInt;
double resultat = 0;

Keypad teclado = Keypad(makeKeymap(teclas), pinsFila, pinsColumna, filas, columnas);

void setup()
{
  pantalla.begin(16, 2);
  pantalla.setBacklightPin(3, POSITIVE);
  pantalla.setBacklight(HIGH);

  pantalla.home();
}
void loop()
{
  tecla = teclado.waitForKey();

  pantalla.print(tecla);

  if (tecla == ' ')
  {
    pantalla.clear();
  }

  if (!teclaOperador)
  {
    numero += tecla;
  }
  else if (tecla == '=')
  {
    pantalla.print(resultat);
  }
  else
  {
    numeroInt = numero.toInt();

    if (tecla == '+')
    {
      resultat += numeroInt;
    }
    else if (tecla == '-')
    {
      resultat -= numeroInt;
    }
    else if (tecla == '*')
    {
      resultat *= numeroInt;
    }
    else if (tecla == '/')
    {
      resultat /= numeroInt;
    }
  }
}

bool teclaOperador()
{
  bool operador = true;
  
  if (tecla != '+' && tecla != '-' && tecla != '*' && tecla )
  {
    operador = false;
  }

  return operador;
}
