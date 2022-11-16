/*Realizar un programa que ingrese un numero  y despliegue la cantidad de billetes que debe devolver acorde a la cantidad.
Tomar en cuenta que existen de: 200, 100, 50, 20, 10, 5, 1, 0.50, 0.25*/
Console.WriteLine("¡Bienvenido!");
Console.WriteLine ("Ingrese un número positivo, entero o decimal");
double numero = 0;
numero = Convert.ToDouble(Console.ReadLine());

if (numero >=0){
    double billetesDocientos =numero / 200; //Numero de billetes que debe devolver  de 200
    double resul1 =numero % 200;
    Console.WriteLine("La cantidad de billetes que debe devolver es: ");
    Console.WriteLine(Math.Truncate(billetesDocientos) + " billete de 200 ");
    
    //Billetes de 100 quetzales
    double billetesCien = resul1 / 100;
    double resul2=resul1 % 100;
    Console.WriteLine(Math.Truncate(billetesCien) + " Billetes de 100");

    //Billetes de 50 quetzales
    double billetesCincuenta= resul2 / 50;
    double resul3 = resul2 % 50;  
    Console.WriteLine(Math.Truncate(billetesCincuenta) + " Billetes de 50");

    //Billetes de 20 quetzales  
    double billetesVeite= resul3 / 20;
    double resul4 = resul3 % 20;
    Console.WriteLine(Math.Truncate(billetesVeite) + " Billetes de 20");

    //Billetes de 10 quetzales
    double billeteDiez= resul4 / 10;
    double resul5= resul4 % 10;
    Console.WriteLine(Math.Truncate(billeteDiez) + " Billetes de 10");

    //Billeres de 5 quetzal
    double billeteCinco = resul5 /5;
    double resul6 = resul5 %5;
    Console.WriteLine(Math.Truncate(billeteCinco) + " Billetes de 5");

    //Billeres de 1 quetzal
    double billetesUnQuetz= resul6 / 1;
    double resul7=resul6 % 1;
    Console.WriteLine(Math.Truncate(billetesUnQuetz) + " Billetes de 1");

    //Monedas de 50 centavos
    double moneda50 = resul7 / 0.50;
    double resul8 = resul7 % 0.50;
    Console.WriteLine(Math.Truncate(moneda50) + " Monedas de 0.50");

    //Moneda de 25 centavos
    double moneda25 = resul8 / 0.25;
    double resul9 = resul8 % 0.25;
    Console.WriteLine(Math.Truncate(moneda25) + " Monedas de 0.25");

    //Moneda de 10 centavos
    double moneda10 = resul9 / 0.10;
    double resul10 = resul9 % 0.10;
    Console.WriteLine(Math.Truncate(moneda10) + " Monedas de 0.10");
}
else
{
    Console.WriteLine("El número que ingreso no es correcto");
}
