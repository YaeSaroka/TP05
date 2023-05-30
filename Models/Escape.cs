public static class Escape
{
    public static string[] incognitasSalas{get;set;}
    private static int estadoJuego{get;set;}=1;

private static void InicializarJuego(){
    incognitasSalas[0]="CECIACM";
    
}
public static int GetEstadoJuego(){
    return estadoJuego;
}
public static bool ResolverSala(int Sala, string Incognita){
    bool estado = false;
    for(int i =0; i<4;i++)
    {
        if(incognitasSalas[i]==null){
            estado= false;
        }
    }
    if(!estado)
    {
        InicializarJuego();
    }
    if(estado){
    if(Sala != estadoJuego) estado=false;
    if(incognitasSalas[Sala-1]==Incognita) {
    estado=true;
    estadoJuego++;
    }
    else estado=false;
    }
    return estado;
   
}



}