using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebClientWebSocket
{
    public partial class frmPrincipal : Form
    {

        bool _leituraAtiva = true;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            frmLogin logar = new frmLogin();
            logar.ShowDialog();
            RodapeTexto1.Text = "Usuário: autenticado";
        }

        private async void btnRealizarLeitura_Click(object sender, EventArgs e)
        {
            _leituraAtiva = true;
            btnRealizarLeitura.Visible = false;
            btnPararLeitura.Visible = !btnRealizarLeitura.Visible;
            await LerDadosAsync();
        }

        private void btnPararLeitura_Click(object sender, EventArgs e)
        {
            _leituraAtiva = false;
            btnRealizarLeitura.Visible = false;
            btnPararLeitura.Visible = false;
        }

        private async Task LerDadosAsync()
        {
            using var ws = new ClientWebSocket();
            await ws.ConnectAsync(new Uri("wss://edge-api.axiafutures.com/ws/?token=U2FsdGVkX1+YcfF5A506hKmuKwlK2a4WErOATfH/Ek9GtuMmtY0FbGqnH892r4B8"), CancellationToken.None);

            var tempo = new Stopwatch();
            string textoTempo = string.Empty;
            var buffer = new byte[256];
            var pong1 = Encoding.ASCII.GetBytes($"{{'type':'pong', 'content': 'Enviando requisicao de leitura'}}");
            var pong2 = Encoding.ASCII.GetBytes($"{{'type':'pong', 'content': 'Dados lidos com sucesso'}}");

            tempo.Start();
            while (ws.State == WebSocketState.Open)
            {
                await ws.SendAsync(pong2, WebSocketMessageType.Text, false, CancellationToken.None);
                var result = await ws.ReceiveAsync(buffer, CancellationToken.None);
                if (ws.State != WebSocketState.Open || result.MessageType != WebSocketMessageType.Text || !_leituraAtiva)
                {
                    break;
                }
                await ws.SendAsync(pong2, WebSocketMessageType.Text, false, CancellationToken.None);

                var dados = Encoding.UTF8.GetString(buffer, 0, result.Count);
                dados = dados.Replace("\\", string.Empty).Replace("\"", "'");
                if (!dados.Contains("type"))
                {
                    continue;
                }

                textoTempo = tempo.Elapsed.Seconds.ToString("00") + ":" + tempo.Elapsed.Milliseconds.ToString("0000");
                txtLinhas.AppendText($@"[Tempo Gasto {textoTempo}] {dados} {Environment.NewLine}");

                lblUltimoTipo.Text = FormatarTextoSaida(dados, lblUltimoTipo.Text);
                lbQtdeRegistro.Text = $"Total de registros: {txtLinhas.Lines.Length-1}";

                if (txtLinhas.Lines.Length > NumeroLimite.Value)
                {
                    txtLinhas.Clear();
                }

                tempo.Stop();
                tempo.Restart();
                tempo.Start();
            }

            await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Client closed", default);
            ws.Abort();
            ws.Dispose();

            Task.Delay(15000).Wait();

            btnRealizarLeitura.Visible = true;
            btnPararLeitura.Visible = false;

            return;
        }

        private string FormatarTextoSaida(string texto, string ultimoTexto)
        {
            if (texto.Contains("productGraphData"))            
                return "Tipo = Dados do produto";            

            if (texto.Contains("graphData"))            
                return "Tipo = Gráfico";            

            if (texto.Contains("ERRO"))            
                return "Tipo = Erro";            

            if (texto.Contains("message"))
            {
                string[] tipos = texto.Split(",", StringSplitOptions.None);
                string origem = string.Empty;

                foreach (var item in tipos)
                {
                    if (item.Contains("source"))
                    {
                        string[] partes = item.Split(":", StringSplitOptions.None);
                        if (partes.Length > 1)
                        {
                            origem = partes[1].Replace("'", string.Empty).Trim();
                            break;
                        }
                    }
                }
                return $@"Tipo = Mensagem,Origm:{origem}";
            }

            return ultimoTexto;
        }
                
    }
}
