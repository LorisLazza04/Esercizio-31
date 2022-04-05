using System.Collections.Generic;

AlberoBinarioIntero albero = new AlberoBinarioIntero(new AlberoBinarioIntero(69));
albero.inserisciSx(89);
albero.inserisciSx(39);
albero.inserisciDx(66);
albero.inserisciSx(2);
albero.inserisciDx(71);
albero.inserisciSx(44);
albero.inserisciDx(12);

albero.stampa();


class AlberoBinarioIntero
{
    int val;
    public int Val { get => val; set => val = value; }
    AlberoBinarioIntero sx;
    public AlberoBinarioIntero Sx { get => sx; set => sx = value; }
    AlberoBinarioIntero dx;
    public AlberoBinarioIntero Dx { get => dx; set => dx = value; }
    AlberoBinarioIntero radice;
    public AlberoBinarioIntero Radice { get => radice; }
    AlberoBinarioIntero curr;
    List<AlberoBinarioIntero> valori = new List<AlberoBinarioIntero>();
    public AlberoBinarioIntero(AlberoBinarioIntero radice)
    {
        this.radice = radice;
        curr = this.radice;
        valori.Add(radice);
    }
    public AlberoBinarioIntero(int val)
    {
        this.val = val;
    }
    public void inserisciSx(int val)
    {
        if (curr.val == 69)
        {
            curr.sx = new AlberoBinarioIntero(val);
            valori.Add(curr.sx);
            curr.dx = new AlberoBinarioIntero(28);
            curr = curr.sx;
        }
        else
        {
            if (curr.val == 2)
            {
                curr = radice.dx;
                valori.Add(curr);
                curr.sx = new AlberoBinarioIntero(44);
                valori.Add(curr.sx);
            }
            else
            {
                curr.sx = new AlberoBinarioIntero(val);
                valori.Add(curr.sx);
            }
        }
    }
    public void inserisciDx(int val)
    {
        curr.dx = new AlberoBinarioIntero(val);
        valori.Add(curr.dx);
        if (val == 28)
        {
            curr = curr.dx;
            return;
        }
        curr = curr.sx;
    }
    public void stampa()
    {
        Stack<AlberoBinarioIntero> pila = new Stack<AlberoBinarioIntero>();
        pila.Push(radice);
        while (pila.Count != 0)
        {
            AlberoBinarioIntero tmp = pila.Pop();
            Console.Write(tmp.val);
            if (tmp.dx != null)
            {
                pila.Push(tmp.dx);
            }
            if (tmp.sx != null)
            {
                pila.Push(tmp.sx);
            }
        }
    }
}
