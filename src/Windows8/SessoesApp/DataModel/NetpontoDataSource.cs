using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using System.Collections.Specialized;
using System.Net.Http;

namespace SessoesApp.Data
{
    [Windows.Foundation.Metadata.WebHostHidden]
    public class SessaoDataItem : SessoesApp.Common.BindableBase
    {
        public SessaoDataItem(String uniqueId, String title, String presenter, String date, String url)
        {
            this._uniqueId = uniqueId;
            this._title = title;
            this._presenter = presenter;
            this._date = date;
            this._url = url;
        }

        private string _uniqueId = string.Empty;
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this.SetProperty(ref this._uniqueId, value); }
        }

        private string _title = string.Empty;
        public string Title
        {
            get { return this._title; }
            set { this.SetProperty(ref this._title, value); }
        }

        private string _presenter = string.Empty;
        public string Presenter
        {
            get { return this._presenter; }
            set { this.SetProperty(ref this._presenter, value); }
        }

        private string _date = string.Empty;
        public string Date
        {
            get { return this._date; }
            set { this.SetProperty(ref this._date, value); }
        }

        private string _url = string.Empty;
        public string Url
        {
            get { return this._url; }
            set { this.SetProperty(ref this._url, value); }
        }

        public override string ToString()
        {
            return this.Title;
        }
    }

    [Windows.Foundation.Metadata.WebHostHidden]
    public class ApresentacaoDataItem : SessoesApp.Common.BindableBase
    {
        public ApresentacaoDataItem(String uniqueId, String title, String presenter, String date, String description, String url)
        {
            this._uniqueId = uniqueId;
            this._title = title;
            this._presenter = presenter;
            this._date = date;
            this._description = description;
            this._url = url;
        }

        private string _uniqueId = string.Empty;
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this.SetProperty(ref this._uniqueId, value); }
        }

        private string _title = string.Empty;
        public string Title
        {
            get { return this._title; }
            set { this.SetProperty(ref this._title, value); }
        }

        private string _presenter = string.Empty;
        public string Presenter
        {
            get { return this._presenter; }
            set { this.SetProperty(ref this._presenter, value); }
        }

        private string _date = string.Empty;
        public string Date
        {
            get { return this._date; }
            set { this.SetProperty(ref this._date, value); }
        }

        private string _description = string.Empty;
        public string Description
        {
            get { return this._description; }
            set { this.SetProperty(ref this._description, value); }
        }

        private string _url = string.Empty;
        public string Url
        {
            get { return this._url; }
            set { this.SetProperty(ref this._url, value); }
        }

        public override string ToString()
        {
            return this.Title;
        }
    }

    public sealed class NetpontoDataSource
    {
        private static NetpontoDataSource _netpontoDataSource = new NetpontoDataSource();

        private ObservableCollection<SessaoDataItem> _sessoes = new ObservableCollection<SessaoDataItem>();
        public ObservableCollection<SessaoDataItem> Sessoes
        {
            get { return this._sessoes; }
        }

        public static IEnumerable<SessaoDataItem> GetSessoes()
        {
            return _netpontoDataSource.Sessoes;
        }

        public static SessaoDataItem GetSessao(string uniqueId)
        {
            var matches = _netpontoDataSource.Sessoes.Where((x) => x.UniqueId.Equals(uniqueId));
            if (matches.Count() == 1) return matches.First();
            return null;
        }

        public static ApresentacaoDataItem GetApresentacao(string uniqueId)
        {
            return null;
        }

        public NetpontoDataSource()
        {
            var httpClient = new HttpClient();
            httpClient.GetAsync("http://netponto.org/sessoes/", HttpCompletionOption.ResponseContentRead)
                .ContinueWith((continuationAction) => {
                    var httpResponseMessage = continuationAction.Result;
                })
                .Start();


            this.Sessoes.Add(new SessaoDataItem(
                "Sessao-1",
                "Testes com Specflow",
                "Sérgio Agostinho",
                "24-11-2012",
                "http://netponto.org/sessao/testes-com-specflow/"
            ));
            this.Sessoes.Add(new SessaoDataItem(
                "Sessao-2",
                "Novidades do C# 5.0",
                "Paulo Morgado [MVP]",
                "24-11-2012",
                "http://netponto.org/sessao/novidades-do-csharp-5/"
            ));
            this.Sessoes.Add(new SessaoDataItem(
                "Sessao-3",
                "Introdução ao AngularJS com ASP.NET MVC",
                "Daniel Gomes",
                "25-08-2012",
                "http://netponto.org/sessao/introducao-ao-angularjs-com-asp-net-mvc/"
            ));
            this.Sessoes.Add(new SessaoDataItem(
                "Sessao-4",
                "Node.js em Windows",
                "Jorge Figueiredo",
                "25-08-2012",
                "http://netponto.org/sessao/node-js-em-windows/"
            ));
            this.Sessoes.Add(new SessaoDataItem(
                "Sessao-5",
                "Windows 8: Como Desenvolver Metro Style Apps",
                "Caio Proiete [MVP]",
                "21-07-2012",
                "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"
            ));


            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));
            this.Sessoes.Add(new SessaoDataItem("Sessao-5", "Windows 8: Como Desenvolver Metro Style Apps", "Caio Proiete [MVP]", "21-07-2012", "http://netponto.org/sessao/windows-8-como-desenvolver-metro-style-apps-lisboa/"));

        }
    }
}
