class marinero:tripulantes,sueldoc
{
    double bonototal=0,sueldototal=0;
    public double pesototalpescado{get;set;}
    public int sueldo{get;set;}
    public marinero (string nombre, int telefono, int cedula, string edad,string tiempoempresa,string sexo, double pesototalpescado,int sueldo):base(nombre,telefono,cedula,edad,tiempoempresa,sexo)
    {
        this.pesototalpescado=pesototalpescado;
        this.sueldo=sueldo;
    }
    public void bono()
    {
        if(pesototalpescado>=1)
        {
            bonototal=pesototalpescado*0.25;
            sueldototal=bonototal+sueldo;
        }
        else
        {
            sueldototal=sueldo;
            bonototal=0;

        }
    }
    public double sueldoc()
    {
        return(sueldototal);
    }
    public void Imprimir()
    {
        Console.WriteLine("|Nombre: "+nombre+"||Teléfono: "+telefono+"||Cedula :"+cedula+"||Edad: "+edad+"||Tiempo en la empresa: "+tiempoempresa+"||Sexo: "+sexo+"||Bono: "+bonototal+"||Sueldo base:"+sueldo+"||SueldoTotal :"+sueldototal);
    }
}