﻿using ScreenSound.Modelos;

namespace PrimeiroProjeto.Modelos;

internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}
