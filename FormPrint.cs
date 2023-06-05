using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharpCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using PdfSharpCore.Pdf.IO;
using PdfSharpCore.Pdf;

namespace project_TelegraphicTransfer
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {

            try
            {
                using(SaveFileDialog sfd =new SaveFileDialog()) 
                {
                    sfd.Filter = "pdf fils (*.pdf)|*.pdf"; //filter pdf .pdf extension


                    if(sfd.ShowDialog() == DialogResult.OK )
                    {
                        PdfDocument doc = new PdfDocument(); //create pdf document
                        doc.Info.Title = "TelegraphicTransfer"; //pdf tital

                       

                        PdfPage page = doc.AddPage(); //add Page
                        page.Width = XUnit.FromMillimeter(210);
                        page.Height = XUnit.FromMillimeter(297);

                        
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        //---TT Desing--
                        XFont fontphagrafe = new XFont("Calibri", 10); // Use a different font
                        XFont fz = new XFont("Calibri", 9);
                        XFont fzb = new XFont("Calibri", 10, XFontStyle.Bold);
                        XFont fzsb = new XFont("Calibri", 9,XFontStyle.Bold);
                        XFontStyle fontStyle = XFontStyle.Bold | XFontStyle.Underline;
                        XFont mainPara = new XFont("Calibri", 14, fontStyle);
                        XBrush brush = XBrushes.Black;
                        //gfx.DrawString("Dinil Elvitigala", fontphagrafe, XBrushes.Black, new XRect(20, 50, 0, 0), XStringFormats.TopLeft);

                        //BOC LOGO and head
                        XImage image = XImage.FromFile(@"C:\Users\HP\source\repos\TTProject_pase1\resourses\boc.png");
                        gfx.DrawImage(image, 20, 10, 80, 80);
                        gfx.DrawString("Traval and Remittance",fontphagrafe,XBrushes.Black,new XRect(20,75,0,0),XStringFormats.TopLeft);
                        gfx.DrawString("1st Floor,Bank of Ceylone,", fontphagrafe, XBrushes.Black, new XRect(20, 85, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("Head office, Colombo 01", fontphagrafe, XBrushes.Black, new XRect(20, 95, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("phone", fontphagrafe, XBrushes.Black, new XRect(20, 105, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("011-2445783", fontphagrafe, XBrushes.Black, new XRect(60, 105, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("011-2203173",fontphagrafe, XBrushes.Black, new XRect(60, 117, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("Email", fontphagrafe, XBrushes.Black, new XRect(20,130, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("travel@boc.lk", fontphagrafe, XBrushes.Black, new XRect(60, 130, 0, 0), XStringFormats.TopLeft);
                        //end logo and details

                        //office use only box
                        XRect recOfficeuse = new XRect(143,37,170,100);
                        XPen pen = new XPen(XColors.Black, 1);
                        gfx.DrawRectangle(pen, recOfficeuse);

                        string office = "OFFICE USE ONLY";
                        string ttref = "TT ref:..................................................";
                        string rf = "Rate & Ref:...........................................";
                        string remark = "Remarks:..............................................";
                        string nostrum = "Nostrum:..............................................";

                        XRect textBoundsOffice = new XRect(recOfficeuse.Left, 45, recOfficeuse.Width, recOfficeuse.Height);
                        gfx.DrawString(office, fzb, brush, textBoundsOffice, XStringFormats.TopCenter);

                        XRect textBoundsTtref = new XRect(150, 67,0,0);
                        gfx.DrawString(ttref, fz,brush, textBoundsTtref, XStringFormats.TopLeft);

                        XRect textBoundsrf = new XRect(150, 82, 0, 0);
                        gfx.DrawString(rf, fz, brush, textBoundsrf, XStringFormats.TopLeft);

                        XRect textBoundsRemark = new XRect(150, 98, 0, 0);
                        gfx.DrawString(remark, fz, brush, textBoundsRemark, XStringFormats.TopLeft);

                        XRect textBoundsNostrm = new XRect(150, 115, 0, 0);
                        gfx.DrawString(nostrum, fz, brush, textBoundsNostrm, XStringFormats.TopLeft);

                        //end office use only box

                        //Branch use only box
                        XRect recBranchuse = new XRect(313, 37, 170, 100);
                        gfx.DrawRectangle(pen, recBranchuse);

                        string branch = "BRANCH USE ONLY";
                        string costCB = "Cost Center  Branch*:.........../...............";
                        string branchRef ="Branch Reference*:...............................";
                        string conP = "Contact Person*:...................................";
                        string tp = "Phone No*:...........................................";
                     
                        XRect textBoundsBranch = new XRect(355, 45, 0, 0);
                        gfx.DrawString(branch, fzb, brush, textBoundsBranch, XStringFormats.TopLeft);

                        XRect textBoundsCostcenter = new XRect(320, 67, 0, 0);
                        gfx.DrawString(costCB, fzsb, brush, textBoundsCostcenter, XStringFormats.TopLeft);

                        XRect textBoundsbranchRef = new XRect(320, 82, 0, 0);
                        gfx.DrawString(branchRef, fzsb, brush, textBoundsbranchRef, XStringFormats.TopLeft);

                        XRect textBoundsconp = new XRect(320, 98, 0, 0);
                        gfx.DrawString(conP, fzsb, brush, textBoundsconp, XStringFormats.TopLeft);

                        XRect textBoundstp = new XRect(320, 115, 0, 0);
                        gfx.DrawString(tp, fzsb, brush, textBoundstp, XStringFormats.TopLeft);
                        //
                        //end Branch Use Only 

                        gfx.DrawString("TELEGRAPHIC TRANSFER ORDER FORM", fontphagrafe, XBrushes.Black, new XRect(60, 130, 0, 0), XStringFormats.TopLeft); //main heading


                        gfx.Dispose();
                        // Save the PDF document
                        string filename = sfd.FileName;
                        doc.Save(filename);
                        doc.Close();
                    }
                }

            }
            catch (Exception ex) 
            { 
             MessageBox.Show(ex.Message);   
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            UCPage2 uCPage2 = new UCPage2();
            uCPage2.Show();
            uCPage2.Dock = DockStyle.Fill;

            pnlt.Controls.Add(uCPage2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlt.Controls.Clear();
            USPage2 uSPage2 = new USPage2();
            uSPage2.Show();
            uSPage2.Dock = DockStyle.Fill;
            pnlt.Controls.Add(uSPage2);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
