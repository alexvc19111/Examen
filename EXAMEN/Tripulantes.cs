class tripulantes
{
    public string nombre{get;set;}
    public int telefono{get;set;}
    public int cedula{get;set;}
    public string edad{get;set;}
    public string tiempoempresa{get;set;}
    public string sexo{get;set;} 
    public tripulantes(string nombre, int telefono, int cedula, string edad,string tiempoempresa,string sexo)
    {
        this.nombre=nombre;
        this.telefono=telefono;
        this.cedula=cedula;
        this.edad=edad;
        this.tiempoempresa=tiempoempresa;
        this.sexo=sexo;
    }
}