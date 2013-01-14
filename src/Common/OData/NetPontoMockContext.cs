﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Linq.Expressions;

namespace NetPonto.App.Common.OData.Api
{
    public class NetPontoMockContext : INetPontoSvc
    {
        #region Context
        public static readonly IQueryable<Localizacao> Localizacoes = new List<Localizacao>()
        {
            new Localizacao { Id = 1, Nome = "SANA Reno Hotel", MoradaLinha1 = "Avenida Duque D'Ávila, n.º 195", MoradaLinha2 = null, CodigoPostal = "1050-082", Cidade = "Lisboa", Pais = "Portugal", CoordenadasGps = null, UrlMapa = "http://www.google.com/maps?f=q&source=s_q&hl=en&geocode=&q=Avenida+Duque+D%C2%B4%C3%81vila,+n%C2%BA+195,+1050-082+Lisboa&sll=37.0625,-95.677068&sspn=39.184175,92.724609&ie=UTF8&ll=38.735825,-9.146547&spn=0.00944,0.022638&z=16&iwloc=A", ImagemMapa = "mapa-sana.png", Direccoes = null },
            new Localizacao { Id = 4, Nome = "Novabase", MoradaLinha1 = "Av. D. João II, Lote 1.03.2.3, Parque das Nações", MoradaLinha2 = null, CodigoPostal = "1998-031", Cidade = "Lisboa", Pais = "Portugal", CoordenadasGps = null, UrlMapa = "http://www.google.pt/maps?f=q&source=s_q&hl=pt-PT&geocode=&q=Novabase&sll=38.769861,-9.099233&sspn=0.009971,0.022638&g=2+Av.+Dom+Jo%C3%A3o+II,+Lisboa,+1990&ie=UTF8&hq=Novabase&hnear=Av.+Dom+Jo%C3%A3o+II+2,+Lisboa&ll=38.765888,-9.097951&spn=0.002493,0.005659&z=18&iwloc=C", ImagemMapa = "mapa-novabase.png", Direccoes = null },
            new Localizacao { Id = 7, Nome = "HIS - Health Innovation Systems", MoradaLinha1 = "Edifício Infanta D. Maria", MoradaLinha2 = "Rua Infanta D. Maria, N24", CodigoPostal = "3030-384", Cidade = "Coimbra", Pais = "Portugal", CoordenadasGps = "40.206764, -8.411307", UrlMapa = "http://www.google.pt/maps?f=q&source=s_q&hl=pt-PT&geocode=&q=40.206764,+-8.411307&aq=&sll=40.205738,-8.410678&sspn=0.010685,0.022724&ie=UTF8&ll=40.206935,-8.412373&spn=0.010685,0.022724&z=16", ImagemMapa = "mapa-his.png", Direccoes = null },
        }.AsQueryable();

