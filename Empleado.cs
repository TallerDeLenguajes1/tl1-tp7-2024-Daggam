namespace EmpleadoNamespace;
public enum Cargos{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado{

    private string Nombre;
    private string Apellido;
    private DateTime FechaDeNacimiento;
    private char EstadoCivil;
    private DateTime FechaDeIngreso; 
    private double SueldoBasico;
    private Cargos Cargo;

    public Empleado(string nombre, string apellido, DateTime fecha_de_nacimiento, char estado_civil, DateTime fecha_de_ingreso,double sueldo_basico,Cargos cargo){
        Nombre = nombre;
        Apellido = apellido;
        FechaDeNacimiento = fecha_de_nacimiento;
        EstadoCivil = estado_civil;
        FechaDeIngreso = fecha_de_ingreso;
        SueldoBasico = sueldo_basico;
        Cargo = cargo;
    }

    public int antiguedad(){
        return (FechaDeIngreso - DateTime.now()).Year;
    }

    public int edad(){
        return DateTime.now().Year-FechaDeNacimiento.Year;
    }

    public int JubilacionContador(){
        int resultado = 65 - this.edad();
        return (resultado >= 0) ? resultado:0;
    }

    public double salario(){
        double adicional;
        int antiguedad = this.antiguedad();
        if(antiguedad<20){
            adicional += 0.01 * this.SueldoBasico;
        }else{
            adicional += 0.25 * this.SueldoBasico;
        }
        if(this.Cargo == Cargos.Ingeniero || this.Cargo == Cargos.Especialista){
            adicional*=1.5;
        }
        if(this.EstadoCivil == 'C'){
            adicional+=150000;
        }
    }
}