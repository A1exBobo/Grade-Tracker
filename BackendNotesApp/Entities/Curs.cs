using System.Data.Common;
using BackendNotesApp;
using BackendNotesApp.Repositories;
public class Curs
{
    private CursRepo _cursRepo = new CursRepo();

    private int _ID;
    private bool _AreDistribuita;

    public Curs()
    {
    }
}