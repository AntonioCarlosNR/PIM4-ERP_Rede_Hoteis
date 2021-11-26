
//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS

using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using PIM4.Modelo;

namespace PIM4.Classes
{
    class CriaPDF : AbsPropriedades
    {
        public void GeraPDF()
        {
            Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
            doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
            doc.AddCreationDate();//adicionando as configuracoes

            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf
            string caminho = @"C:\Users\anton\Desktop\Antonio_Carlos\Cursos\Unip\terceiro_semestre\PIM_4\pdf\Relatorio.pdf";

            //criando o arquivo pdf embranco, passando como parametro a variavel
            //doc criada acima e a variavel caminho
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            //criando uma string vazia
            string dados = "";

            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));

            //etipulando o alinhamneto
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            //Alinhamento Justificado

            //adicioando texto
            paragrafo.Add("Planilha com os resultados do período\n\n");

            ContasPagar contasPagar = new ContasPagar();
            contasPagar.BuscarPlanilha();

            PdfPTable table = new PdfPTable(3);

            table.AddCell("Fornecedores:" + contasPagar.Fornecedores);
            table.AddCell("Impostos:" + contasPagar.Impostos);
            table.AddCell("Folha_de_Pagamento:" + contasPagar.Folha_de_Pagamento);
            table.AddCell("Beneficios:" + contasPagar.Beneficios);
            table.AddCell("Dividendos:" + contasPagar.Dividendos);
            table.AddCell("Agua_Energia_Eletrica:" + contasPagar.Agua_Energia_Eletrica);
            table.AddCell("Tarifas_Bancarias:" + contasPagar.Tarifas_Bancarias);
            table.AddCell("Material_de_Limpeza:" + contasPagar.Material_de_Limpeza);
            table.AddCell("Material_de_Escritorio:" + contasPagar.Material_de_Escritorio);
            table.AddCell("Manutencao_e_Servicos:" + contasPagar.Manutencao_e_Servicos);
            table.AddCell("Aquisicao_de_Bens_Moveis_e_Maq_e_Equip:" + contasPagar.Aquisicao_de_Bens_Moveis_e_Maq_e_Equip);
            table.AddCell("Consultoria:" + contasPagar.Consultoria);
            table.AddCell("Telefone_e_Internet:" + contasPagar.Telefone_e_Internet);            
           

            //acidionado paragrafo ao documento
            doc.Add(paragrafo);
            doc.Add(table);
            //fechando documento para que seja salva as alteraçoes.
            doc.Close();

            //Abrindo o arquivo após cria-lo.
            //System.Diagnostics.Process.Start(caminho);
        }                 
       
    }
}
