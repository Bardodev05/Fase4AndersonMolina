public class Nodo
{
    public int Valor;
    public Nodo Izquierda;
    public Nodo Derecha;

    public Nodo(int valor)
    {
        this.Valor = valor;
        this.Izquierda = null;
        this.Derecha = null;
    }
}