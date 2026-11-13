using BackendNotesApp;
using BackendNotesApp.Repositories;
public class Laborator
{
    private LaboratorRepo laboratorRepo = new LaboratorRepo();
    private int _ID;
    private float _notaProiect;
    private float _notaSeminar;
    private int _pondereSeminar;

    public Laborator()
    {
    }
}