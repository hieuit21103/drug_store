﻿using drug_store.Controller.Database;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;

namespace drug_store.Controller
{
    public class Invoice
    {
        private int total = 0;
        private float paid = 0;
        private int size;
        private List<int> id;
        private List<int> quantity;
        public Invoice(List<int> id, List<int> quantity, int size)
        {
            this.id = id;
            this.quantity = quantity;
            this.size = size;
        }
        public void generate(string username,string name)
        {
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            DateTimeOffset now = TimeZoneInfo.ConvertTime(DateTimeOffset.Now, localTimeZone);
            string debugPath = Directory.GetCurrentDirectory();
            string projectPath = Directory.GetParent(Directory.GetParent(debugPath).FullName).FullName;
            DateTime today = now.DateTime;
            Application wordApp = new Application();
            wordApp.Visible = false;

            Document document = wordApp.Documents.Add();
            document.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
            document.PageSetup.TopMargin = wordApp.CentimetersToPoints(2.5f);
            document.PageSetup.BottomMargin = wordApp.CentimetersToPoints(2.5f);
            document.PageSetup.LeftMargin = wordApp.CentimetersToPoints(2.5f);
            document.PageSetup.RightMargin = wordApp.CentimetersToPoints(2.5f);

            Paragraph paragraph = document.Content.Paragraphs.Add();
            paragraph.Range.Font.Size = 26;
            paragraph.Range.Font.Bold = 1;
            paragraph.Format.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            paragraph.Format.SpaceAfter = 12;
            paragraph.Range.Text = "Hoá đơn";
            
            Paragraph paragraph1 = document.Content.Paragraphs.Add();
            DbController controller = new DbController();
            List<string> sender = controller.getSenderData(username);
            controller.close();
            paragraph.Range.Font.Bold = 0;
            paragraph.Range.Font.Size = 16;
            paragraph.Range.Text = $"Người lập: {sender[1]}\nMã nhân viên: {sender[0]}\nNgày lập: {today.ToString("dd-MM-yyyy hh:mm:ss")}\nBệnh nhân: {name}\n";
            paragraph.Format.SpaceAfter = 12;
            Table table = document.Tables.Add(paragraph.Range, size + 2, 4);
            table.Borders.Enable = 1;
            table.Rows[1].Cells[1].Range.Text = "STT";
            table.Rows[1].Cells[2].Range.Text = "Tên sản phẩm";
            table.Rows[1].Cells[3].Range.Text = "Số lượng";
            table.Rows[1].Cells[4].Range.Text = "Giá";
            DbController dbController = new DbController();
            for (int i = 2; i <= size+1; i++)
            {
                table.Rows[i].Cells[1].Range.Text = (i-1).ToString();
                for (int j = 0; j < id.Count; j++)
                {
                    List<string> data = dbController.getMedData(id[j]);
                    table.Rows[i].Cells[2].Range.Text = data[5];
                    table.Rows[i].Cells[3].Range.Text = quantity[j].ToString();
                    table.Rows[i].Cells[4].Range.Text = (Int32.Parse(data[4]) * quantity[j]).ToString();
                }
            }
            for (int j = 0; j < id.Count;j++)
            {
                List<string> data = dbController.getMedData(id[j]);
                total += quantity[j];
                paid += float.Parse((Int32.Parse(data[4]) * quantity[j]).ToString());
            }
            table.Rows[size + 2].Cells[1].Range.Text = "Tổng";
            table.Rows[size + 2].Cells[3].Range.Text = $"{total}";
            table.Rows[size + 2].Cells[4].Range.Text = $"{paid}";
            document.SaveAs($"{projectPath}\\Invoices\\{today.ToString("dd-MM-yyyy hh-mm-ss")}.pdf");
            wordApp.Quit();
            dbController.close();
        }

    }
}
