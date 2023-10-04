using SaeControleFrota.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using SaeControleFrota.Report.Model;
using DocumentFormat.OpenXml.InkML;
using System.Data.Entity;

namespace SaeControleFrota
{
    public partial class relatorioMensal : Form
    {
        public List<DadosRelatorio> list { get; set; }

        public List<DateTime> datasNoMes { get; set; }
        public List<Veiculo> listaVeiculos { get; set; }

        public List<LancamentoDiario> listaLancamentos { get; set; }
        public relatorioMensal()
        {
            InitializeComponent();
            listaVeiculos = null;
            list = new List<DadosRelatorio>();
            datasNoMes = new List<DateTime>();
        }
        private void relatorioMensal_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                for (int i = 2020; i<2030; i++)
                {
                    anoDropDown.Items.Add(i);
                }
                foreach (Veiculo item in context.Veiculo.ToList())
                {
                    placaDropdown.Items.Add(item.placa);
                }
            }
            mesDropDown.Items.Add("Janeiro");
            mesDropDown.Items.Add("Fevereiro");
            mesDropDown.Items.Add("Março");
            mesDropDown.Items.Add("Abril");
            mesDropDown.Items.Add("Maio");
            mesDropDown.Items.Add("Junho");
            mesDropDown.Items.Add("Julho");
            mesDropDown.Items.Add("Agosto");
            mesDropDown.Items.Add("Setembro");
            mesDropDown.Items.Add("Outubro");
            mesDropDown.Items.Add("Novembro");
            mesDropDown.Items.Add("Dezembro");


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                reportViewer1.Visible = true;
                int mes;
                int ano = Convert.ToInt32(anoDropDown.Text);
                if (mesDropDown.Text=="Janeiro")
                {
                    mes = 1;
                }
                else if (mesDropDown.Text=="Fevereiro")
                {
                    mes = 2;
                }
                else if (mesDropDown.Text=="Março")
                {
                    mes = 3;
                }
                else if (mesDropDown.Text=="Abril")
                {
                    mes = 4;
                }
                else if (mesDropDown.Text=="Maio")
                {
                    mes = 5;
                }
                else if (mesDropDown.Text=="Junho")
                {
                    mes = 6;
                }
                else if (mesDropDown.Text=="Julho")
                {
                    mes = 7;
                }
                else if (mesDropDown.Text=="Agosto")
                {
                    mes = 8;
                }
                else if (mesDropDown.Text=="Setembro")
                {
                    mes = 9;
                }
                else if (mesDropDown.Text=="Outubro")
                {
                    mes = 10;
                }
                else if (mesDropDown.Text=="Novembro")
                {
                    mes = 11;
                }
                else
                {
                    mes = 12;
                }

                //var queryForRelatorio = (from veiculo in context.Veiculo
                //                         join relatorio in context.LancamentoDiario
                //                         on veiculo.placa equals relatorio.placa
                //                         where relatorio.data.Month == mes
                //                         && veiculo.placa == placaDropdown.Text
                //                         && relatorio.data.Year == ano
                //                         select new
                //                         {
                //                             Placa = veiculo.placa,
                //                             modelo = veiculo.modelo,
                //                             marca = veiculo.marca,
                //                             Mes = relatorio.data.Month,
                //                             Ano = relatorio.data.Year,
                //                             Mororista = relatorio.motorista,
                //                             TipoDeAtividade = relatorio.nomeAtividade,
                //                             ValorToal = veiculo.valorLocacao + relatorio.valorManutencao,
                //                             data = relatorio.data,
                //                         });



                DateTime diaReport = new DateTime(ano, mes, 1);
                int ultimoDiaDoMes = DateTime.DaysInMonth(ano, mes);

                for (int dia = 0; dia < ultimoDiaDoMes; dia++)
                {
                    DateTime diaLancaamento = diaReport.AddDays(dia);

                    var item = (
                            from veiculo in context.Veiculo
                            join relatorio in context.LancamentoDiario on veiculo.placa equals relatorio.placa
                            where
                                veiculo.placa == placaDropdown.Text &&
                               DbFunctions.TruncateTime(relatorio.data) == DbFunctions.TruncateTime(diaLancaamento)
                            select new
                            {
                                Placa = veiculo.placa,
                                modelo = veiculo.modelo,
                                marca = veiculo.marca,
                                Mes = relatorio.data.Month,
                                Ano = relatorio.data.Year,
                                Mororista = relatorio.motorista,
                                TipoDeAtividade = relatorio.nomeAtividade,
                                ValorToal = veiculo.valorLocacao + relatorio.valorManutencao
                            }
                        ).FirstOrDefault();

                    DadosRelatorio dadosRelatorio = new DadosRelatorio
                    {
                        Data = diaLancaamento
                    };

                    if (item != null)
                    {
                        dadosRelatorio.Placa = item.Placa;
                        dadosRelatorio.modelo = item.modelo;
                        dadosRelatorio.marca = item.marca;
                        dadosRelatorio.Mes = item.Mes;
                        dadosRelatorio.Ano = item.Ano;
                        dadosRelatorio.Mororista = item.Mororista;
                        dadosRelatorio.TipoDeAtividade = item.TipoDeAtividade;
                        dadosRelatorio.ValorToal = item.ValorToal ?? 0;
                    }

                    list.Add(dadosRelatorio);
                }

                listaLancamentos = context.LancamentoDiario.Where(x => x.placa.Equals(placaDropdown.Text) && x.data.Month==mes && x.data.Year==ano).ToList();
                listaVeiculos = context.Veiculo.Where(x => x.placa == placaDropdown.Text).ToList();

                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 100;
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", listaLancamentos));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsVeiculo", listaVeiculos));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsAtividadesRealizadas", listaLancamentos));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsVeiculo", listaVeiculos));
                reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
        }

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", listaLancamentos));
                e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", list));
                e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", listaVeiculos));
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

