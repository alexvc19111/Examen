class gps
{
    public string coordenadasx{get;set;}
    public string coordenadasy{get;set;}
    public string fecha{get;set;}
    public string hora{get;set;}
    public int diastrip{get;set;}
    public gps(string coordenadasx,string coordenadasy,string fecha,string hora, int diastrip)
    {
        this.coordenadasx=coordenadasx;
        this.coordenadasy=coordenadasy;
        this.fecha=fecha;
        this.hora=hora;
        this.diastrip=diastrip;
    }
}