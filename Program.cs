using System.Runtime.Intrinsics.Arm;
using System.Text;
using SoftIV_Poo_Clases12_19;
using SoftIV_Poo_Clases12_19.Clases; // Se usa para importar las clases SuperHeroe y SuperPoder
var ImprimirInfo = new ImprimirInfo();

// Instaciar las clases para los super poderes
var poderVolar = new SuperPoder(); // Poder 1
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de volar";
poderVolar.Nivel = NivelPoder.Nivel_2;

var superFuerza = new SuperPoder(); // Poder 2
superFuerza.Nombre = "Super Fuerza";
superFuerza.Descripcion = "Capacidad de tener una fuerza sobrehumana";
superFuerza.Nivel = NivelPoder.Nivel_3;

var superVelocidad = new SuperPoder();  // Poder 3
superVelocidad.Nombre = "Super Velocidad";
superVelocidad.Descripcion = "Capacidad de moverse a velocidades sobrehumanas";
superVelocidad.Nivel = NivelPoder.Nivel_2;

var invisibilidad = new SuperPoder(); // Poder 4
invisibilidad.Nombre = "Invisibilidad";
invisibilidad.Descripcion = "Capacidad de volverse invisible";
invisibilidad.Nivel = NivelPoder.Nivel_1;

var regeneracion = new SuperPoder(); // Poder 5
regeneracion.Nombre = "Regeneracion";
regeneracion.Descripcion = "Capacidad de regenerar heridas rapidamente";
regeneracion.Nivel = NivelPoder.Nivel_3;



// Instanciar la clase para el super heroe
var superman = new SuperHeroe(); // Heroe 1
superman.Id = 1;
superman.Nombre = "       Superman";
superman.IdentidadSecreta = "Clark Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

ImprimirInfo.ImprimirSuperHeroe(superman); // Imprimir la informacion del super heroe usando la clase ImprimirInfo

// Asignar los poderes al super heroe
List<SuperPoder> poderesSuperman = new List<SuperPoder>(); // Lista de poderes
// Agregar los poderes a la lista
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(superVelocidad);
// Asignar la lista de poderes al super heroe
superman.SuperPoderes = poderesSuperman;
string resultSuperPoderes = superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes); // Mostrar los poderes que usa con el metodo UsarSuperPoderes()
string resultSalvarMundo = superman.SalvarElMundo(); // Mostrar el resultado de salvar el mundo
Console.WriteLine(resultSalvarMundo);

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);
Console.WriteLine(); // Salto de linea



var hulk = new SuperHeroe(); // Heroe 2
hulk.Id = 2;
hulk.Nombre = "Hulk";
hulk.IdentidadSecreta = "Bruce Banner";
hulk.Ciudad = "New York";
hulk.PuedeVolar = false;

ImprimirInfo.ImprimirSuperHeroe(hulk); // Imprimir la informacion del super heroe usando la clase ImprimirInfo

// Asignar los poderes al super heroe
List<SuperPoder> poderesHulk = new List<SuperPoder>(); // Lista de poderes
// Agregar los poderes a la lista
poderesHulk.Add(superFuerza);
// Asignar la lista de poderes al super heroe
hulk.SuperPoderes = poderesHulk;
string resultPoderesHulk = hulk.UsarSuperPoderes();
Console.WriteLine(resultPoderesHulk); // Mostrar los poderes que usa con el metodo UsarSuperPoderes()
Console.WriteLine(); // Salto de linea



var wolverine = new AntiHeroe(); // Antihéroe 1
wolverine.Id = 5;
wolverine.Nombre = "Wolverine";
wolverine.IdentidadSecreta = "Logan";
wolverine.Ciudad = "Alberta";
wolverine.PuedeVolar = false;

ImprimirInfo.ImprimirSuperHeroe(wolverine); // Imprimir la informacion del super heroe usando la clase ImprimirInfo

// Asignar los poderes al super heroe
List<SuperPoder> poderesWolverine = new List<SuperPoder>(); // Lista de poderes
// Agregar los poderes a la lista
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(superFuerza);
// Asignar la lista de poderes al super heroe
wolverine.SuperPoderes = poderesWolverine;
string resultPoderesWolverine = wolverine.UsarSuperPoderes();
Console.WriteLine(resultPoderesWolverine); // Mostrar los poderes que usa con el metodo UsarSuperPoderes()

string accionWolverine = wolverine.RealizarAccionDeAntiHeroe("Atacar a la policia.");
Console.WriteLine(accionWolverine); // Mostrar la accion del anti heroe
Console.WriteLine(); // Salto de linea



// Definicion del enum para los niveles de poder
enum NivelPoder
{
    Nivel_1,
    Nivel_2,
    Nivel_3
}