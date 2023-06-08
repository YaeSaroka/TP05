static class Escape
{
    private static string[] incognitasSalas = new string[4] {"CECIACM", "33","2","DYYNS"};
    public static int estadoJuego = 1;

public static int GetEstadoJuego(){
    return estadoJuego;
}
public static bool ResolverSala(int Sala, string Incognita){
    if(Sala != estadoJuego){
        return false;
    } 
    else{
       if(Incognita==incognitasSalas[Sala-1]) {
         estadoJuego++;
         return false;
       }
    }
    return true;   
}
}