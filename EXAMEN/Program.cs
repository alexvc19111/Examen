internal class Program
{
    private static void Main(string[] args)
    {
        barco b1=new barco("Tercero A",10,"30000 Kg","8´24´54","9´23´21","18/11/2022","09:00",30);
        capitan t1=new capitan("Marcos",098432123,233987654,"20 años","20 años","M",5,4500);
        t1.bono();
        jefedeflota j1=new jefedeflota("Juan",098432123,233987654,"23 años","15 años","M",33,34,3500);
        j1.bono();
        marinero m1=new marinero("Pedro",098432123,233987654,"19 años","10 años","M",200,900);
        m1.bono();
        marinero m2=new marinero("Maria",098432123,233987654,"19 años","10 años","F",200,900);
        m2.bono();
        marinero m3=new marinero("Pedro",098432123,233987654,"19 años","10 años","M",200,900);
        m3.bono();
        List<tripulantes> lista= new List<tripulantes>();
        lista.Add(t1);
        lista.Add(j1);
        lista.Add(m1);
        lista.Add(m2);
        lista.Add(m3);
        foreach(sueldoc x in lista)
        {
            x.Imprimir();
        }

    }
}