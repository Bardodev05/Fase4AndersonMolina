public class ArbolBinario
{
    private Nodo raiz;

    public Nodo Raiz => raiz;

    public ArbolBinario()
    {
        raiz = null;
    }

    public void Insertar(int valor)
    {
        raiz = InsertarRecursivo(raiz, valor);
    }

    private Nodo InsertarRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, valor);
        else if (valor > nodo.Valor)
            nodo.Derecha = InsertarRecursivo(nodo.Derecha, valor);

        return nodo;
    }

    public bool Existe(int valor)
    {
        return ExisteRecursivo(raiz, valor);
    }

    private bool ExisteRecursivo(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (nodo.Valor == valor) return true;
        return valor < nodo.Valor
            ? ExisteRecursivo(nodo.Izquierda, valor)
            : ExisteRecursivo(nodo.Derecha, valor);
    }

    public string Preorden()
    {
        return RecorrerPreorden(raiz).Trim();
    }

    private string RecorrerPreorden(Nodo nodo)
    {
        if (nodo == null) return "";
        return nodo.Valor + " " + RecorrerPreorden(nodo.Izquierda) + RecorrerPreorden(nodo.Derecha);
    }

    public string Inorden()
    {
        return RecorrerInorden(raiz).Trim();
    }

    private string RecorrerInorden(Nodo nodo)
    {
        if (nodo == null) return "";
        return RecorrerInorden(nodo.Izquierda) + nodo.Valor + " " + RecorrerInorden(nodo.Derecha);
    }

    public string Postorden()
    {
        return RecorrerPostorden(raiz).Trim();
    }

    private string RecorrerPostorden(Nodo nodo)
    {
        if (nodo == null) return "";
        return RecorrerPostorden(nodo.Izquierda) + RecorrerPostorden(nodo.Derecha) + nodo.Valor + " ";
    }
}