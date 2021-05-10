using AdManager.Bll;
using AdManager.Controlls;
using AdManager.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Date_Changed = false;
       


        //----------------------------- Eventos não usados nos filtros ---------------------------------
        #region Events
        // Quando o usuário clicar no anúncio desejado, esse método irá pegar todos os dados referentes aquele anuncio
        // de forma que não precise criar o mesmo método para cada anúncio e exibirá em uma nova janela um relatório básico desse anúncio.
        private void Model_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            adsModel model = (adsModel)sender;
            Relatory form = new Relatory();
            Anuncio anuncio = get_anuncio(Convert.ToInt32(model.id));
            double value = anuncio.Value_per_day;
            TimeSpan span = anuncio.End_Date.Date - anuncio.Start_Date.Date;
            double max_range = calc.max_range(value, Convert.ToDouble(RangeCof.Value), Convert.ToInt32(ShareCof.Value), span.Days);
            double default_range = calc.Get_range(value, Convert.ToDouble(RangeCof.Value), span.Days);
            double max_clicks = calc.Get_Clicks(max_range, Convert.ToDouble(ClickCof.Value));
            form.max_clicks = max_clicks.ToString();
            form.max_visualization_without_share = default_range.ToString();
            form.max_visualization_with_share = max_range.ToString();
            form.value = anuncio.Value_per_day.ToString();
            form.Show();

        }

        //Salva os dados do anúncio e adiciona no banco de dados, caso o nome do cliente já exista ele relaciona esse cliente
        //com o que já existe no banco de dados, caso ele não exista, um novo cliente é adicionado.
        private void btnSave_Click(object sender, EventArgs e)
        {
            string result = Components_isOk();
            if(result != "Ok")
            {
                MessageBox.Show(result);
            }
            else
            {
                if (!exist_client(txtClient.Text))
                {
                    new Clientes() { Name = txtClient.Text }.Save();
                }
                try
                {

                    Clientes cliente = get_client(txtClient.Text);
                    new Anuncio() {  Client_Id = cliente.Id , End_Date = dateEnd.Value.Date, Start_Date = dateStart.Value.Date, Name = txtTitle.Text, Value_per_day = Convert.ToDouble(txtValue.Text) }.Save();
                    load_ads();
                    load_cbox();
                    MessageBox.Show("Anuncio Adicionado com Sucesso!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Restaura as configurações padrões da aba "configurações" que é usada para emulação de dados
        private void btnConfigRestore_Click(object sender, EventArgs e)
        {
            RangeCof.Value = 30;
            ShareCof.Value = 4;
            ClickCof.Value = 8;
        }

        //Carrega os anuncios com o método load_ads e também coloca na combobox de cliente da aba anúncio todos os clientes existentes.
        //Esses métodos são carregados sempre que o form é iniciado.
        private void Form1_Load(object sender, EventArgs e)
        {
            load_ads();
            load_cbox();
        }
        #endregion

        //---------------------------------- Métodos utilitários ---------------------------------------

        #region Logical Methods

        // Carrega todos os anuncios que estão no banco de dados e joga em panel para a exibição ao usuário
        private void load_ads()
        {
            adsPanel.Controls.Clear();
            adsPanel.Margin = new Padding(2);
            List<Anuncio> anuncios = Anuncio.get_all();
            foreach (var item in anuncios)
            {
                adsModel model = new adsModel();
                model.id = item.Id.ToString();
                model.name = item.Name;
                model.client = item.Clientes.Name;
                model.datestart = item.Start_Date.Date.ToString();
                model.dateend = item.End_Date.Date.ToString();
                model.value = item.Value_per_day.ToString();
                model.Click += Model_Click;
                model.Cursor = Cursors.Hand;
                model.BackColor = ColorTranslator.FromHtml("#2D2A2E");
                model.ForeColor = Color.White;
                adsPanel.Controls.Add(model);
            }
        }

        //Verifica os campos para garantir que foram preenchidos corretamente e retorna "Ok" caso esteja tudo certo ou retorna
        //os erros caso tenha encontrado algum.
        private string Components_isOk()
        {
            string errors = "";
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errors += "Por favor adicione um título\r\n";
            }
            if (string.IsNullOrEmpty(txtClient.Text))
            {
                errors += "Por favor escreva o nome do cliente\r\n";
            }
            if (string.IsNullOrEmpty(txtValue.Text))
            {
                errors += "Por favor adicione um valor\r\n";
            }
            if (!string.IsNullOrEmpty(txtValue.Text))
            {
                try
                {
                    Convert.ToDouble(txtValue.Text);
                }
                catch
                {
                    errors += "Informe um valor válido, apenas números\r\n";
                }
            }
            if(dateEnd.Value.Date < dateStart.Value.Date)
            {
                errors += "A data final não pode ser anterior a data de início\r\n";
            }
            if (string.IsNullOrEmpty(errors))
            {
                return "Ok";
            }
            else
            {
                return errors;
            }



        }

        //Verifica se o cliente já existe no banco de dados, se sim retorna true, senão false.
        private bool exist_client(string client)
        {
            List<Clientes> c = Clientes.get_all();
            foreach (var item in c)
            {
               if(item.Name.ToLower() == client.ToLower())
                {
                    return true;
                } 
            }
            return false;
        }

        //Retorna a instancia do cliente com o nome específicado, é usado em conjunto com o método 'existe_client'.
        private Clientes get_client(string client)
        {
            List<Clientes> c = Clientes.get_all();
            Clientes result;
            foreach (var item in c)
            {
                if (item.Name.ToLower() == client.ToLower())
                {
                    result = item;
                    return result;
                }
            }
            return null;
        }

        //Retorna a instância do anúncio com o id especificado.
        private Anuncio get_anuncio(int id)
        {
            List<Anuncio> a = Anuncio.get_all();
            Anuncio anuncio = new Anuncio();
            foreach (var item in a)
            {
                if (item.Id == id)
                {
                    anuncio = item;
                }
            }
            return anuncio;
        }

        //Método que adiciona os clientes na combobox da aba anúncio. É istanciado quando o form é iniciado e quando um novo cliente é
        //adicionado.
        private void load_cbox()
        {
            CboxClients.Items.Clear();
            List<Clientes> clientes = Clientes.get_all();
            CboxClients.Items.Add("[none]");
            foreach (var item in clientes)
            {
                CboxClients.Items.Add(item.Name);
            }
            CboxClients.SelectedIndex = 0;
        }
        #endregion

        //----------------------------------------- Filtro ---------------------------------------------
        #region Filter
        //Esses Eventos se referem as buscas por intervalo de tempo, sempre que o valor de cada um dessas datas forem alterados
        //o filtro será atualizado.
        private void datafinal_ValueChanged(object sender, EventArgs e)
        {
            Date_Changed = true;
            filter(Date_Changed);
        }
        private void apartir_ValueChanged(object sender, EventArgs e)
        {
            Date_Changed = true;
            filter(Date_Changed);
        }

        //Carreca os anuncios filtrados, o funcionamento é igual ao 'load_ads', porém somente com os resultados do filtro.
        private void load_Filtered_ads(List<Anuncio> anuncios)
        {
            adsPanel.Controls.Clear();
            adsPanel.Margin = new Padding(2);
            foreach (var item in anuncios)
            {
                adsModel model = new adsModel();
                model.id = item.Id.ToString();
                model.name = item.Name;
                model.client = item.Clientes.Name;
                model.datestart = item.Start_Date.Date.ToString();
                model.dateend = item.End_Date.Date.ToString();
                model.value = item.Value_per_day.ToString();
                model.Click += Model_Click;
                model.Cursor = Cursors.Hand;
                model.BackColor = ColorTranslator.FromHtml("#2D2A2E");
                model.ForeColor = Color.White;
                adsPanel.Controls.Add(model);
            }
        }

        //Método responsável por fazer o filtro dos anúncios.
        private void filter(bool date_changed)
        {
            List<Anuncio> filtered = new List<Anuncio>();

            //Se foi selecionado um cliente e as datas não foram alteradas é adicionado na lista de filtrados todos os anúncios vinculados aquele cliente.
            if (CboxClients.SelectedItem.ToString() != "[none]" && date_changed == false)
            {
                List<Anuncio> anuncios = Anuncio.get_all().Where(b => b.Clientes.Name == CboxClients.SelectedItem.ToString()).ToList();
                filtered = anuncios;
            }
            //Se foi selecionado um cliente e as datas foram alterads é adicionado na lista de filtrados todos o anúncios daquele cliente dentro do intervalo
            //de tempo especificado pelos filtros de data.
            if (CboxClients.SelectedItem.ToString() != "[none]" && date_changed == true)
            {
                List<Anuncio> anuncios = Anuncio.get_all().Where(b => b.Clientes.Name == CboxClients.SelectedItem.ToString()).ToList();
                List<Anuncio> new_anuncios = anuncios.Where(b => b.Start_Date.Date >= apartir.Value.Date && b.End_Date.Date <= datafinal.Value.Date).ToList();
                filtered = new_anuncios;
            }
            //Se não foi selecionado um cliente e as datas foram alteradas é adicionado na lista de filtrados todos os anuncios de todos os cliente dentro do intervalo
            //de tempo especificado
            if (CboxClients.SelectedItem.ToString() == "[none]" && date_changed == true )
            {
                List<Anuncio> anuncios = Anuncio.get_all().Where(b => b.Start_Date.Date >= apartir.Value.Date && b.End_Date.Date <= datafinal.Value.Date).ToList();
                filtered = anuncios;
            }
            //Se não foi selecionado nenhum cliente e as datas não foram alteradas, é carregados todos os anúncios sem filtros
            if (CboxClients.SelectedItem.ToString() == "[none]" && date_changed == false)
            {
                load_ads();
            }

            //Carrega na tela todos os anúncios filtrados
            load_Filtered_ads(filtered);
        }
       
        //Quando o valor da combobox de clientes é alterado, o filtro é atualizado
        private void CboxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboxClients.SelectedItem.ToString() != "[none]")
            {
                filter(Date_Changed);
            }
            else
            {
                load_ads();
            }
        }

        //Botão responsável por resetar os filtros
        private void clearFilters_Click(object sender, EventArgs e)
        {
            Date_Changed = false;
            apartir.Value = DateTime.Now;
            datafinal.Value = DateTime.Now;
            CboxClients.SelectedIndex = 0;
            load_ads();
        }
        #endregion
    }
}
