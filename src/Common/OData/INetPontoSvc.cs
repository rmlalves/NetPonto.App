using System;
using System.Linq;

using NetPonto.App.Common.OData.Api;

namespace NetPonto.App.Common.OData
{
    public interface INetPontoSvc
    {
        IQueryable<Localizacao> Localizacao { get; }
        IQueryable<Membro> Membro { get; }
        IQueryable<Reuniao> Reuniao { get; }
        IQueryable<Sessao> Sessao { get; }
        IQueryable<NivelPatrocinador> NivelPatrocinador { get; }
        IQueryable<Patrocinador> Patrocinador { get; }
        IQueryable<ReuniaoPatrocinador> ReuniaoPatrocinador { get; }
        IQueryable<RevistaProgramarEdicao> RevistaProgramarEdicao { get; }
        IQueryable<RevistaProgramarArtigo> RevistaProgramarArtigo { get; }
        IQueryable<RevistaProgramarMembro> RevistaProgramarMembro { get; }
        IQueryable<Evento> Evento { get; }
    }
}
