<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SIEI._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron main-paragraph myJumbo">
        <h1>Sistema Integral de Empleo Inclusivo</h1>
        <p class="lead">
            Plataforma de búsqueda de oportunidades laborales para personas que se encuentran en desventaja social al buscar empleo. Las empresas
            registradas se encuentran comprometidas con ofrecer empleo inclusivo u oportunidades para crear tu propia empresa.  
        </p>
    </div>

    <div class = "container descriptions">
         <div class="row">
            <div class="col-xs-6 col-sm-4 section">
                <h2>Empleo</h2>
                <p>
                    Este módulo está enfocado a la población con alguna discapacidad física o cognicitva para poder aplicar a puestos vacantes de empresas con una planilla inclusiva u ofrecer los servicios
                    de trabajos informales. En el caso de la empresa, este módulo le permite publicar los puestos vacantes, además, dar el mantenimiento a los mismos.
                </p>
                <p class ="btn-main">
                    <a class="btn btn-primary " href="http://go.microsoft.com/fwlink/?LinkId=301949">Leer más &raquo;</a>
                </p>
            </div>
            <div class="col-xs-6 col-sm-4 section">
                <h2>Educación</h2>
                <p>
                    Enlace a diferentes plataformas virtuales de educación para que las personas puedan capacitarse en algún área en específico, especialmente en el idioma pero también puede contener otros temas.
                </p>
                <p class ="btn-main">
                    <a class="btn btn-primary " href="http://go.microsoft.com/fwlink/?LinkId=301949">Leer más &raquo;</a>
                </p>
            </div>
            <div class="col-xs-6 col-sm-4  section">
                <h2>Emprendedurismo</h2>
                <p>
                    En este caso se presenta información sobre cómo empezar un negocio, es decir, el proceso que se debe seguir para poder realizar la apertura y el enlace con las entidades que pueden hacer eso realidad con apoyo de algún tipo.
                </p>
                <p class ="btn-main">
                    <a class="btn btn-primary " href="http://go.microsoft.com/fwlink/?LinkId=301950">Leer más &raquo;</a>
                </p>
            </div>
        </div>
    </div>
</asp:Content>