        public static readonly IQueryable<Membro> Membros = new List<Membro>()
        {
            new Membro { Id = 1, Nome = "Caio", Apelido = "Proiete", UrlSite = "http://caioproiete.com", UrlBlog = "http://caioproiete.net", UrlTwitter = "http://twitter.com/caioproiete", UrlLinkedIn = "http://pt.linkedin.com/in/caioproiete", UrlFacebook = "http://www.facebook.com/caio.proiete", UrlGooglePlus = "http://plus.google.com/107801119634770959182", UrlGeeklist = "http://geekli.st/caioproiete", UrlGitHub = "http://github.com/caioproiete", UrlBitBucket = "http://bitbucket.org/caioproiete", UrlCodePlex = "http://www.codeplex.com/site/users/view/caioproiete", ImagemSocial = null, Mvp = true, Msft = false, Slug = "caio-proiete", MiniCV = @"O Caio Proiete é consultor independente/<em>freelancer</em> e formador em tecnologias Microsoft na <a href=""http://ciclo.pt"" title=""CICLO Formação e Consultoria"" rel=""friend"">CICLO</a>, em Lisboa / Portugal. <a href=""http://caioproiete.com/Public/uploads/transcript.pdf"" title=""Veja o meu Transcript Report"">Possui diversas certificações técnicas</a>, é <a href=""http://www.microsoft.com/learning/en/us/certification/mct.aspx"" title=""Microsoft Certified Trainer (MCT)"">Microsoft Certified Trainer</a> (MCT) desde 2004, e é <a href=""https://mvp.support.microsoft.com/profile/Caio.Proiete"" title=""Veja o meu perfil MVP no site da Microsoft"">Microsoft Most Valuable Professional</a> (MVP) em ASP .NET desde 2009, pela sua participação activa em comunidades técnicas em Portugal e no Brasil.<br />  <br />  É líder da <a href=""http://netponto.org"" title=""Comunidade NetPonto - A comunidade .NET em Portugal"">Comunidade NetPonto</a>, onde organiza eventos presenciais todos os meses com sessões técnicas sobre desenvolvimento de software na plataforma Microsoft .NET, e já participou como orador em eventos como TechDays Portugal e WebDay, entre outros.<br />  <br />  Seus tópicos de interesse actualmente incluem <a href=""http://asp.net/mvc"" title=""ASP .NET MVC"" rel=""nofollow"">ASP .NET MVC</a>, <a href=""https://developer.mozilla.org/en/HTML/HTML5"" title=""HTML5"" rel=""nofollow"">HTML5</a>, <a href=""https://developer.mozilla.org/en/JavaScript"" title=""JavaScript"" rel=""nofollow"">JavaScript</a>, <a href=""http://jquery.com"" title=""jQuery"" rel=""nofollow"">jQuery</a>, <a href=""http://msdn.microsoft.com/en-us/windows/apps/br229512"" title=""Aplicações 'Metro' para o Windows 8"" rel=""nofollow"">Aplicações 'Metro' para o Windows 8</a>, <a href=""http://silverlight.net"" title=""Silverlight para a Web"" rel=""nofollow"">Silverlight para a Web</a>, <a href=""http://create.msdn.com/en-US/education/basics/silverlight"" title=""Silverlight para Windows Phone"" rel=""nofollow"">Silverlight para Windows Phone</a> e <a href=""http://www.microsoft.com/windowsazure/"" title=""Windows Azure"" rel=""nofollow"">Windows Azure</a>." },
            new Membro { Id = 3, Nome = "Henrry", Apelido = "Pires", UrlSite = null, UrlBlog = "http://henrrypires.wordpress.com", UrlTwitter = "http://twitter.com/henrrypires", UrlLinkedIn = "http://pt.linkedin.com/pub/henri-pires/b/327/137", UrlFacebook = "http://www.facebook.com/henrrypires", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "henrry-pires", MiniCV = null },
            new Membro { Id = 4, Nome = "Bruno", Apelido = "Pires", UrlSite = "http://www.brunopires.me", UrlBlog = "http://blog.blastersystems.com/", UrlTwitter = "http://twitter.com/brunoacpires", UrlLinkedIn = "http://pt.linkedin.com/in/brunopires", UrlFacebook = "http://www.facebook.com/profile.php?id=1473115311", UrlGooglePlus = null, UrlGeeklist = "http://geekli.st/piresbruno", UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "bruno-pires", MiniCV = @"O Bruno Pires exerce funções de consultor de IT na Novabase desde 2008, com experiência de maior relevo nas áreas da banca e televisão digital, onde ganhou competências nas mais várias tecnologias." },
            new Membro { Id = 6, Nome = "Luís", Apelido = "Amorim", UrlSite = null, UrlBlog = null, UrlTwitter = null, UrlLinkedIn = "http://pt.linkedin.com/in/lgamorim", UrlFacebook = null, UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "luis-amorim", MiniCV = null },
            new Membro { Id = 8, Nome = "Bruno", Apelido = "Lopes", UrlSite = "http://www.brunomlopes.com", UrlBlog = "http://blog.brunomlopes.com", UrlTwitter = "http://twitter.com/brunomlopes", UrlLinkedIn = "http://pt.linkedin.com/in/brunomlopes", UrlFacebook = "http://www.facebook.com/brunomlopes", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = "http://github.com/brunomlopes", UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "bruno-lopes", MiniCV = @"Bruno Lopes fez o curso de Engenharia Informática no IST, e neste momento conta com mais de 5 anos de experiência pro-fissional em IT, em particular nas áreas de desenvolvimento de software web-based. Actualmente é co-fundador da <a href=""http://welisten.eu"" title=""weListen Business Solutions"" rel=""friend"">weListen Business Solutions</a>, trabalhando no produto <a href=""http://innovationcast.com/pt"" title=""weListen: InnovationCast"" rel=""friend"">InnovationCast</a>, é um dos organizadores da Comunidade NetPonto e participa activamente, apresentando temas como NHibernate, RavenDB, IoC, PowerShell, entre outros..." },
            new Membro { Id = 10, Nome = "Pedro", Apelido = "Rosa", UrlSite = null, UrlBlog = null, UrlTwitter = "http://twitter.com/pedrorosa", UrlLinkedIn = "http://pt.linkedin.com/in/pedrobarraurosa", UrlFacebook = "http://www.facebook.com/pedrorosa", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "pedro-rosa", MiniCV = null },
            new Membro { Id = 12, Nome = "Paulo", Apelido = "Morgado", UrlSite = "http://paulomorgado.net", UrlBlog = "http://paulomorgado.net/pt/blog", UrlTwitter = "http://twitter.com/paulomorgado", UrlLinkedIn = "http://pt.linkedin.com/in/paulomorgado", UrlFacebook = "http://www.facebook.com/paulo.morgado", UrlGooglePlus = null, UrlGeeklist = "http://geekli.st/PauloMorgado", UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = "http://www.codeplex.com/site/users/show/PauloMorgado", ImagemSocial = null, Mvp = true, Msft = false, Slug = "paulo-morgado", MiniCV = @"O Paulo Morgado é Licenciado em Engenharia Informática pela Faculdade de Ciências da Universidade Nova de Lisboa e bacharel em Electrónica e Telecomunicações (Sistemas Digitais) pelo Instituto Superior de Engenharia de Lisboa. Tem uma certificação MCSD para a plataforma .NET.<br />  <br />  Desempenha funções de arquitecto de software e analista-programador na <a href=""http://www.esi.pt/"" title=""Espírito Santo Informática"" rel=""nofollow"">Espírito Santo Informática</a>.<br />  <br />  Participa nos grupos de notícias portugueses da Microsoft e na comunidade <a href=""http://www.pontonetpt.com/"" title=""Comunidade PontoNetPT"" rel=""nofollow"">PontoNetPT</a> respondendo a questões sobre desenvolvimento de software (com especial enfoque na plataforma .NET)." },
            new Membro { Id = 15, Nome = "Nuno", Apelido = "Gomes", UrlSite = null, UrlBlog = "http://nunogomes.net", UrlTwitter = "http://twitter.com/nmfgomes", UrlLinkedIn = "http://pt.linkedin.com/in/nmgomes", UrlFacebook = "http://www.facebook.com/nunogomes", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = "http://www.codeplex.com/site/users/view/nmgomes", ImagemSocial = null, Mvp = true, Msft = false, Slug = "nuno-gomes", MiniCV = null },
            new Membro { Id = 16, Nome = "Virgílio", Apelido = "Esteves", UrlSite = "http://www.broadscope.eu", UrlBlog = "http://pontonetpt.com/blogs/raposo", UrlTwitter = "http://twitter.com/vraposo", UrlLinkedIn = "http://pt.linkedin.com/in/virgilioesteves", UrlFacebook = "http://www.facebook.com/virgilioesteves", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = true, Msft = false, Slug = "virgilio-esteves", MiniCV = null },
            new Membro { Id = 18, Nome = "João", Apelido = "Manso", UrlSite = null, UrlBlog = "http://joao.manso.eu", UrlTwitter = "http://twitter.com/jnmanso", UrlLinkedIn = "http://pt.linkedin.com/in/jnmanso", UrlFacebook = "http://www.facebook.com/jnmanso", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "joao-manso", MiniCV = null },
            new Membro { Id = 27, Nome = "Niko", Apelido = "Neugebauer", UrlSite = null, UrlBlog = "http://www.nikoport.com", UrlTwitter = "http://twitter.com/nikoneugebauer", UrlLinkedIn = "http://pt.linkedin.com/in/webcaravela", UrlFacebook = "http://www.facebook.com/profile.php?id=531058830", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = true, Msft = false, Slug = "niko-neugebauer", MiniCV = null },
            new Membro { Id = 28, Nome = "Dmitry", Apelido = "Ossipov", UrlSite = "http://ossipov.eu", UrlBlog = null, UrlTwitter = "http://twitter.com/dmitryossipov", UrlLinkedIn = "http://pt.linkedin.com/pub/dmitry-ossipov/1b/619/418", UrlFacebook = "http://www.facebook.com/dmitry.ossipov", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "dmitry-ossipov", MiniCV = @"Dmitry Ossipov é CEO e fundador da <a href=""http://broadscope.eu"" rel=""nofollow"">BroadScope</a>. Possui uma vasta experiencia em User Experience e Design de aplicações para diferentes tipos de plataformas. As áreas tecnológicas de maior interesse são WPF, Silverlight, HTML, CSS, JavaScript e ASP .NET. Dmitry é Microsoft Certified Technology Specialist (MCTS) em Silverlight." },
            new Membro { Id = 31, Nome = "Paulo Aboim", Apelido = "Pinto", UrlSite = null, UrlBlog = "http://pontonetpt.org/blogs/esqueleto/", UrlTwitter = "https://twitter.com/esqueleto", UrlLinkedIn = "http://pt.linkedin.com/pub/paulo-aboim-pinto/2/139/a67", UrlFacebook = "http://www.facebook.com/aboimpinto", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "paulo-aboim-pinto", MiniCV = null },
            new Membro { Id = 32, Nome = "Filipe", Apelido = "Almeida", UrlSite = null, UrlBlog = null, UrlTwitter = null, UrlLinkedIn = "http://pt.linkedin.com/pub/filipe-almeida/22/40b/2b8", UrlFacebook = "http://www.facebook.com/profile.php?id=100001235340235", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "filipe-almeida", MiniCV = null },
            new Membro { Id = 33, Nome = "Vítor", Apelido = "Paulino", UrlSite = null, UrlBlog = null, UrlTwitter = "http://twitter.com/vmpaulino", UrlLinkedIn = "http://pt.linkedin.com/in/vpaulino", UrlFacebook = "http://www.facebook.com/vmlepaulino", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "vitor-paulino", MiniCV = @"Formação académica no ISEL, dinamizador do labNet no ISEL e Consultor da Novabase durante 3 anos e meio no desenvolvimento de aplicações .NET" },
            new Membro { Id = 36, Nome = "Vitor", Apelido = "Pombeiro", UrlSite = null, UrlBlog = null, UrlTwitter = "http://twitter.com/creative_byte", UrlLinkedIn = "http://pt.linkedin.com/pub/v%C3%ADtor-pombeiro/a/a6b/191", UrlFacebook = "http://www.facebook.com/vitor.pombeiro", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "vitor-pombeiro", MiniCV = null },
            new Membro { Id = 37, Nome = "Sandro", Apelido = "Pereira", UrlSite = null, UrlBlog = "http://sandroaspbiztalkblog.wordpress.com", UrlTwitter = "http://twitter.com/sandro_asp", UrlLinkedIn = "http://pt.linkedin.com/in/sandropereira", UrlFacebook = "http://www.facebook.com/sandroasp", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = true, Msft = false, Slug = "sandro-pereira", MiniCV = null },
            new Membro { Id = 38, Nome = "Andreia", Apelido = "Gaita", UrlSite = "http://worldofcoding.com", UrlBlog = "http://blog.worldofcoding.com", UrlTwitter = "http://twitter.com/sh4na", UrlLinkedIn = "http://pt.linkedin.com/in/andreiagaita", UrlFacebook = "http://www.facebook.com/andreia.gaita", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "andreia-gaita", MiniCV = null },
            new Membro { Id = 39, Nome = "João Tito", Apelido = "Lívio", UrlSite = "http://tlivio.org", UrlBlog = "http://msmvps.com/blogs/officept/", UrlTwitter = "http://twitter.com/jlivio", UrlLinkedIn = "http://pt.linkedin.com/in/jlivio", UrlFacebook = "http://www.facebook.com/jlivio", UrlGooglePlus = null, UrlGeeklist = null, UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = true, Msft = false, Slug = "joao-tito-livio", MiniCV = null },
            new Membro { Id = 40, Nome = "Vitor", Apelido = "Tomaz", UrlSite = "http://codeprime.biz", UrlBlog = "http://vitortomaz.blogspot.com/", UrlTwitter = "http://twitter.com/vitortomaz", UrlLinkedIn = "http://pt.linkedin.com/pub/vitor-tomaz/7/981/6b9", UrlFacebook = "http://www.facebook.com/vitorbstomaz", UrlGooglePlus = null, UrlGeeklist = "http://geekli.st/vitortomaz", UrlGitHub = null, UrlBitBucket = null, UrlCodePlex = null, ImagemSocial = null, Mvp = false, Msft = false, Slug = "vitor-tomaz", MiniCV = null },
        }.AsQueryable();

