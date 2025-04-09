using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Water_Bills
{
    public class ExportPDF
    {
        public void ExportDataGridViewToPDF(DataGridView dataGridView, string v)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save PDF File";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        Document document = new Document(PageSize.A4.Rotate(), 20, 20, 20, 20); // Improved margins
                        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                        document.Open();

                        // 🔹 **Add Header Title**
                        Font headerFont = new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD);
                        Paragraph header = new Paragraph("Water Bill Report", headerFont);
                        header.Alignment = Element.ALIGN_CENTER;
                        document.Add(header);

                        document.Add(new Chunk("\n")); // Add space

                        // 🔹 **Create Table with Dynamic Column Width**
                        PdfPTable table = new PdfPTable(dataGridView.ColumnCount);
                        table.WidthPercentage = 100; // Full-page width

                        float[] columnWidths = new float[dataGridView.ColumnCount];
                        for (int i = 0; i < dataGridView.ColumnCount; i++)
                        {
                            columnWidths[i] = dataGridView.Columns[i].Width / 4f; // Scale proportionally
                        }
                        table.SetWidths(columnWidths);

                        // 🔹 **Add Table Headers**
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD)));
                            cell.BackgroundColor = new BaseColor(200, 200, 200); // Light gray header
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }

                        // 🔹 **Add Data Rows with Alternating Colors**
                        bool alternateRow = false;
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? "", new Font(Font.FontFamily.HELVETICA, 10)));
                                    dataCell.HorizontalAlignment = Element.ALIGN_CENTER;

                                    // Apply alternate row shading
                                    if (alternateRow)
                                        dataCell.BackgroundColor = new BaseColor(230, 230, 230); // Light gray

                                    table.AddCell(dataCell);
                                }
                                alternateRow = !alternateRow; // Toggle row color
                            }
                        }

                        document.Add(table);

                        // 🔹 **Add Page Number Footer**
                        PdfContentByte cb = writer.DirectContent;
                        cb.BeginText();
                        cb.SetFontAndSize(BaseFont.CreateFont(), 10);
                        cb.ShowTextAligned(Element.ALIGN_CENTER, "Page " + writer.PageNumber, 550, 20, 0);
                        cb.EndText();

                        document.Close();
                        MessageBox.Show("PDF Export Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
