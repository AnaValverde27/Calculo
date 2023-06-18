<%@ Page Title="Tangente" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tangente.aspx.cs" Inherits="calculo.Tangente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div>
        <label for="gradosInput">Ángulo en grados:</label>
        <asp:TextBox ID="gradosInput" runat="server"></asp:TextBox>
        <asp:Button ID="calcularButton" runat="server" Text="Calcular" OnClick="CalcularTangente_Click" />
        <br />
        <span id="resultadoTexto" runat="server"></span>
    </div>
    <div>
        <canvas id="chartContainer" width="400" height="400"></canvas>
    </div>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.9.4/Chart.min.js"></script>
    <script>
        function generarGrafico(grados) {
            var canvas = document.getElementById("chartContainer");
            var ctx = canvas.getContext("2d");
            var valor = grados;

            var chartData = [valor];
            var labels = [valor];

            var chartOptions = {
                scales: {
                    x: {
                        beginAtZero: true,
                        max: valor
                    },
                    y: {
                        beginAtZero: true
                    }
                }
            };

            var chartConfig = {
                type: 'bar',
                data: {
                    labels: labels,
                    datasets: [{
                        label: 'Valor',
                        data: chartData,
                        backgroundColor: 'rgba(0, 123, 255, 0.2)',
                        borderColor: 'rgba(0, 123, 255, 1)',
                        borderWidth: 1
                    }]
                },
                options: chartOptions
            };

            var myChart = new Chart(ctx, chartConfig);
        }
    </script>
</asp:Content>
