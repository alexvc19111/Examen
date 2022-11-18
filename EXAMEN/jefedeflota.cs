class jefedeflota:tripulantes,sueldoc
{
    double bonopesacodo=0, totaobono=0,bonomariscos=0,sueldototal=0;
    public int pesopescado{get;set;}
    public int pesomariscos{get;set;}
    public int sueldo{get;set;}
    public jefedeflota(string nombre, int telefono, int cedula, string edad,string tiempoempresa,string sexo, int pesopescado,int pesomariscos,int sueldo):base(nombre,telefono,cedula,edad,tiempoempresa,sexo)
    {
        this.pesopescado=pesopescado;
        this.pesomariscos=pesomariscos;
        this.sueldo=sueldo;
    }
    public void bono()
        {
            bonopesacodo=pesopescado*0.01;
            bonomariscos=pesomariscos*0.02;
            totaobono=bonopesacodo+bonomariscos;
            sueldototal=sueldo+totaobono;
        }
    public double sueldoc()
    {
        return (sueldototal);
    }
    public void Imprimir()
    {
        Console.WriteLine("|Nombre: "+nombre+"||Teléfono: "+telefono+"||Cedula :"+cedula+"||Edad: "+edad+"||Tiempo en la empresa: "+tiempoempresa+"||Sexo: "+sexo+"||Bono por pescado: "+ bonopesacodo+"||Bono por mariscos: "+bonomariscos+"||Sueldo base:"+sueldo+"||SueldoTotal :"+sueldototal);
    }

}