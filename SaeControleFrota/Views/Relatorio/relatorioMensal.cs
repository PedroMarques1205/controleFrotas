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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
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

                relatorioDataGridView.DataSource = queryForRelatorio;
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
    }
}

