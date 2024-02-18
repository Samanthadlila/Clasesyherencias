#include <iostream>
#include <string>
using namespace std;

class Transporte{
    private: //Atributos
        string color;
        string nombre;
    
    public://Metodos
         Transporte(string, string);
           void desplazamiento();
};
//Inicializar el Constructor
Transporte::Transporte(string _color, string _nombre){
    color = _color;
    nombre = _nombre;
}

void Trasnporte::desplazamiento(){
    cout << "Transporte: " << nombre << " se esta desplazando" << endl;

}

int main()
{

    Transporte Carro = Transporte("Azul", "Toyota");

    Carro.desplazamiento();


    return 0;
}