        public static readonly IQueryable<Reuniao> Reunioes = new List<Reuniao>()
        {
            new Reuniao { Id = 1, Titulo = "1ª Reunião Presencial da Comunidade NetPonto em Lisboa", Descricao = "No dia 15-08-2009 foi realizada a 1ª Reunião Presencial da Comunidade NetPonto em Lisboa.", Notas = "", Data = new DateTime(2009, 08, 15), Slug = "1a-reuniao-presencial-da-comunidade-netponto-em-lisboa", UrlRegisto = "http://netponto-lisboa-agosto-2009.eventbrite.com/", ImagemSocial = null, LocalizacaoId = 1 },
            new Reuniao { Id = 21, Titulo = "1ª Reunião Presencial da Comunidade NetPonto em Coimbra", Descricao = "No dia 09-04-2011 foi realizada a 1ª Reunião Presencial da Comunidade NetPonto em Coimbra.", Notas = "", Data = new DateTime(2011, 04, 09), Slug = "1a-reuniao-presencial-da-comunidade-netponto-em-coimbra", UrlRegisto = "http://netponto-coimbra-setembro-2011.eventbrite.com/", ImagemSocial = null, LocalizacaoId = 7 },
            new Reuniao { Id = 27, Titulo = "23ª Reunião Presencial da Comunidade NetPonto em Lisboa", Descricao = @"<h2>Feliz Aniversário Comunidade NetPonto! 2 Anos!!</h2>  <div class=""paragraph"" style=""text-align: left; display: block;"">  No próximo dia 24 de Setembro de 2011 a Comunidade NetPonto comemora o seu segundo aniversário, e convida todos os seus membros (e futuros membros) a vir celebrar connosco.  </div>  <table border=""0"" width=""100%"" cellspacing=""0"" cellpadding=""0"">  <tr>  <td align=""center""><a href=""http://netponto.org/"" title=""2º Aniversário da Comunidade NetPonto""><img src=""http://netponto.org/Content/uploads/reuniao/logo-aniversario-2011.png"" alt="""" /></a></td>  </tr>  <tr>   <td align=""center""><iframe width=""560"" height=""315"" src=""http://www.youtube.com/embed/XWcg_4xqnok?rel=0"" frameborder=""0"" allowfullscreen></iframe></td>  </tr>  </table>  <div class=""paragraph"" style=""text-align: left; display: block;"">   <br />   <a href=""http://picasaweb.google.com/netponto.org/"" title=""Fotos"" target=""_blank"" rel=""nofollow""><img src=""http://netponto.org/Content/uploads/reuniao/thumb-reuniao-01.jpg"" alt="""" align=""right"" /></a>A Comunidade NetPonto realizou em Agosto de 2009 com a sua primeira reunião presencial, onde estiveram presentes pouco mais de 10 pessoas nas instalações de um hotel em Lisboa em pleno Sábado de manhã, com o objectivo de partilharem experiências relacionadas ao desenvolvimento de software na plataforma Microsoft .NET.<br />   <br />   A partir daí, continuamos a organizar reuniões mensais regulares e, dois anos depois, conseguimos atingir a marca de mais de 60 pessoas presentes em nossas reuniões, nas quais os membros apresentam e discutem temas propostos por si.<br />   <br />   <a href=""http://picasaweb.google.com/netponto.org/"" title=""Fotos"" target=""_blank"" rel=""nofollow""><img src=""http://netponto.org/Content/uploads/reuniao/thumb-reuniao-14.jpg"" alt="""" align=""left"" /></a>Nestes últimos dois anos conseguimos realizar mais de vinte eventos presenciais em Lisboa, dois em Coimbra, um em Vila Real e um no Porto, num total de <a href=""http://www.slideshare.net/NetPonto/presentations"" title=""Veja os slides das apresentações que já realizamos!"" target=""_blank"" rel=""nofollow"">mais de 60 apresentações</a> realizadas, muitas delas <a href=""http://www.youtube.com/netpontocomunidade"" title=""Assista os vídeos de algumas das apresentações que já realizamos!"" target=""_blank"" rel=""nofollow"">gravadas em vídeo</a> e que podem ser vistas a qualquer momento via Internet!<br />   <br />   Crescemos em número, mas conseguimos manter sempre o espírito de comunidade aberta e onde todos nós podemos ensinar e aprender uns com os outros.<br />   <br />   Esperamos continuar a crescer com o apoio de todos vocês, e que este tenha sido o segundo ano de muitos outros que virão!  </div>  <div class=""paragraph"" style="" text-align: left; display: block;"">   Para esta ocasião especial decidimos realizar um evento num formato diferente das nossas reuniões tradicionais, e contaremos com quase quinze oradores diferentes, todos eles membros da Comunidade NetPonto e que decidiram partilhar connosco alguns temas que conhecem e gostam, em pequenas sessões de 15 a 30 minutos no máximo.  </div>", Notas = "", Data = new DateTime(2011, 09, 24), Slug = "23a-reuniao-presencial-da-comunidade-netponto-em-lisboa", UrlRegisto = "http://netponto-lisboa-setembro-2011.eventbrite.com/", ImagemSocial = null, LocalizacaoId = 4 },
        }.AsQueryable();

        public static readonly IQueryable<Sessao> Sessoes = new List<Sessao>()
        {
            new Sessao { Id = 1, Hora = "09:30", Titulo = "Recepção dos participantes", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 2, Hora = "10:00", Titulo = "Apresentação da Comunidade NetPonto", Resumo = null, Apresentacao = true, Slug = "apresentacao-da-comunidade-netponto", UrlSlides = "http://www.slideshare.net/netponto/1-reunio-apresentao-da-comunidade-netponto", UrlDemos = null, UrlVideo = null, ImagemSocial = "http://cdn.slidesharecdn.com/apresentaodacomunidade-090827170126-phpapp01-thumbnail-2?1301258402", OradorId = 1, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 3, Hora = "10:20", Titulo = "Um passo em frente com o Entity Framework", Resumo = null, Apresentacao = true, Slug = "um-passo-em-frente-com-o-entity-framework", UrlSlides = "http://www.slideshare.net/netponto/um-passo-em-frente-com-o-entity-framework", UrlDemos = null, UrlVideo = null, ImagemSocial = "http://cdn.slidesharecdn.com/2-umpassoemfrentecomoentityframework-090827211108-phpapp01-thumbnail-2?1301258392", OradorId = 3, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 4, Hora = "11:10", Titulo = "Coffee-break", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 5, Hora = "11:30", Titulo = "Tecnologia .NET em Mundos Virtuais", Resumo = null, Apresentacao = true, Slug = "tecnologia-net-em-mundos-virtuais", UrlSlides = "http://www.slideshare.net/netponto/tecnologia-net-em-mundos-virtuais", UrlDemos = null, UrlVideo = null, ImagemSocial = "http://cdn.slidesharecdn.com/3-tecnologia-netemmundosvirtuais-090829111424-phpapp01-thumbnail-2?1301258386", OradorId = 4, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 6, Hora = "12:20", Titulo = "Introdução ao ASP .NET MVC", Resumo = null, Apresentacao = true, Slug = "introducao-ao-asp-net-mvc", UrlSlides = "http://www.slideshare.net/netponto/introduo-ao-asp-net-mvc", UrlDemos = null, UrlVideo = null, ImagemSocial = "http://cdn.slidesharecdn.com/introduoaoasp-netmvc-090829162838-phpapp01-thumbnail-2?1301258379", OradorId = 1, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 7, Hora = "13:10", Titulo = "Painel de Discussão e Sorteio de Prémios", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 1 },
            new Sessao { Id = 111, Hora = "09:30", Titulo = "Recepção dos participantes", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 2 },
            new Sessao { Id = 112, Hora = "10:00", Titulo = "Design: Necessidade ou desperdício de tempo?", Resumo = @"Todos nós, como developers, já perdemos imenso tempo por causa de ""features"" que os Designers decidem incluir no layout da nossa aplicação. Muitas são as vezes em que fazemos isso sem nos dar ao trabalho de tentar perceber para que servem, pensando apenas nos inúmeros modos elaborados de tortura que poderíamos colocar em prática caso encontrássemos esse tal ""Designer"" ao nosso alcance. Nesta sessão serão apresentados os cenários mais comuns em que isto ocorre e discutido se realmente o trade-off de tempo de desenvolvimento extra vale efectivamente a pena para o ganho geral da aplicação. Quem é que tem/deve ter mais peso? O designer ou o programador? Ou será que os dois poderiam juntar o conhecimento e acelerar o processo de produção?", Apresentacao = true, Slug = "design-necessidade-ou-desperdicio-de-tempo", UrlSlides = "http://www.slideshare.net/netponto/design-necessidade-ou-desperdcio-de-tempo", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=5MZnZ_OiJjA", ImagemSocial = null, OradorId = 28, Orador2Id = null, ReuniaoId = 2 },
            new Sessao { Id = 113, Hora = "11:30", Titulo = "Coffee-break", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 2 },
            new Sessao { Id = 114, Hora = "12:00", Titulo = "Testes? Mas isso não aumenta o tempo de projecto? Não quero...", Resumo = @"Os Testes são cada vez mais uma necessidade nos projectos de desenvolvimento de software... Sejam eles unitários, de carga ou de ""User Interface"", uma boa framework de testes ajuda a resolver os problemas mais cedo, de forma mais eficaz e mais barata. No final da sessão vamos perceber não só para que servem, como são feitos e como o Visual Studio 2010 pode ajudar.", Apresentacao = true, Slug = "testes-mas-isso-nao-aumenta-o-tempo-de-projecto-nao-quero", UrlSlides = "http://www.slideshare.net/netponto/testes-mas-isso-no-aumenta-o-tempo-de-projecto-no-quero", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=ioxtNHdUnjw", ImagemSocial = null, OradorId = 10, Orador2Id = null, ReuniaoId = 2 },
            new Sessao { Id = 115, Hora = "13:30", Titulo = "Painel de Discussão e Sorteio de Prémios", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 2 },
            new Sessao { Id = 141, Hora = "09:45", Titulo = "Recepção dos participantes", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 142, Hora = "10:00", Titulo = "Boas-vindas e Apresentação da Comunidade", Resumo = null, Apresentacao = true, Slug = "boas-vindas-e-apresentacao-da-comunidade", UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = 1, Orador2Id = 8, ReuniaoId = 3 },
            new Sessao { Id = 143, Hora = "10:20", Titulo = "What's New in Windows Azure Platform", Resumo = null, Apresentacao = true, Slug = "what-s-new-in-windows-azure-platform", UrlSlides = "http://www.slideshare.net/netponto/novidades-azure-aps-o-build", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=bskdzTWEyGw", ImagemSocial = null, OradorId = 16, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 144, Hora = "10:40", Titulo = "ASP .NET WebForms - TagMapping e a reciclagem / reutilização de aplicações", Resumo = null, Apresentacao = true, Slug = "asp-net-webforms-tagmapping-e-a-reciclagem-reutilizacao-de-aplicacoes", UrlSlides = "http://www.slideshare.net/netponto/asp-net-webforms-tagmapping", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=UiGD3Pd-WnY", ImagemSocial = null, OradorId = 15, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 145, Hora = "11:10", Titulo = "FluentValidation: Build validation rules for your business objects", Resumo = null, Apresentacao = true, Slug = "fluentvalidation-build-validation-rules-for-your-business-objects", UrlSlides = "http://www.slideshare.net/netponto/fluent-validation", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=AH7oSzX4Ow4", ImagemSocial = null, OradorId = 6, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 146, Hora = "11:30", Titulo = "Coffee-break", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 147, Hora = "12:10", Titulo = "Know your SQL Server: Dynamic Management Views (DMVs)", Resumo = null, Apresentacao = true, Slug = "know-your-sql-server-dynamic-management-views-dmvs", UrlSlides = "http://www.slideshare.net/netponto/know-your-sql-server-dmvs", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=7EFoSSM7VEw", ImagemSocial = null, OradorId = 36, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 148, Hora = "12:30", Titulo = "BizTalk Mapper: Como funcionam os mapas em BizTalk Server 2010", Resumo = null, Apresentacao = true, Slug = "biztalk-mapper-como-funcionam-os-mapas-em-biztalk-server-2010", UrlSlides = "http://www.slideshare.net/netponto/biztalk-mapper-mapas-em-biztalk-server-2010", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=TibuIaacrNw", ImagemSocial = null, OradorId = 37, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 149, Hora = "13:00", Titulo = "Quartz.NET - Agendamento de execução de tarefas", Resumo = null, Apresentacao = true, Slug = "quartz-net-agendamento-de-execucao-de-tarefas", UrlSlides = "http://www.slideshare.net/netponto/quartznet-agendamento-de-tarefas", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=F_Zoe38Sk_g", ImagemSocial = null, OradorId = 33, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 150, Hora = "13:20", Titulo = "Cross-platform Mobile Development with C#", Resumo = null, Apresentacao = true, Slug = "cross-platform-mobile-development-with-csharp", UrlSlides = null, UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=O8DoikhcRUA", ImagemSocial = null, OradorId = 38, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 151, Hora = "13:40", Titulo = "The Clean Coder: A Code of Conduct for Professional Programmers", Resumo = null, Apresentacao = true, Slug = "the-clean-coder-a-code-of-conduct-for-professional-programmers", UrlSlides = "http://www.slideshare.net/netponto/clean-coder", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=-IOBsR2wjAU", ImagemSocial = null, OradorId = 18, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 152, Hora = "14:10", Titulo = "Almoço (Pizzas!!!) ", Resumo = null, Apresentacao = false, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 153, Hora = "15:00", Titulo = "Getting Async with C# 5.0 + Visual Studio 11", Resumo = null, Apresentacao = true, Slug = "getting-async-with-csharp-5-0-visual-studio-11", UrlSlides = "http://www.slideshare.net/netponto/as-novidades-do-csharp-5", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=IfKR1La4Abs", ImagemSocial = null, OradorId = 12, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 154, Hora = "15:20", Titulo = "Criar uma aplicação XAML para Windows 8", Resumo = null, Apresentacao = true, Slug = "criar-uma-aplicacao-xaml-para-windows-8", UrlSlides = "http://www.slideshare.net/netponto/silverlight-no-windows-8", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=LDxYL2mazfk", ImagemSocial = null, OradorId = 31, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 155, Hora = "15:40", Titulo = "Introdução ao Exchange Web Services API", Resumo = null, Apresentacao = true, Slug = "introducao-ao-exchange-web-services-api", UrlSlides = "http://www.slideshare.net/netponto/exchange-web-services-api-introducao", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=z5iVZhjtSIM", ImagemSocial = null, OradorId = 39, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 156, Hora = "16:00", Titulo = "Formas de Herança em Javascript", Resumo = null, Apresentacao = true, Slug = "formas-de-heranca-em-javascript", UrlSlides = null, UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=j6s4rvpSijY", ImagemSocial = null, OradorId = 32, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 157, Hora = "16:20", Titulo = @"Entity Framework 4.1 ""Code-First""", Resumo = null, Apresentacao = true, Slug = "entity-framework-4-1-code-first", UrlSlides = "http://www.slideshare.net/netponto/entity-framework-4-codefirst", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=Ha8P-AHpy-o", ImagemSocial = null, OradorId = 40, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 158, Hora = "16:50", Titulo = "Who needs Stored Procedures anyway?", Resumo = null, Apresentacao = true, Slug = "who-needs-stored-procedures-anyway", UrlSlides = "http://www.slideshare.net/netponto/who-needs-stored-procedures-anyway", UrlDemos = null, UrlVideo = "http://www.youtube.com/watch?v=7_SnVURWIPI", ImagemSocial = null, OradorId = 27, Orador2Id = null, ReuniaoId = 3 },
            new Sessao { Id = 159, Hora = "17:20", Titulo = "Painel de Discussão e Sorteio de Prémios", Resumo = null, Apresentacao = true, Slug = null, UrlSlides = null, UrlDemos = null, UrlVideo = null, ImagemSocial = null, OradorId = null, Orador2Id = null, ReuniaoId = 3 },
        }.AsQueryable();

        public static readonly IQueryable<NivelPatrocinador> NiveisPatrocinadores = new List<NivelPatrocinador>()
        {
            new NivelPatrocinador { Id = 1, Nome = "Gold" },
            new NivelPatrocinador { Id = 2, Nome = "Silver" },
            new NivelPatrocinador { Id = 3, Nome = "Bronze" },
        }.AsQueryable();

        public static readonly IQueryable<Patrocinador> Patrocinadores = new List<Patrocinador>()
        {
            new Patrocinador { Id = 1, Nome = "CICLO", Url = "http://ciclo.pt", LogotipoGold = "logo-ciclo-gold.png", LogotipoSilver = "logo-ciclo-silver.png", LogotipoBronze = null },
            new Patrocinador { Id = 2, Nome = "Microsoft Portugal", Url = "http://www.microsoft.com/portugal", LogotipoGold = "logo-microsoft-gold-2012.png", LogotipoSilver = "logo-microsoft-silver-2012.png", LogotipoBronze = null },
            new Patrocinador { Id = 5, Nome = "Novabase", Url = "http://www.novabase.pt", LogotipoGold = "logo-novabase-gold.png", LogotipoSilver = null, LogotipoBronze = null },
            new Patrocinador { Id = 6, Nome = "Telerik", Url = "http://www.telerik.com", LogotipoGold = null, LogotipoSilver = "logo-telerik-silver.png", LogotipoBronze = null },
            new Patrocinador { Id = 7, Nome = "RedGate", Url = "http://www.red-gate.com", LogotipoGold = null, LogotipoSilver = "logo-redgate-silver.png", LogotipoBronze = "logo-redgate-bronze.png" },
            new Patrocinador { Id = 8, Nome = "JetBrains", Url = "http://www.jetbrains.com", LogotipoGold = null, LogotipoSilver = "logo-jetbrains-silver.png", LogotipoBronze = null },
            new Patrocinador { Id = 16, Nome = "Pluralsight", Url = "http://www.pluralsight.com", LogotipoGold = null, LogotipoSilver = "logo-pluralsight-silver.png", LogotipoBronze = null },
            new Patrocinador { Id = 19, Nome = "HIS - E-Health Innovation Systems", Url = "http://www.his.pt", LogotipoGold = "logo-his-gold.png", LogotipoSilver = null, LogotipoBronze = null },
            new Patrocinador { Id = 20, Nome = "Luis Abreu", Url = "http://blogs.msmvps.com/luisabreu", LogotipoGold = null, LogotipoSilver = "logo-luis-abreu-silver.png", LogotipoBronze = "logo-luis-abreu-bronze.png" },
            new Patrocinador { Id = 23, Nome = "Hibernating Rhinos", Url = "http://hibernatingrhinos.com", LogotipoGold = null, LogotipoSilver = "logo-hibernating-rhinos-silver.png", LogotipoBronze = null },
            new Patrocinador { Id = 24, Nome = "Xamarin", Url = "http://www.xamarin.com", LogotipoGold = null, LogotipoSilver = "logo-xamarin-silver.png", LogotipoBronze = null },
            new Patrocinador { Id = 25, Nome = "CodeSmith Tools", Url = "http://www.codesmithtools.com", LogotipoGold = null, LogotipoSilver = "logo-codesmith-tools-silver.png", LogotipoBronze = null },
        }.AsQueryable();

        public static readonly IQueryable<ReuniaoPatrocinador> ReunioesPatrocinadores = new List<ReuniaoPatrocinador>()
        {
            new ReuniaoPatrocinador { ReuniaoId = 1, PatrocinadorId = 1, NivelId = 1 },
            new ReuniaoPatrocinador { ReuniaoId = 21, PatrocinadorId = 7, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 21, PatrocinadorId = 19, NivelId = 1 },
            new ReuniaoPatrocinador { ReuniaoId = 21, PatrocinadorId = 20, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 2, NivelId = 1 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 5, NivelId = 1 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 6, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 8, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 16, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 23, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 24, NivelId = 2 },
            new ReuniaoPatrocinador { ReuniaoId = 27, PatrocinadorId = 25, NivelId = 2 },
        }.AsQueryable();

        public static readonly IQueryable<RevistaProgramarEdicao> RevistaProgramarEdicoes = new List<RevistaProgramarEdicao>()
        {
        }.AsQueryable();

        public static readonly IQueryable<RevistaProgramarArtigo> RevistaProgramarArtigos = new List<RevistaProgramarArtigo>()
        {
        }.AsQueryable();

        public static readonly IQueryable<RevistaProgramarMembro> RevistaProgramarMembros = new List<RevistaProgramarMembro>()
        {
            new RevistaProgramarMembro { NumeroMembro = 103, Nome = "Caio Proiete", UrlPerfil = "http://www.revista-programar.info/?action=members&type=viewMember&n=103", NetPontoMembroId = 1 },
            new RevistaProgramarMembro { NumeroMembro = 123, Nome = "Bruno Lopes", UrlPerfil = "http://www.revista-programar.info/?action=members&type=viewMember&n=123", NetPontoMembroId = 8 },
            new RevistaProgramarMembro { NumeroMembro = 112, Nome = "Virgílio Esteves", UrlPerfil = "http://www.revista-programar.info/?action=members&type=viewMember&n=112", NetPontoMembroId = 16 },
        }.AsQueryable();

        public static readonly IQueryable<Evento> Eventos = new List<Evento>()
        {
        }.AsQueryable();
        #endregion


        #region INetPontoSvc
        public IDataServiceQuery<Localizacao> Localizacao
        {
            get
            {
                return new DataServiceQueryMock<Localizacao>(NetPontoMockContext.Localizacoes);
                //return new DataServiceQueryWrapper<Localizacao>();
                //NetPontoMockContext.Localizacoes; 
            }
        }

        public IDataServiceQuery<Membro> Membro
        {
            get { return new DataServiceQueryMock<Membro>(NetPontoMockContext.Membros); }
        }

        public IDataServiceQuery<Reuniao> Reuniao
        {
            get { return new DataServiceQueryMock<Reuniao>(NetPontoMockContext.Reunioes); }
        }

        public IDataServiceQuery<Sessao> Sessao
        {
            get { return new DataServiceQueryMock<Sessao>(NetPontoMockContext.Sessoes); }
        }

        public IDataServiceQuery<NivelPatrocinador> NivelPatrocinador
        {
            get { return new DataServiceQueryMock<NivelPatrocinador>(NetPontoMockContext.NiveisPatrocinadores); }
        }

        public IDataServiceQuery<Patrocinador> Patrocinador
        {
            get { return new DataServiceQueryMock<Patrocinador>(NetPontoMockContext.Patrocinadores); }
        }

        public IDataServiceQuery<ReuniaoPatrocinador> ReuniaoPatrocinador
        {
            get { return new DataServiceQueryMock<ReuniaoPatrocinador>(NetPontoMockContext.ReunioesPatrocinadores); }
        }

        public IDataServiceQuery<RevistaProgramarEdicao> RevistaProgramarEdicao
        {
            get { return new DataServiceQueryMock<RevistaProgramarEdicao>(NetPontoMockContext.RevistaProgramarEdicoes); }
        }

        public IDataServiceQuery<RevistaProgramarArtigo> RevistaProgramarArtigo
        {
            get { return new DataServiceQueryMock<RevistaProgramarArtigo>(NetPontoMockContext.RevistaProgramarArtigos); }
        }

        public IDataServiceQuery<RevistaProgramarMembro> RevistaProgramarMembro
        {
            get { return new DataServiceQueryMock<RevistaProgramarMembro>(NetPontoMockContext.RevistaProgramarMembros); }
        }

        public IDataServiceQuery<Evento> Evento
        {
            get { return new DataServiceQueryMock<Evento>(NetPontoMockContext.Eventos); }
        }
        #endregion
    }
}