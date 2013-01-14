using System;

using NetPonto.App.Common.OData.Api;

namespace NetPonto.App.Common.OData
{
    public interface INetPontoSvc
    {
        IDataServiceQuery<Localizacao> Localizacao { get; }
        IDataServiceQuery<Membro> Membro { get; }
        IDataServiceQuery<Reuniao> Reuniao { get; }
        IDataServiceQuery<Sessao> Sessao { get; }
        IDataServiceQuery<NivelPatrocinador> NivelPatrocinador { get; }
        IDataServiceQuery<Patrocinador> Patrocinador { get; }
        IDataServiceQuery<ReuniaoPatrocinador> ReuniaoPatrocinador { get; }
        IDataServiceQuery<RevistaProgramarEdicao> RevistaProgramarEdicao { get; }
        IDataServiceQuery<RevistaProgramarArtigo> RevistaProgramarArtigo { get; }
        IDataServiceQuery<RevistaProgramarMembro> RevistaProgramarMembro { get; }
        IDataServiceQuery<Evento> Evento { get; }
    }
}
