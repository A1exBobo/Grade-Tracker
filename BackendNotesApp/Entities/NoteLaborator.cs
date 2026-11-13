using System;
using BackendNotesApp.Repositories;

namespace BackendNotesApp.Entities;

public class NoteLaborator
{
    private NoteLaboratorRepo _noteLaboratorRepo = new NoteLaboratorRepo();
    private int _nota;
    public NoteLaborator()
    {
    }
}
