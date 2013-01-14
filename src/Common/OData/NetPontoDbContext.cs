using System;
using System.Linq;

namespace NetPonto.App.Common.OData.Api
{
    public partial class NetPontoDbContext : INetPontoSvc
    {
        #region INetPontoSvc
        public IQueryable<Localizacao> Localizacao
        {
            get { return this.Localizacoes; }
        }

        public IQueryable<Membro> Membro
        {
            get { return this.Membros; }
        }

        public IQueryable<Reuniao> Reuniao
        {
            get { return this.Reunioes; }
        }

        public IQueryable<Sessao> Sessao
        {
            get { return this.Sessoes; }
        }

        public IQueryable<NivelPatrocinador> NivelPatrocinador
        {
            get { return this.NiveisPatrocinadores; }
        }

        public IQueryable<Patrocinador> Patrocinador
        {
            get { return this.Patrocinadores; }
        }

        public IQueryable<ReuniaoPatrocinador> ReuniaoPatrocinador
        {
            get { return this.ReunioesPatrocinadores; }
        }

        public IQueryable<RevistaProgramarEdicao> RevistaProgramarEdicao
        {
            get { return this.RevistaProgramarEdicoes; }
        }

        public IQueryable<RevistaProgramarArtigo> RevistaProgramarArtigo
        {
            get { return this.RevistaProgramarArtigos; }
        }

        public IQueryable<RevistaProgramarMembro> RevistaProgramarMembro
        {
            get { return this.RevistaProgramarMembros; }
        }

        public IQueryable<Evento> Evento
        {
            get { return this.Eventos; }
        } 
        #endregion
    }
}
