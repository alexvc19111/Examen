class barco:gps,sueldoc
{
    public string nombreb{get;set;}
    public int capacidadp{get;set;}
    public string capacidadc{get;set;}
    public barco(string nombreb,int capacidadp,string capacidadc,string coordenadasx,string coordenadasy,string fecha,string hora, int diastrip):base(coordenadasx,coordenadasy,fecha,hora,diastrip)
    {
        this.nombreb=nombreb;
        this.capacidadp=capacidadp;
        this.capacidadc=capacidadc;
    }
    public void Imprimir()
    {
        Console.WriteLine("|Nombre: "+nombreb+" ||Capacidad de pasajeros: "+capacidadp+"||Capacidad de carga: "+capacidadc);
        Console.WriteLine("|Coordenada x: "+coordenadasx+"||Coordenada y: "+coordenadasy+"||Fecha: "+fecha+"||Hora: "+hora+"||Días tripulados: "+diastrip);
    }
}