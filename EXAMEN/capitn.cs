class capitan:tripulantes,sueldoc
{
    double sueldototal=0;
    double bonoc=0;
    double retbono=0;
    public int horasdeex{get;set;}
    public int sueldo{get;set;}
    public capitan(string nombre, int telefono, int cedula, string edad,string tiempoempresa,string sexo, int horasdeex, int sueldo):base(nombre,telefono,cedula,edad,tiempoempresa,sexo)
    {
        this.horasdeex=horasdeex;
        this.sueldo=sueldo;
    }
    public void bono()
    {
        if (horasdeex>=5000 & horasdeex<150000)
        {
            bonoc=1.20;
        }
        if (horasdeex>=150000 & horasdeex<300000)
        {
            bonoc=1.40;
        }
        if (horasdeex>300000)
        {
            bonoc=1.70;
        }
        retbono=(1-bonoc)*100;

        sueldototal=sueldo*bonoc;
    }
    public double sueldoc()
    {
        return(sueldototal);
    }
    public void Imprimir()
    {
        Console.WriteLine("|Nombre: "+nombre+"||Teléfono: "+telefono+"||Cedula :"+cedula+"||Edad: "+edad+"||Tiempo en la empresa: "+tiempoempresa+"||Sexo: "+sexo+"||Horas de Experticia: "+horasdeex+"||Sueldo base :"+sueldo+"||SueldoTotal :"+sueldototal);
    }



}