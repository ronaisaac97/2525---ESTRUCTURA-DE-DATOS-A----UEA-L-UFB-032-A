using System;

// Clase Circulo encapsula el radio como dato privado y proporciona métodos para calcular área y perímetro
public class Circulo
{
    private double radio; // Almacena el radio del círculo

    // Constructor que recibe el radio como argumento
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        // Área = π * radio²
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
        // Perímetro = 2 * π * radio
        return 2 * Math.PI * radio;
    }
}

// Clase Rectangulo encapsula el ancho y alto como datos privados y tiene métodos para área y perímetro
public class Rectangulo
{
    private double ancho;  // Almacena el ancho del rectángulo
    private double alto;   // Almacena el alto del rectángulo

    // Constructor que recibe ancho y alto
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        // Área = ancho * alto
        return ancho * alto;
    }

    // Método para calcular el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        // Perímetro = 2 * (ancho + alto)
        return 2 * (ancho + alto);
    }
}
