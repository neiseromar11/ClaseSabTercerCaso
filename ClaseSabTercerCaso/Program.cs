// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese numero de alumnos : ");
int NumAlumnos=int.Parse(Console.ReadLine());
float PagoAlumno = 0;
if (NumAlumnos >= 100)
{
    PagoAlumno = 65.0f;
    
}
else {
    if (NumAlumnos>=50) {
        PagoAlumno = 70.0f;

    }
    else {
        if (NumAlumnos > 30)
        {

            PagoAlumno = 95.0f;

        }
        else {

            PagoAlumno = 4000 / NumAlumnos;
        }
    }
  


}
float TOT = PagoAlumno * NumAlumnos;
Console.WriteLine("El pago individual es " + PagoAlumno
    + "\nEl pago total es " + TOT);

