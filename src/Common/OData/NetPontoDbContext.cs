using System;
using System.Data.Services.Client;

namespace NetPonto.App.Common.OData.Api
{
    public partial class NetPontoDbContext : INetPontoSvc
    {
        #region INetPontoSvc
        public IDataServiceQuery<Localizacao> Localizacao
        {
            get { return new DataServiceQueryWrapper<Localizacao>(this.Localizacoes); }
        }

        public IDataServiceQuery<Membro> Membro
        {
            get { return new DataServiceQueryWrapper<Membro>(this.Membros); }
        }

        public IDataServiceQuery<Reuniao> Reuniao
        {
            get { return new DataServiceQueryWrapper<Reuniao>(this.Reunioes); }
        }

        public IDataServiceQuery<Sessao> Sessao
        {
            get { return new DataServiceQueryWrapper<Sessao>(this.Sessoes); }
        }

        public IDataServiceQuery<NivelPatrocinador> NivelPatrocinador
        {
            get { return new DataServiceQueryWrapper<NivelPatrocinador>(this.NiveisPatrocinadores); }
        }

        public IDataServiceQuery<Patrocinador> Patrocinador
        {
            get { return new DataServiceQueryWrapper<Patrocinador>(this.Patrocinadores); }
        }

        public IDataServiceQuery<ReuniaoPatrocinador> ReuniaoPatrocinador
        {
            get { return new DataServiceQueryWrapper<ReuniaoPatrocinador>(this.ReunioesPatrocinadores); }
        }

        public IDataServiceQuery<RevistaProgramarEdicao> RevistaProgramarEdicao
        {
            get { return new DataServiceQueryWrapper<RevistaProgramarEdicao>(this.RevistaProgramarEdicoes); }
        }

        public IDataServiceQuery<RevistaProgramarArtigo> RevistaProgramarArtigo
        {
            get { return new DataServiceQueryWrapper<RevistaProgramarArtigo>(this.RevistaProgramarArtigos); }
        }

        public IDataServiceQuery<RevistaProgramarMembro> RevistaProgramarMembro
        {
            get { return new DataServiceQueryWrapper<RevistaProgramarMembro>(this.RevistaProgramarMembros); }
        }

        public IDataServiceQuery<Evento> Evento
        {
            get { return new DataServiceQueryWrapper<Evento>(this.Eventos); }
        } 
        #endregion
    }
}
