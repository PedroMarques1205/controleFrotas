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

namespace SaeControleFrota
{
    public partial class relatorioMensal : Form
    {
        public relatorioMensal()
        {
            InitializeComponent();
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

                var queryForRelatorio = (from veiculo in context.Veiculo
                                         join relatorio in context.LancamentoDiario
                                         on veiculo.placa equals relatorio.placa
                                         where relatorio.data.Month == mes
                                         && veiculo.placa == placaDropdown.Text
                                         && relatorio.data.Year == ano
                                         select new{
                                             Placa = veiculo.placa,
                                             modelo = veiculo.modelo,
                                             marca = veiculo.marca,
                                             Mes = relatorio.data.Month,
                                             Ano = relatorio.data.Year,
                                             Mororista = relatorio.motorista,
                                             TipoDeAtividade = relatorio.nomeAtividade,
                                             ValorToal = veiculo.valorLocacao + relatorio.valorManutencao
                                         });

                List<DadosRelatorio> list = new List<DadosRelatorio>();
                List<LancamentoDiario> listaLancamentos = new List<LancamentoDiario>();
                foreach (var item in queryForRelatorio)
                {
                    listaLancamentos = context.LancamentoDiario.Where(x => x.placa.Equals(item.Placa)).ToList();
                    list.Add(
                            new DadosRelatorio
                            {
                                Placa = item.Placa,
                                modelo = item.modelo,
                                marca = item.marca,
                                Mes = item.Mes,
                                Ano = item.Ano,
                                Mororista = item.Mororista,
                                TipoDeAtividade = item.TipoDeAtividade,
                                ValorToal = item.ValorToal ?? 0,
                            }
                        );
                }

                List<Veiculo> listaVeiculos = context.Veiculo.Where(x => x.placa == placaDropdown.Text).ToList();

                this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                this.reportViewer1.ZoomPercent = 150;
                
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsVeiculo", listaVeiculos));
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("dsAtividadesRealizadas", listaLancamentos));
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();


               
            }
        }

        private void adicionarNovoVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
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

                    var queryForRelatorio = (from veiculo in context.Veiculo
                                             join relatorio in context.LancamentoDiario
                                             on veiculo.placa equals relatorio.placa
                                             where relatorio.data.Month == mes
                                             && veiculo.placa == placaDropdown.Text
                                             && relatorio.data.Year == ano
                                             select new
                                             {
                                                 Placa = veiculo.placa,
                                                 modelo = veiculo.modelo,
                                                 marca = veiculo.marca,
                                                 Mês = relatorio.data.Month,
                                                 Ano = relatorio.data.Year,
                                                 Mororista = relatorio.motorista,
                                                 TipoDeAtividade = relatorio.nomeAtividade,
                                                 ValorToal = veiculo.valorLocacao + relatorio.valorManutencao
                                             }).ToList();

                    using (SpreadsheetDocument spreadSheet = SpreadsheetDocument.Create("C:\\Users\\pedro.oliveira\\Desktop\\RelatorioMensal.xlsx", SpreadsheetDocumentType.Workbook))
                    {

                        WorkbookPart workBookPart = spreadSheet.AddWorkbookPart(); //não reinicia
                        workBookPart.Workbook = new Workbook(); //n reinicia

                        Sheets sheets = spreadSheet.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());//n reinicia

                        WorksheetPart worksheetPart = workBookPart.AddNewPart<WorksheetPart>();
                        Worksheet workSheet = new Worksheet();
                        SheetData sheetData = new SheetData();

                        Sheet sheet = new Sheet()
                        {
                            Id = spreadSheet.WorkbookPart.
                            GetIdOfPart(worksheetPart),
                            SheetId = 1,
                            Name = "Relatorio"
                        };

                        sheets.Append(sheet);


                        foreach (var item in queryForRelatorio)
                        {
                            DocumentFormat.OpenXml.Spreadsheet.Row row = new DocumentFormat.OpenXml.Spreadsheet.Row();
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.Placa)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.TipoDeAtividade)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.marca)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.modelo)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.Mês)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.Ano)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.Mororista)) });
                            row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.ValorToal)) });
                            sheetData.AppendChild(row);
                        }
                        workSheet.AppendChild(sheetData);
                        worksheetPart.Worksheet = workSheet;

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Arquivo Gerado com sucesso na área de trabalho", "Gerado", buttons, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Erro ao gerar o arquivo", "Error", buttons, MessageBoxIcon.Error);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

