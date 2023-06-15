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
using System.Security.Cryptography;
using PdfSharpCore.Drawing.Layout;

public static class globle
{
    public static string yssno = "YES/NO";
}

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
                        XFont body = new XFont("Calibri", 10);
                        XFont fzsb = new XFont("Calibri", 9,XFontStyle.Bold);
                        XFontStyle fontStyle = XFontStyle.Bold | XFontStyle.Underline;
                        XFont mainPara = new XFont("Calibri", 14, fontStyle);// BOLD AND UNDERLINE
                        XFont fontmainpara = new XFont("Calibri", 14 );
                        XBrush brush = XBrushes.Black;
                        //gfx.DrawString("Dinil Elvitigala", fontphagrafe, XBrushes.Black, new XRect(20, 50, 0, 0), XStringFormats.TopLeft);

                        //BOC LOGO and head
                        XImage image = XImage.FromFile(@"C:\Users\HP\source\repos\TTProject_pase1\resourses\boc.png");
                        gfx.DrawImage(image, 30, 10, 80, 80);
                        gfx.DrawString("Traval and Remittance",fontphagrafe,XBrushes.Black,new XRect(30,75,0,0),XStringFormats.TopLeft);
                        gfx.DrawString("1st Floor,Bank of Ceylone,", fontphagrafe, XBrushes.Black, new XRect(30, 85, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("Head office, Colombo 01", fontphagrafe, XBrushes.Black, new XRect(30, 95, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("phone", fontphagrafe, XBrushes.Black, new XRect(30, 105, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("011-2445783", fontphagrafe, XBrushes.Black, new XRect(70, 105, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("011-2203173",fontphagrafe, XBrushes.Black, new XRect(70, 117, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("Email", fontphagrafe, XBrushes.Black, new XRect(30,130, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("travel@boc.lk", fontphagrafe, XBrushes.Black, new XRect(70, 130, 0, 0), XStringFormats.TopLeft);
                        //end logo and details

                        //office use only box
                        XRect recOfficeuse = new XRect(150,37, 210, 100);
                        XPen pen = new XPen(XColors.Black, 1);
                        gfx.DrawRectangle(pen, recOfficeuse);

                        string office = "OFFICE USE ONLY";
                        string ttref = "TT ref:.........................................................................";
                        string rf = "Rate & Ref:.................................................................";
                        string remark = "Remarks:....................................................................";
                        string nostrum = "Nostrum:....................................................................";

                        XRect textBoundsOffice = new XRect(recOfficeuse.Left, 45, recOfficeuse.Width, recOfficeuse.Height);
                        gfx.DrawString(office, fzb, brush, textBoundsOffice, XStringFormats.TopCenter);

                        XRect textBoundsTtref = new XRect(157, 67,0,0);
                        gfx.DrawString(ttref, fz,brush, textBoundsTtref, XStringFormats.TopLeft);

                        XRect textBoundsrf = new XRect(157, 82, 0, 0);
                        gfx.DrawString(rf, fz, brush, textBoundsrf, XStringFormats.TopLeft);

                        XRect textBoundsRemark = new XRect(157, 98, 0, 0);
                        gfx.DrawString(remark, fz, brush, textBoundsRemark, XStringFormats.TopLeft);

                        XRect textBoundsNostrm = new XRect(157, 115, 0, 0);
                        gfx.DrawString(nostrum, fz, brush, textBoundsNostrm, XStringFormats.TopLeft);

                        //end office use only box

                        //Branch use only box
                        XRect recBranchuse = new XRect(360, 37, 210, 100);
                        gfx.DrawRectangle(pen, recBranchuse);

                        string branch = "BRANCH USE ONLY";
                        string costCB = "Cost Center  Branch*:............/............................";
                        string branchRef ="Branch Reference*:............................................";
                        string conP = "Contact Person*:................................................";
                        string tp = "Phone No*:........................................................";
                     
                        XRect textBoundsBranch = new XRect(427, 45, 0, 0);
                        gfx.DrawString(branch, fzb, brush, textBoundsBranch, XStringFormats.TopLeft);

                        XRect textBoundsCostcenter = new XRect(367, 67, 0, 0);
                        gfx.DrawString(costCB, fzsb, brush, textBoundsCostcenter, XStringFormats.TopLeft);

                        XRect textBoundsbranchRef = new XRect(367, 82, 0, 0);
                        gfx.DrawString(branchRef, fzsb, brush, textBoundsbranchRef, XStringFormats.TopLeft);

                        XRect textBoundsconp = new XRect(367, 98, 0, 0);
                        gfx.DrawString(conP, fzsb, brush, textBoundsconp, XStringFormats.TopLeft);

                        XRect textBoundstp = new XRect(367, 115, 0, 0);
                        gfx.DrawString(tp, fzsb, brush, textBoundstp, XStringFormats.TopLeft);
                        //
                        //end Branch Use Only 

                        //main heading
                        gfx.DrawString("TELEGRAPHIC TRANSFER ORDER FORM", mainPara, XBrushes.Black, new XRect(200, 145, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("STRICTLY IN ENGLISH BLOCK CAPITAL LETTERS", fontmainpara, XBrushes.Black, new XRect(180, 165, 0, 0), XStringFormats.TopLeft);
                        //end main heading

                        //Date box
                        XPen pens = new XPen(XColors.Black, 1);
                        XFont fontDate = new XFont("Arial", 8, XFontStyle.Regular);//font for Date
                        XBrush brushDate = new XSolidBrush(XColor.FromArgb(169,169,169));//brush for date
                        XRect boxRect = new XRect(482, 167, 15, 15);//create date box D
                        XRect boxRect2 = new XRect(496, 167, 15, 15);//D
                        XRect boxRect3 = new XRect(511.5, 167, 15, 15); //m
                        XRect boxRect4 = new XRect(527, 167, 15, 15); //m
                        XRect boxRect5 = new XRect(543, 167, 15, 15); //y
                        XRect boxRect6 = new XRect(557, 167, 15, 15); //y

                        gfx.DrawRectangle(XPens.Black, boxRect);
                        gfx.DrawRectangle(XPens.Black, boxRect2);
                        gfx.DrawRectangle(XPens.Black, boxRect3);
                        gfx.DrawRectangle(XPens.Black, boxRect4);
                        gfx.DrawRectangle(XPens.Black, boxRect5);
                        gfx.DrawRectangle(XPens.Black, boxRect6);

                        string nD = "D";
                        string nD2 = "D";
                        string nM = "M";
                        string nM2 = "M";
                        string nY = "Y";
                        string nY2 = "Y";

                        XRect textboundDate = new XRect(488, 175, 0, 0);
                        gfx.DrawString(nD, fontDate, brushDate, textboundDate, XStringFormats.Center);

                        XRect textboundDate2 = new XRect(504, 175, 0, 0);
                        gfx.DrawString(nD2, fontDate, brushDate, textboundDate2, XStringFormats.Center);

                        XRect textboundMonth = new XRect(519, 175, 0, 0);
                        gfx.DrawString(nM, fontDate, brushDate, textboundMonth, XStringFormats.Center);

                        XRect textboundMonth2 = new XRect(535, 175, 0, 0);
                        gfx.DrawString(nM2, fontDate, brushDate, textboundMonth2, XStringFormats.Center);

                        XRect textboundYear = new XRect(551, 175, 0, 0);
                        gfx.DrawString(nY, fontDate, brushDate, textboundYear, XStringFormats.Center);

                        XRect textboundYrae2 = new XRect(566, 175, 0, 0);
                        gfx.DrawString(nY2, fontDate, brushDate, textboundYrae2, XStringFormats.Center);
                        //END Date Box

                        //Doc Body
                        //topic
                        XPen Hbox = new XPen(XColors.Black, 0.01);
                        XRect mainHeadingsBox = new XRect(30,182,542.5,13);// main heading boxes
                        XBrush brushmaintopic = new XSolidBrush(XColor.FromArgb(0, 0, 0));
                        XFont topic1 = new XFont("Calibri", 10, XFontStyle.Bold);
                        XBrush fillColor = XBrushes.LightGray;
                        
                         gfx.DrawRectangle(Hbox, fillColor, mainHeadingsBox);

                        string Setopic1 = "SENDER (APPLICANT)";
                        XRect textboundTopic1 = new XRect(78, 188, 0, 0); //text aligment
                        gfx.DrawString(Setopic1, topic1, brushmaintopic, textboundTopic1, XStringFormats.Center);
                        //END topig

                        //Sender
                        XRect senderName = new XRect(30,195, 542.5, 13);
                        gfx.DrawRectangle(Hbox, senderName);
                        string sName = "NAME OF THE APPLICANT*";
                        XRect textboundSname = new XRect(33, 195, 0, 0); //text aligment
                        gfx.DrawString(sName, body, brush, textboundSname, XStringFormats.TopLeft);

                        XRect senderAddres = new XRect(30, 208, 542.5, 13);
                        gfx.DrawRectangle(Hbox, senderAddres);
                        string sAddr = "ADDRESS*";
                        XRect textboundAddress = new XRect(33, 208, 0, 0); //text aligment
                        gfx.DrawString(sAddr, body, brush, textboundAddress, XStringFormats.TopLeft);

                        XRect senderAplicB = new XRect(30, 221, 542.5, 13);
                        gfx.DrawRectangle(Hbox, senderAplicB);
                        string sApplicB = "APPLICUNT BUSINESS/PROFESSION*";
                        XRect textboundApplicB = new XRect(33, 221, 0, 0); //text aligment
                        gfx.DrawString(sApplicB, body, brush, textboundApplicB, XStringFormats.TopLeft);

                        XRect senderEmail = new XRect(30, 234, 542.5, 13);
                        gfx.DrawRectangle(Hbox, senderEmail);
                        string sEmail = "EMAIL*";
                        XRect textboundEmail = new XRect(33, 234, 0, 0); //text aligment
                        gfx.DrawString(sEmail, body, brush, textboundEmail, XStringFormats.TopLeft);
                        gfx.DrawString("PHONE*", body, XBrushes.Black, new XRect(350, 234, 0, 0), XStringFormats.TopLeft);

                        XRect senderPassportNic = new XRect(30, 247, 542.5, 35);
                        gfx.DrawRectangle(Hbox, senderPassportNic);
                        string passportNic = "NIC/DRIVING LICENSE/";
                        XRect textboundPassportNic = new XRect(33, 249, 0, 0); //text aligment
                        gfx.DrawString(passportNic, body, brush, textboundPassportNic, XStringFormats.TopLeft);
                        gfx.DrawString("PASSPORT/BUSSINESS REG NO*", body, XBrushes.Black, new XRect(33, 271, 0, 0), XStringFormats.TopLeft);

                        XRect senderIncomTax = new XRect(30, 282, 542.5, 13);
                        gfx.DrawRectangle(Hbox, senderIncomTax);
                        string sIncomeTAx = "INCOM TAX FILE NO/TIN";
                        XRect textboundIncomTax = new XRect(33, 282, 0, 0); //text aligment
                        gfx.DrawString(sIncomeTAx, body, brush, textboundIncomTax, XStringFormats.TopLeft);
                        gfx.DrawString("VAT REGISTRATION NO", body, XBrushes.Black, new XRect(350, 282, 0, 0), XStringFormats.TopLeft);

                        XRect senderPurposeR = new XRect(30, 295, 542.5, 35);
                        gfx.DrawRectangle(Hbox, senderPurposeR);
                        string passportPurposeR = "PURPOSE OF REMITTANCE*";
                        XRect textboundPurposeR = new XRect(33,297, 0, 0); //text aligment
                        gfx.DrawString(passportPurposeR, body, brush, textboundPurposeR, XStringFormats.TopLeft);
                        gfx.DrawString("Inv No/Ref No*", body, XBrushes.Black, new XRect(33, 318, 0, 0), XStringFormats.TopLeft);

                        XRect senderimportantpur = new XRect(30, 330, 542.5, 55);
                        gfx.DrawRectangle(Hbox, senderimportantpur);
                        string passportImportantPur = "FOR IMPORT PURPOSE ONLY ";
                        XRect textboundImportantPur = new XRect(33, 333, 0, 0); //text aligment
                        gfx.DrawString(passportImportantPur, topic1, brush, textboundImportantPur, XStringFormats.TopLeft);
                        gfx.DrawString("DISCRIPTION OF ITEMS*", body, XBrushes.Black, new XRect(33, 350, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("TRADE TERMS /INCONTERM*", body, XBrushes.Black, new XRect(33, 367, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("GOODS CLEARED/NOT CLEARED*", body, XBrushes.Black, new XRect(350, 333, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("HS CODES*", body, XBrushes.Black, new XRect(350, 350, 0, 0), XStringFormats.TopLeft); gfx.DrawString("HS CODES*", body, XBrushes.Black, new XRect(350, 350, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("CUSTDEC/CURIER NO*", body, XBrushes.Black, new XRect(350, 367, 0, 0), XStringFormats.TopLeft);

                        XRect senderStdPay = new XRect(30, 385, 542.5, 30);
                        gfx.DrawRectangle(Hbox, senderStdPay);
                        string sIncomeStdPay = "FOR STUDENT PAYMENT ONLY";
                        XRect textboundStdPay = new XRect(33, 385, 0, 0); //text aligment
                        gfx.DrawString(sIncomeStdPay, topic1, brush, textboundStdPay, XStringFormats.TopLeft);
                        gfx.DrawString("STUDENT NAME*", body, XBrushes.Black, new XRect(33, 400, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("EXCHANGE PERMIT NO", body, XBrushes.Black, new XRect(350, 385, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("STUDENT ID*", body, XBrushes.Black, new XRect(350, 400, 0, 0), XStringFormats.TopLeft);

                        XRect senderSvrpay = new XRect(30, 415, 542.5, 30);
                        gfx.DrawRectangle(Hbox, senderSvrpay);
                        string sIncomeSvrPay = "FOR SERVICE PAYMENT ONLY";
                        XRect textboundSvrPay = new XRect(33, 417, 0, 0); //text aligment
                        gfx.DrawString(sIncomeSvrPay, topic1, brush, textboundSvrPay, XStringFormats.TopLeft);
                        gfx.DrawString("PAYMENT ACCORDANCE WITH THE AGREMENT YES/NO", body, XBrushes.Black, new XRect(33, 430, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("TAX CLEARANCE IS ATTACHED", body, XBrushes.Black, new XRect(350, 417, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("YES/NOT APPLICABLE", topic1, XBrushes.Black, new XRect(350, 430, 0, 0), XStringFormats.TopLeft);

                        // END SENDER

                        //RECEVER
                        //TOPiC
                        XRect mainHeadingsBox2 = new XRect(30, 460, 542.5, 13);
                        gfx.DrawRectangle(Hbox, fillColor, mainHeadingsBox2);
                        
                        string Setopic2 = "RECEIVER (BENEFICIARY)";
                        XRect textboundTopic2 = new XRect(85, 465, 0, 0); //text aligment
                        gfx.DrawString(Setopic2, topic1, brushmaintopic, textboundTopic2, XStringFormats.Center);
                        //end topic

                        XRect recivername = new XRect(30, 473, 542.5, 13);
                        gfx.DrawRectangle(Hbox, recivername);
                        string rName = "NAME OF THE BENEFICIARY*";
                        XRect textboundRname = new XRect(33, 473, 0, 0); //text aligment
                        gfx.DrawString(rName, body, brush, textboundRname, XStringFormats.TopLeft);

                        XRect reciverAdd = new XRect(30, 486, 542.5, 13);
                        gfx.DrawRectangle(Hbox, reciverAdd);
                        string rAdd = "ADDRESS*";
                        XRect textboundRadd = new XRect(33, 486, 0, 0); //text aligment
                        gfx.DrawString(rAdd, body, brush, textboundRadd, XStringFormats.TopLeft);

                        XRect recevercuncy = new XRect(30, 499, 542.5, 30);
                        gfx.DrawRectangle(Hbox, recevercuncy);
                        string rCurrenctTyp = "CURRENCY TYPE*";
                        XRect textboundRcurruncyTyp = new XRect(33, 503, 0, 0); //text aligment
                        gfx.DrawString(rCurrenctTyp, body, brush, textboundRcurruncyTyp, XStringFormats.TopLeft);
                        gfx.DrawString("AMOUNT IN FIGURS*", body, XBrushes.Black, new XRect(33, 515, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("WORDS*", body, XBrushes.Black, new XRect(350, 506, 0, 0), XStringFormats.TopLeft);

                        XRect reciverBname = new XRect(30, 529, 542.5, 13);
                        gfx.DrawRectangle(Hbox, reciverBname);
                        string rBname = "BANK NAME*";
                        XRect textboundRbNamee= new XRect(33, 530, 0, 0); //text aligment
                        gfx.DrawString(rBname, body, brush, textboundRbNamee, XStringFormats.TopLeft);

                        XRect reciverBranch = new XRect(30, 542, 542.5, 13);
                        gfx.DrawRectangle(Hbox, reciverBranch);
                        string rBranch = "BRANCH";
                        XRect textboundRbranch = new XRect(33, 542, 0, 0); //text aligment
                        gfx.DrawString(rBranch, body, brush, textboundRbranch, XStringFormats.TopLeft);
                        gfx.DrawString("COUNTRY*", body, XBrushes.Black, new XRect(350, 542, 0, 0), XStringFormats.TopLeft);

                        XRect reciverAccNo = new XRect(30, 555, 542.5, 13);
                        gfx.DrawRectangle(Hbox, reciverAccNo);
                        string rAccNo = "ACCOUNT NO/IBAN NO*";
                        XRect textboundRAccNo = new XRect(33, 555, 0, 0); //text aligment
                        gfx.DrawString(rAccNo, body, brush, textboundRAccNo, XStringFormats.TopLeft);

                        XRect receverCode = new XRect(30, 568, 542.5, 30);
                        gfx.DrawRectangle(Hbox, receverCode);
                        string rCode = "SORT/ROUTING/FEDWIRE";
                        XRect textboundCode = new XRect(33, 568, 0, 0); //text aligment
                        gfx.DrawString(rCode, body, brush, textboundCode, XStringFormats.TopLeft);
                        gfx.DrawString("ABA/BSB/BANK-BRANCH CODE", body, XBrushes.Black, new XRect(33, 585, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("SWIFT CODE*", body, XBrushes.Black, new XRect(350, 575, 0, 0), XStringFormats.TopLeft);

                        XRect receverCorrespon = new XRect(30, 598, 542.5, 30);
                        gfx.DrawRectangle(Hbox, receverCorrespon);
                        string rCorrespon = "CORRESPONDING/INTERMEDIATE BANK (id Available)";
                        XRect textboundCorrespon = new XRect(33, 598, 0, 0); //text aligment
                        gfx.DrawString(rCorrespon, body, brush, textboundCorrespon, XStringFormats.TopLeft);

                        XRect receverForbank = new XRect(30, 628, 542.5, 30);
                        gfx.DrawRectangle(Hbox, receverForbank);
                        string rForBank = "FORIGN BANK CHARGES TO BE BORN BY*";
                        XRect textboundForBank = new XRect(33, 628, 0, 0); //text aligment
                        gfx.DrawString(rForBank, body, brush, textboundForBank, XStringFormats.TopLeft);
                        gfx.DrawString("APPLICANT", body, XBrushes.Black, new XRect(33, 645, 0, 0), XStringFormats.TopLeft);
                        gfx.DrawString("BENEFICIARY", body, XBrushes.Black, new XRect(100, 645, 0, 0), XStringFormats.TopLeft);
                        XRect receverforingBox1 = new XRect(85, 648, 8, 8);
                        gfx.DrawRectangle(Hbox, receverforingBox1);
                        XRect receverforingBox2 = new XRect(157, 648, 8, 8);
                        gfx.DrawRectangle(Hbox, receverforingBox2);

                        XRect mainHeadingsBox3 = new XRect(30, 675, 542.5, 20);
                        gfx.DrawRectangle(Hbox, fillColor, mainHeadingsBox3);
                        string Setopic3 = "SPECIAL INSTRUCTIONS AND REMARKS TO SENT";
                        XRect textboundTopic3 = new XRect(304, 678  , 0, 0); //text aligment
                        gfx.DrawString(Setopic3, topic1, brushmaintopic, textboundTopic3, XStringFormats.TopCenter);
                        XRect spacialIbs = new XRect(30, 695, 542.5, 65);
                        gfx.DrawRectangle(Hbox, spacialIbs);//heding under tectangle
                        gfx.DrawString("*COMPULSORY", body, XBrushes.Black, new XRect(30, 765, 0, 0), XStringFormats.TopLeft);

                        //END Reciver
                        //end second page

                        //add second page

                        PdfPage page2 = doc.AddPage(); //add Page
                        page.Width = XUnit.FromMillimeter(210);
                        page.Height = XUnit.FromMillimeter(297);
                        XGraphics gfx2 = XGraphics.FromPdfPage(page2);
                        
                        gfx2.DrawString("BRANCH REFERENCE*:.............................................", body, XBrushes.Black, new XRect(573, 27, 0, 0), XStringFormats.TopRight);
                        XFont Pfont = new XFont("Calibri", 7.5);
                        XFont Pfont2 = new XFont("Calibri", 7.5);
                        XFont PfontBold = new XFont("Calibri", 7.5,XFontStyle.Bold);

                        XRect termsBox = new XRect(33, 40, 542.5, 200);
                        gfx2.DrawRectangle(Hbox, termsBox);

                        string termsP1 = "Please advice the above credita at my/our risk and cost by telegraph or SWIFT,either";
                        string termsP2 = "in words of fifues, it is being understood that the bank will not be liable or ";
                        string termsP3 = "responsible for the consequences of ant failure to";
                        string termsP4 = "dispatch/advice/anydelay/mistake/omission/misinterpretation/irregularity/error";
                        string termsP5 = "in indemnification which may happen in or about or after its dispatch/transmission.";
                        string termsP6 = "or receipt, or for any loss/damage caused by any act or omission/negligence or";
                        string termsP7 = "otherwise, or for the retention of the sum should cricumstance be such as, in your ";
                        string termsP8 = "judgment or in the jugment of your agents/correspondents to render such ";
                        string termsP9 = "retention expedient until confirmation by letter of the telegraphic advice or for the";
                        string termsP10 = "consequences thereof.";
                        string termsP11 = "I/We agree to bear the cost of any further charges to which the above transaction";
                        string termsP12 = "may arise.";
                        string termsP13 = "I/We do herby acknowledge that banks reserve the right to choose payment bank";
                        string termsP14 = "chain, advice the credit in appopriate transmission medium/Currency for this credit.";



                        XRect paraText = new XRect(37, 45, 0, 0); //para1
                        gfx2.DrawString(termsP1, Pfont, brush, paraText, XStringFormats.TopLeft);


                        XRect paraText2 = new XRect(37, 53, 0, 0); //para2
                        gfx2.DrawString(termsP2, Pfont, brush, paraText2, XStringFormats.TopLeft);

                        XRect paraText3 = new XRect(37, 61, 0, 0); //para3
                        gfx2.DrawString(termsP3, Pfont, brush, paraText3, XStringFormats.TopLeft);

                        XRect paraText4 = new XRect(37, 69, 0, 0); //para4
                        gfx2.DrawString(termsP4, Pfont, brush, paraText4, XStringFormats.TopLeft);

                        XRect paraText5 = new XRect(37, 77, 0, 0); //para5
                        gfx2.DrawString(termsP5, Pfont, brush, paraText5, XStringFormats.TopLeft);

                        XRect paraText6 = new XRect(37, 86, 0, 0); //para6
                        gfx2.DrawString(termsP6, Pfont, brush, paraText6, XStringFormats.TopLeft);

                        XRect paraText7 = new XRect(37, 95, 0, 0); //para7
                        gfx2.DrawString(termsP7, Pfont, brush, paraText7, XStringFormats.TopLeft);

                        XRect paraText8 = new XRect(37, 104, 0, 0); //para8
                        gfx2.DrawString(termsP8, Pfont, brush, paraText8, XStringFormats.TopLeft);

                        XRect paraText9 = new XRect(37, 113, 0, 0); //para9
                        gfx2.DrawString(termsP9, Pfont, brush, paraText9, XStringFormats.TopLeft);

                        XRect paraText10 = new XRect(37, 123, 0, 0); //para10
                        gfx2.DrawString(termsP10, Pfont, brush, paraText10, XStringFormats.TopLeft);

                        XRect paraText11 = new XRect(37, 150, 0, 0); //para11
                        gfx2.DrawString(termsP11, Pfont, brush, paraText11, XStringFormats.TopLeft);

                        XRect paraText12 = new XRect(37, 159, 0, 0); //para12
                        gfx2.DrawString(termsP12, Pfont, brush, paraText12, XStringFormats.TopLeft);

                        XRect paraText13 = new XRect(37, 186, 0, 0); //para13
                        gfx2.DrawString(termsP13, Pfont, brush, paraText13, XStringFormats.TopLeft);

                        XRect paraText14 = new XRect(37, 195, 0, 0); //para14
                        gfx2.DrawString(termsP14, Pfont, brush, paraText14, XStringFormats.TopLeft);

                        string termsRp1 = "I/We do hereby indemnify and save harmless the Bank issuing a copy of the";
                        string termsRp2 = "telegraphic message/SWIFT to me /us at its sole discretion, as it is a";
                        string termsRp3 = "document of the Bank, which is given for reference,purposes only.Thereby";
                        string termsRp4 = "Bank is not liable for any amendment/alteration/duplication/misuse of this";
                        string termsRp5 = "copy and records preserved at telegraphic system/SWIFT which is/are";
                        string termsRp6 = "denoted as final for any event in question.";
                        string termsRp7 = "I/We do hereby indemnity that this credit is not made for money";
                        string termsRp8 = "laundering, terrorist financing or illegal activities in any state; and bank";
                        string termsRp9 = "reserve the right suspend the transfer for above and/or missing of";
                        string termsRp10 = "required information";
                        string termsRp11 = "I/We herby undertake to submit to you";
                        string termsRpb11 = "within 180 days";
                        string termsRpN11 = "from this date";
                        string termsRp12 = "allowed in current statutes";
                        string termsRpB12 = "copy of commercial invoice and a copy of";
                        string termsRpB13 = "the customs declaration both duly stamped by customs of Sri Lanka ";
                        string termsRp14 = "More Terms and Conditions apply";

                        XRect paraTextR1 = new XRect(330, 45, 0, 0); //pararight1
                        gfx2.DrawString(termsRp1, Pfont, brush, paraTextR1, XStringFormats.TopLeft);

                        XRect paraTextR2 = new XRect(330, 53, 0, 0); //pararight2
                        gfx2.DrawString(termsRp2, Pfont, brush, paraTextR2, XStringFormats.TopLeft);

                        XRect paraTextR3 = new XRect(330, 61, 0, 0); //pararight3
                        gfx2.DrawString(termsRp3, Pfont, brush, paraTextR3, XStringFormats.TopLeft);

                        XRect paraTextR4 = new XRect(330, 70, 0, 0); //pararight4
                        gfx2.DrawString(termsRp4, Pfont, brush, paraTextR4, XStringFormats.TopLeft);

                        XRect paraTextR5 = new XRect(330, 79, 0, 0); //pararight5
                        gfx2.DrawString(termsRp5, Pfont, brush, paraTextR5, XStringFormats.TopLeft);

                        XRect paraTextR6 = new XRect(330, 88, 0, 0); //pararight6
                        gfx2.DrawString(termsRp6, Pfont, brush, paraTextR6, XStringFormats.TopLeft);

                        XRect paraTextR7 = new XRect(330, 105, 0, 0); //pararight7
                        gfx2.DrawString(termsRp7, Pfont, brush, paraTextR7, XStringFormats.TopLeft);

                        XRect paraTextR8 = new XRect(330, 114, 0, 0); //pararight8
                        gfx2.DrawString(termsRp8, Pfont, brush, paraTextR8, XStringFormats.TopLeft);

                        XRect paraTextR9 = new XRect(330, 123, 0, 0); //pararight9
                        gfx2.DrawString(termsRp9, Pfont, brush, paraTextR9, XStringFormats.TopLeft);

                        XRect paraTextR10 = new XRect(330, 132, 0, 0); //pararight10
                        gfx2.DrawString(termsRp10, Pfont, brush, paraTextR10, XStringFormats.TopLeft);

                        XRect paraTextR11 = new XRect(330, 155, 0, 0); //pararight11
                        gfx2.DrawString(termsRp11, Pfont, brush, paraTextR11, XStringFormats.TopLeft);

                        XRect paraTextRb11 = new XRect(450, 155, 0, 0); //pararight11
                        gfx2.DrawString(termsRpb11,PfontBold, brush, paraTextRb11, XStringFormats.TopLeft);

                        XRect paraTextRN11 = new XRect(504, 155, 0, 0); //pararight11
                        gfx2.DrawString(termsRpN11,  Pfont, brush, paraTextRN11, XStringFormats.TopLeft);

                        XRect paraTextRN12 = new XRect(330, 164, 0, 0); //pararight11
                        gfx2.DrawString(termsRp12, Pfont, brush, paraTextRN12, XStringFormats.TopLeft);

                        XRect paraTextRNb12 = new XRect(413, 164, 0, 0); //pararight12
                        gfx2.DrawString(termsRpB12, PfontBold, brush, paraTextRNb12, XStringFormats.TopLeft);

                        XRect paraTextRNb13 = new XRect(330, 173, 0, 0); //pararight12
                        gfx2.DrawString(termsRpB13, PfontBold, brush, paraTextRNb13, XStringFormats.TopLeft);

                        XRect paraTextRN14 = new XRect(330, 215, 0, 0); //pararight13
                        gfx2.DrawString(termsRp14, Pfont, brush, paraTextRN14, XStringFormats.TopLeft);

                        string aceptTerms ="I/We hereby confirm our acceptance to the above terms and conditions and any rules and regulations and any Directions and Guidelines issued by Central Bnak of ";
                        string aceptTermsp1 = "Sri Lanka and statuts enacted by the Government of Sri Lanka and/or any respective authorities for this transaction and I/We pay the Bank in full all amounts";
                        string aaceptTermsp2 = "of this transfer by CASH/CHEQUE (no)......................................................../authorizing the Bank to debit the following Account/Accounts maintained with the bank ";
                        string aaceptTermsp3 = "Account No:............................................At Bank of Ceylon.....................................................Branch";
                        string aaceptTermsp4 = "I/We have read and understood all the above declartions, terms and conditions and signed";

                        XRect termAccept = new XRect(33, 250, 0, 0); 
                        gfx2.DrawString(aceptTerms, Pfont2, brush, termAccept, XStringFormats.TopLeft);

                        XRect termAccept1 = new XRect(33, 260, 0, 0);
                        gfx2.DrawString(aceptTermsp1, Pfont2, brush, termAccept1, XStringFormats.TopLeft);


                        XRect termAccept2 = new XRect(33, 270, 0, 0);
                        gfx2.DrawString(aaceptTermsp2, Pfont2, brush, termAccept2, XStringFormats.TopLeft);

                        XRect termAccept3 = new XRect(33, 280, 0, 0);
                        gfx2.DrawString(aaceptTermsp3, Pfont2, brush, termAccept3, XStringFormats.TopLeft);

                        XRect termAccept4 = new XRect(33, 290, 0, 0);
                        gfx2.DrawString(aaceptTermsp4, fzb, brush, termAccept4, XStringFormats.TopLeft);

                        XRect mainHeadingsBox4 = new XRect(30, 310, 542.5, 20);
                        gfx2.DrawRectangle(Hbox, fillColor, mainHeadingsBox4);
                        string Setopic4 = "SIGNATORIES* (Customer(s)/Remitter(s)/Applicat(s)/Authorized Person(s))";
                        XRect textboundTopic4 = new XRect(304, 312, 0, 0); //text aligment
                        gfx2.DrawString(Setopic4, topic1, brushmaintopic, textboundTopic4, XStringFormats.TopCenter);
                        XRect signature = new XRect(30, 330, 542.5, 65);
                        gfx2.DrawRectangle(Hbox, signature);//heding under tectangle
                        gfx2.DrawString("*COMPULSORY", fzb, XBrushes.Black, new XRect(30, 400, 0, 0), XStringFormats.TopLeft);

                        //cheakList
                        string fontName = "Calibri";
                        XFontStyle fontStyle2 = XFontStyle.Bold | XFontStyle.Underline;
                        XFont cListNormal = new XFont(fontName, 7.5);
                        XFont cList = new XFont(fontName, 7.5, fontStyle2);
                        XFont cList2 = new XFont(fontName, 7.5, XFontStyle.Underline);
                        XFont cList3 = new XFont(fontName, 7.5, XFontStyle.Bold);

                        XRect cheakList = new XRect(30, 418, 542.5, 400);
                        gfx2.DrawRectangle(Hbox, cheakList);

                        string ceckListtitle= "FOR BOC BRANCH USE ONLY*";
                        string ceckListtitle2 = "TO: Travel and Remittances Dept";
                        string ceckListtitle3 = "Please issue the above credit on TelegraphicTransfer of SWIFT on behalf of us.";
                        string ceckListtitle4 = "CHECHLIST";
                        string ceckList1 = "  1.            Availabilty of Indemnity/ Customer visited to branch to do the transaction.";
                        string ceckList2 = "  2.            Details of the customer request request tallies with core banking system/mandate/other correspondence/previous request.";
                        string ceckList3 = "  3.            Confirmation obtained through other sources of communication ";
                        string ceckListSub3 = "                 (Do not use details appearing in the letter of request, but use other contact details registered with the Bank) ";
                        string ceckList4 = "  4.            Purpose of fund transfer is acceptable ";
                        string ceckList5 = "  5.            Value of fund transfer is acceptable ";
                        string ceckListSub5 = "                 (Compared to previous details of transactions and nature of business of the customer)";
                        string ceckList6 = "  6.            Beneficiary/bank/country is not irregular compared to previous transaction ";
                        string ceckList7 = "  7.            Fund Transfer is not intended to suspicious destinations";
                        string ceckList8 = "  8.            Authority leveles and singnatures match with operating instructions given to the bank";
                        string ceckList9 = "  9.            Cross Checked that the transaction has not been duplicated";
                        string ceckListSub9 = "                  (i.e check whether request recived both through post and fax/e-mail) ";
                        string ceckList10 = " 10.           Placed our Reference number in each face of each of the document before send it to you in email for preventing";
                        string ceckListS10 = "                 any duplication causing by transmission failures/duplications";
                        string ceckList11 = " 11.           SRI LANKA RUPEE accounts :: Central bank of Sri Lanka From 1 E/sales is enclosed";
                        string ceckList12 = " 12.           SRI LANKA RUPEE accounts :: invoice of imports or Documents of education";
                        string ceckList13 = " 13.           SRI LANKA RUPEE accounts :: Invoice is addressed as per Name and address of the account holder";
                        string ceckList14 = " 14.           SRI LANKA RUPEE accounts :: Credited SWIFT CHARGES RECOVERD ACCOUNT (52401053) cost";
                        string ceckListS14 = "                  center 087 for LKR";
                        string ceckList15 = " 15.           FOREIGN CURRUNCY BFCA account only :: Credited  COM ACC TRAVEL AND REMITTANCES (52302001) COST";
                        string ceckListS15 = "                  center 087 for LKR";
                        string ceckList16 = " 16.           FOREIGN CURRUNCY account only :: Credited TT SETTLEMENT ACC (22310372) of our branch cost center in";
                        string ceckListS16 = "                  FOREIGN CURRUNCY For TT amount of .......................................... and Correspondent Banking Charges";
                        string ceckListS216 = "                  of..................................................with total amount as......................................................";





                        XRect cheklisttital = new XRect(60, 420, 0, 0);
                        gfx2.DrawString(ceckListtitle, cList, brush, cheklisttital, XStringFormats.TopLeft);

                        XRect cheklisttital2 = new XRect(60, 430, 0, 0);
                        gfx2.DrawString(ceckListtitle2, cList2, brush, cheklisttital2, XStringFormats.TopLeft);

                        XRect cheklisttital3 = new XRect(60, 440, 0, 0);
                        gfx2.DrawString(ceckListtitle3, cListNormal, brush, cheklisttital3, XStringFormats.TopLeft);

                        XRect cheklisttital4 = new XRect(60, 450, 0, 0);
                        gfx2.DrawString(ceckListtitle4, cListNormal, brush, cheklisttital4, XStringFormats.TopLeft);

                        XRect cheklis1 = new XRect(30, 470, 0, 0);
                        gfx2.DrawString(ceckList1, cList3, brush, cheklis1, XStringFormats.TopLeft);

                        XRect cheklis2 = new XRect(30, 480, 0, 0);
                        gfx2.DrawString(ceckList2, cList3, brush, cheklis2, XStringFormats.TopLeft);

                        XRect cheklis3 = new XRect(30, 490, 0, 0);
                        gfx2.DrawString(ceckList3, cList3, brush, cheklis3, XStringFormats.TopLeft);

                        XRect cheklisSub3 = new XRect(30, 500, 0, 0);
                        gfx2.DrawString(ceckListSub3, cListNormal, brush, cheklisSub3, XStringFormats.TopLeft);

                        XRect cheklis4 = new XRect(30, 510, 0, 0);
                        gfx2.DrawString(ceckList4, cList3, brush, cheklis4, XStringFormats.TopLeft);

                        XRect cheklis5 = new XRect(30, 520, 0, 0);
                        gfx2.DrawString(ceckList5, cList3, brush, cheklis5, XStringFormats.TopLeft);

                        XRect cheklisSub5 = new XRect(30, 530, 0, 0);
                        gfx2.DrawString(ceckListSub5, cListNormal, brush, cheklisSub5, XStringFormats.TopLeft);

                        XRect cheklis6 = new XRect(30, 540, 0, 0);
                        gfx2.DrawString(ceckList6, cList3, brush, cheklis6, XStringFormats.TopLeft);

                        XRect cheklis7 = new XRect(30, 550, 0, 0);
                        gfx2.DrawString(ceckList7, cList3, brush, cheklis7, XStringFormats.TopLeft);

                        XRect cheklis8 = new XRect(30, 560, 0, 0);
                        gfx2.DrawString(ceckList8, cList3, brush, cheklis8, XStringFormats.TopLeft);

                        XRect cheklis9 = new XRect(30, 570, 0, 0);
                        gfx2.DrawString(ceckList9, cList3, brush, cheklis9, XStringFormats.TopLeft);

                        XRect cheklisSub9 = new XRect(30, 580, 0, 0);
                        gfx2.DrawString(ceckListSub9, cListNormal, brush, cheklisSub9, XStringFormats.TopLeft);

                        XRect cheklis10 = new XRect(30, 590, 0, 0);
                        gfx2.DrawString(ceckList10, cList3, brush, cheklis10, XStringFormats.TopLeft);

                        XRect cheklisS10 = new XRect(32, 600, 0, 0);
                        gfx2.DrawString(ceckListS10, cList3, brush, cheklisS10, XStringFormats.TopLeft);

                        XRect cheklis11 = new XRect(30, 610, 0, 0);
                        gfx2.DrawString(ceckList11, cList3, brush, cheklis11, XStringFormats.TopLeft);

                        XRect cheklis12 = new XRect(30, 620, 0, 0);
                        gfx2.DrawString(ceckList12, cList3, brush, cheklis12, XStringFormats.TopLeft);

                        XRect cheklis13 = new XRect(30, 630, 0, 0);
                        gfx2.DrawString(ceckList13, cList3, brush, cheklis13, XStringFormats.TopLeft);

                        XRect cheklis14 = new XRect(30, 640, 0, 0);
                        gfx2.DrawString(ceckList14, cList3, brush, cheklis14, XStringFormats.TopLeft);

                        XRect cheklisS14 = new XRect(30, 650, 0, 0);
                        gfx2.DrawString(ceckListS14, cList3, brush, cheklisS14, XStringFormats.TopLeft);

                        XRect cheklis15 = new XRect(30, 660, 0, 0);
                        gfx2.DrawString(ceckList15, cList3, brush, cheklis15, XStringFormats.TopLeft);

                        XRect cheklisS15 = new XRect(30, 670, 0, 0);
                        gfx2.DrawString(ceckListS15, cList3, brush, cheklisS15, XStringFormats.TopLeft);

                        XRect cheklis16 = new XRect(30, 680, 0, 0);
                        gfx2.DrawString(ceckList16, cList3, brush, cheklis16, XStringFormats.TopLeft);

                        XRect cheklisS16 = new XRect(30, 690, 0, 0);
                        gfx2.DrawString(ceckListS16, cList3, brush, cheklisS16, XStringFormats.TopLeft);

                        XRect cheklisS216 = new XRect(30, 700, 0, 0);
                        gfx2.DrawString(ceckListS216, cList3, brush, cheklisS216, XStringFormats.TopLeft);

                        //yesno
                        XRect cheklistys1 = new XRect(520, 470, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys1, XStringFormats.TopLeft);

                        XRect cheklistys2 = new XRect(520, 480, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys2, XStringFormats.TopLeft);

                        XRect cheklistys3 = new XRect(520, 490, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys3, XStringFormats.TopLeft);

                        XRect cheklistys4 = new XRect(520, 510, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys4, XStringFormats.TopLeft);

                        XRect cheklistys5 = new XRect(520, 520, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys5, XStringFormats.TopLeft);

                        XRect cheklistys6 = new XRect(520, 540, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys6, XStringFormats.TopLeft);

                        XRect cheklistys7 = new XRect(520, 550, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys7, XStringFormats.TopLeft);

                        XRect cheklistys8 = new XRect(520, 560, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys8, XStringFormats.TopLeft);

                        XRect cheklistys9 = new XRect(520, 570, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys9, XStringFormats.TopLeft);

                        XRect cheklistys10 = new XRect(520, 590, 0, 0);
                        gfx2.DrawString(globle.yssno, cList3, brush, cheklistys10, XStringFormats.TopLeft);

                        XRect cb1 = new XRect(520, 610, 17, 8);
                        gfx2.DrawRectangle(Hbox, cb1);
                        XRect cb2 = new XRect(520, 620, 17, 8);
                        gfx2.DrawRectangle(Hbox, cb2);
                        XRect cb3 = new XRect(520, 630, 17, 8);
                        gfx2.DrawRectangle(Hbox, cb3);
                        XRect cb4 = new XRect(520, 640, 17, 8);
                        gfx2.DrawRectangle(Hbox, cb4);
                        XRect cb5= new XRect(520, 660, 17, 8);
                        gfx2.DrawRectangle(Hbox, cb5);
                        XRect cb6 = new XRect(520, 680, 17, 8);
                        gfx2.DrawRectangle(Hbox, cb6);

                        string sinB = "Signature Class B:.............................................";
                        string sinA = "Signature Class A:.............................................";
                        string sinNo1 = "Signature No:..................................................";
                        string sinNo2 = "Signature No:..................................................";

                        XRect singB = new XRect(60, 730, 0, 0);
                        gfx2.DrawString(sinB, cList3, brush, singB, XStringFormats.TopLeft);

                        XRect singA = new XRect(300, 730, 0, 0);
                        gfx2.DrawString(sinA, cList3, brush, singA, XStringFormats.TopLeft);

                        XRect singno1 = new XRect(60, 750, 0, 0);
                        gfx2.DrawString(sinNo1, cList3, brush, singno1, XStringFormats.TopLeft);

                        XRect singno2 = new XRect(300, 750, 0, 0);
                        gfx2.DrawString(sinNo2, cList3, brush, singno2, XStringFormats.TopLeft);

                        //--end second page--

                        //--third page
                        PdfPage page3 = doc.AddPage(); //add Page
                        page.Width = XUnit.FromMillimeter(210);
                        page.Height = XUnit.FromMillimeter(297);
                        XGraphics gfx3 = XGraphics.FromPdfPage(page3);

                        XFont fo3 = new XFont("Calibri", 15, XFontStyle.Bold);
                        XFont fo10 = new XFont("Calibri", 12, XFontStyle.Bold);
                        XFont fo8 = new XFont("Calibri", 8);
                        XFont foN10 = new XFont("Calibri", 10);
                        //----page heading--
                        string ptitle = "DEPARTMENT OF FOREIGN EXCHANGE ";
                        string ptitle2 = " CENTRAL BANK OF SRILANKA ";
                        string ptitle3 = " DIRECTIONS No. 01 OF UNDER FOREIGN EXCHANGE ACT. No. 12 of 2017 ";

                        XRect pTitle = new XRect(170, 40, 0, 0);
                        gfx3.DrawString(ptitle, fo3, brush, pTitle, XStringFormats.TopLeft);
                        XRect pTitle2 = new XRect(200, 60, 0, 0);
                        gfx3.DrawString(ptitle2, fo3, brush, pTitle2, XStringFormats.TopLeft); 
                        XRect pTitle3 = new XRect(120, 90, 0, 0);
                        gfx3.DrawString(ptitle3, fo10, brush, pTitle3, XStringFormats.TopLeft);

                        XPen mainLins = new XPen(XColors.Black, 2);
                        XPen mainLins2 = new XPen(XColors.Black, 1.5);
                        XPen pen5 = new XPen(XColors.Black, 1);

                        //mainBox
                        XRect form1 = new XRect(30, 120, 542.5, 650);
                        gfx3.DrawRectangle(mainLins, form1);

                        //--Xaxisline
                        XPoint maintitalS = new XPoint(30, 150); 
                        XPoint mailtitleE = new XPoint(572, 150);
                        gfx3.DrawLine(mainLins, maintitalS, mailtitleE);
                        string heading2 = "SALE OF FOREIGN EXCHANGE BY AN AUTHORISED DEALER FORM-1";
                        XRect Heading2 = new XRect(93, 125, 0, 0);
                        gfx3.DrawString(heading2, fo3, brush, Heading2, XStringFormats.TopLeft);
                        //--EndXaxisline

                        //--Y axis line
                        XPoint startPointY = new XPoint(290, 150); 
                        XPoint endPointY = new XPoint(290, 730);
                        gfx3.DrawLine(mainLins, startPointY, endPointY);
                        //--EndYaxis line

                        XPoint mainLSx = new XPoint(30, 210);
                        XPoint mainLineEx = new XPoint(572, 210);
                        gfx3.DrawLine(pen5, mainLSx, mainLineEx);
                      

                        XPoint subL1S = new XPoint(30, 185);
                        XPoint subL1E = new XPoint(293, 185);
                        gfx3.DrawLine(pen5, subL1S, subL1E);

                        XPoint subL2Ys = new XPoint(118, 150);
                        XPoint subL2Ye = new XPoint(118, 445);
                        gfx3.DrawLine(mainLins2, subL2Ys, subL2Ye);
                        gfx3.DrawString("NIC/Passport/", foN10, XBrushes.Black, new XRect(43, 150, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Company", foN10, XBrushes.Black, new XRect(43, 160, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Reg.No.", foN10, XBrushes.Black, new XRect(43, 170, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Income Tax", foN10, XBrushes.Black, new XRect(43, 185, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("File No.", foN10, XBrushes.Black, new XRect(43, 195, 0, 0), XStringFormats.TopLeft);

                        XPoint subLnic = new XPoint(135, 150);
                        XPoint subLtax = new XPoint(135, 210);
                        gfx3.DrawLine(pen5, subLnic, subLtax);

                        XPoint subLnic1 = new XPoint(150, 150);
                        XPoint subLtax1 = new XPoint(150, 210);
                        gfx3.DrawLine(pen5, subLnic1, subLtax1);

                        XPoint subLnic2 = new XPoint(165, 150);
                        XPoint subLtax2 = new XPoint(165, 210);
                        gfx3.DrawLine(pen5, subLnic2, subLtax2);

                        XPoint subLnic3 = new XPoint(180, 150);
                        XPoint subLtax3 = new XPoint(180, 210);
                        gfx3.DrawLine(pen5, subLnic3, subLtax3);

                        XPoint subLnic4 = new XPoint(195, 150);
                        XPoint subLtax4 = new XPoint(195, 210);
                        gfx3.DrawLine(pen5, subLnic4, subLtax4);

                        XPoint subLnic5 = new XPoint(215, 150);
                        XPoint subLtax5 = new XPoint(215, 210);
                        gfx3.DrawLine(pen5, subLnic3, subLtax3);

                        XPoint subLnic6 = new XPoint(210, 150);
                        XPoint subLtax6 = new XPoint(210, 210);
                        gfx3.DrawLine(pen5, subLnic6, subLtax6);

                        XPoint subLnic7 = new XPoint(225, 150);
                        XPoint subLtax7 = new XPoint(225, 210);
                        gfx3.DrawLine(pen5, subLnic7, subLtax7);

                        XPoint subLnic8 = new XPoint(238, 150);
                        XPoint subLtax8 = new XPoint(238, 210);
                        gfx3.DrawLine(pen5, subLnic8, subLtax8);

                        XPoint subLnic9 = new XPoint(252, 150);
                        XPoint subLtax9 = new XPoint(252, 210);
                        gfx3.DrawLine(pen5, subLnic9, subLtax9);

                        XPoint subLnic10 = new XPoint(265, 150);
                        XPoint subLtax10 = new XPoint(265, 210);
                        gfx3.DrawLine(pen5, subLnic10, subLtax10);

                        XPoint subLnic11 = new XPoint(277, 150);
                        XPoint subLtax11 = new XPoint(277, 210);
                        gfx3.DrawLine(pen5, subLnic11, subLtax11);
                        //--serial number start
                        XPoint serial1MainSY = new XPoint(326, 150);
                        XPoint serial1MainEY = new XPoint(326, 210);
                        gfx3.DrawLine(mainLins2, serial1MainSY, serial1MainEY);
                        gfx3.DrawString("Serial", foN10, XBrushes.Black, new XRect(295, 168, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("No.", foN10, XBrushes.Black, new XRect(295, 177, 0, 0), XStringFormats.TopLeft);

                        XPoint seriaL1nSY = new XPoint(340, 150); 
                        XPoint seriaL1MainEY = new XPoint(340, 210);
                        gfx3.DrawLine(pen5, seriaL1nSY, seriaL1MainEY);
                        
                        XPoint seriaL2nSY = new XPoint(355, 150);
                        XPoint seriaL2MainEY = new XPoint(355, 210);
                        gfx3.DrawLine(pen5, seriaL2nSY, seriaL2MainEY);

                        XPoint seriaL3nSY = new XPoint(370, 150);
                        XPoint seriaL3MainEY = new XPoint(370, 210);
                        gfx3.DrawLine(pen5, seriaL3nSY, seriaL3MainEY);

                        XPoint seriaL4nSY = new XPoint(385, 150);
                        XPoint seriaL4MainEY = new XPoint(385, 210);
                        gfx3.DrawLine(pen5, seriaL4nSY, seriaL4MainEY);

                        XPoint seriaL5nSY = new XPoint(400, 150);
                        XPoint seriaL5MainEY = new XPoint(400, 647);
                        gfx3.DrawLine(mainLins2, seriaL5nSY, seriaL5MainEY);

                        XPoint seriaL6nSY = new XPoint(415, 150);
                        XPoint seriaL6MainEY = new XPoint(415, 210);
                        gfx3.DrawLine(pen5, seriaL6nSY, seriaL6MainEY);

                        XPoint seriaL7nSY = new XPoint(430, 150);
                        XPoint seriaL7MainEY = new XPoint(430, 210);
                        gfx3.DrawLine(pen5, seriaL7nSY, seriaL7MainEY);

                        XPoint seriaL8nSY = new XPoint(445, 150);
                        XPoint seriaL8MainEY = new XPoint(445, 210);
                        gfx3.DrawLine(pen5, seriaL8nSY, seriaL8MainEY);

                        XPoint seriaL9nSY = new XPoint(460, 150);
                        XPoint seriaL9MainEY = new XPoint(460, 210);
                        gfx3.DrawLine(pen5, seriaL9nSY, seriaL9MainEY);

                        XPoint seriaL10nSY = new XPoint(475, 150);
                        XPoint seriaL10MainEY = new XPoint(475, 210);
                        gfx3.DrawLine(pen5, seriaL10nSY, seriaL10MainEY);

                        XPoint seriaL11nSY = new XPoint(490, 150);
                        XPoint seriaL11MainEY = new XPoint(490, 210);
                        gfx3.DrawLine(mainLins2, seriaL11nSY, seriaL11MainEY);

                        XPoint seriaL12nSY = new XPoint(505, 150);
                        XPoint seriaL12MainEY = new XPoint(505, 210);
                        gfx3.DrawLine(pen5, seriaL12nSY, seriaL12MainEY);

                        XPoint seriaL13nSY = new XPoint(520, 150);
                        XPoint seriaL13MainEY = new XPoint(520, 210);
                        gfx3.DrawLine(pen5, seriaL13nSY, seriaL13MainEY);

                        XPoint seriaL14nSY = new XPoint(535, 150);
                        XPoint seriaL14MainEY = new XPoint(535, 210);
                        gfx3.DrawLine(pen5, seriaL14nSY, seriaL14MainEY);

                        XPoint seriaL15nSY = new XPoint(550, 150);
                        XPoint seriaL15MainEY = new XPoint(550, 210);
                        gfx3.DrawLine(pen5, seriaL15nSY, seriaL15MainEY);

                        XPoint seriaL16nSY = new XPoint(562, 150);
                        XPoint seriaL16MainEY = new XPoint(562, 210);
                        gfx3.DrawLine(pen5, seriaL16nSY, seriaL16MainEY);
                        //--serial number end

                        //--applicant name
                        gfx3.DrawString("Applicant Name", foN10, XBrushes.Black, new XRect(43, 217, 0, 0), XStringFormats.TopLeft);
                        XPoint lineNmame1S = new XPoint(118, 236);
                        XPoint lineNmame1E = new XPoint(572, 236);
                        gfx3.DrawLine(pen5, lineNmame1S, lineNmame1E);

                        XPoint lineNmame2S = new XPoint(118, 260);
                        XPoint lineNmame2E = new XPoint(572, 260);
                        gfx3.DrawLine(pen5, lineNmame2S, lineNmame2E);
                        //end applicnt name

                        //applicnt address
                        gfx3.DrawString("Applicant Address", foN10, XBrushes.Black, new XRect(43, 253, 0, 0), XStringFormats.TopLeft);
                        XPoint lineAddr1S = new XPoint(118, 284);
                        XPoint lineAddr1E = new XPoint(400, 284);
                        gfx3.DrawLine(pen5, lineAddr1S, lineAddr1E);

                        XPoint lineAddr2S = new XPoint(118, 308);
                        XPoint lineAddr2E = new XPoint(572, 308);
                        gfx3.DrawLine(pen5, lineAddr2S, lineAddr2E);
                        //end applicnd address

                        //tickertNo
                        gfx3.DrawString("Air Ticket No.", foN10, XBrushes.Black, new XRect(43, 310, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("(Only for travel", foN10, XBrushes.Black, new XRect(42, 320, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("purpose)", foN10, XBrushes.Black, new XRect(43, 328, 0, 0), XStringFormats.TopLeft);
                        XPoint linetic1S = new XPoint(30, 345);
                        XPoint linetic1E = new XPoint(290, 345);
                        gfx3.DrawLine(pen5, linetic1S, linetic1E);
                        //end tiaket

                        //Benificery
                        gfx3.DrawString("Beneficiary Name", foN10, XBrushes.Black, new XRect(43, 352, 0, 0), XStringFormats.TopLeft);
                        XPoint lineBennameS = new XPoint(118, 373);
                        XPoint lineBennameE = new XPoint(572, 373);
                        gfx3.DrawLine(pen5, lineBennameS, lineBennameE);

                        gfx3.DrawString("Beneficiary Address", foN10, XBrushes.Black, new XRect(39, 376, 0, 0), XStringFormats.TopLeft);
                        XPoint lineBenAdd1S = new XPoint(118, 397);
                        XPoint lineBenAsd1eE = new XPoint(290, 397);
                        gfx3.DrawLine(pen5, lineBenAdd1S, lineBenAsd1eE);

                        XPoint lineBenAdd2S = new XPoint(118, 421);
                        XPoint lineBenAdd2E = new XPoint(572, 421);
                        gfx3.DrawLine(pen5, lineBenAdd2S, lineBenAdd2E);

                        gfx3.DrawString("Purpose", foN10, XBrushes.Black, new XRect(43, 430, 0, 0), XStringFormats.TopLeft);
                        XPoint lineBenprS = new XPoint(30, 445);
                        XPoint lineBenporE = new XPoint(290, 445);
                        gfx3.DrawLine(pen5, lineBenprS, lineBenporE);
                        //end Benificery

                        //forign exchange
                        XPoint subLExamoYs = new XPoint(126, 445);
                        XPoint subLExamoYe = new XPoint(126, 549);
                        gfx3.DrawLine(mainLins2, subLExamoYs, subLExamoYe);
                        gfx3.DrawString("Applied Foreign", foN10, XBrushes.Black, new XRect(43, 490, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Exchange Amount", foN10, XBrushes.Black, new XRect(43, 500, 0, 0), XStringFormats.TopLeft);
                        
                        XPoint subLExamoYs1 = new XPoint(148, 445);
                        XPoint subLExamoYe1 = new XPoint(148, 549);
                        gfx3.DrawLine(mainLins2, subLExamoYs1, subLExamoYe1);
                        //usd
                        XPoint lineExX1S = new XPoint(127, 469);
                        XPoint lineExX1E = new XPoint(572, 469);
                        gfx3.DrawLine(pen5, lineExX1S, lineExX1E);
                        gfx3.DrawString("USD", foN10, XBrushes.Black, new XRect(128, 451, 0, 0), XStringFormats.TopLeft);
                        //eur
                        XPoint lineExX2S = new XPoint(127, 497);
                        XPoint lineExX2E = new XPoint(290, 497);
                        gfx3.DrawLine(pen5, lineExX2S, lineExX2E);
                        gfx3.DrawString("EUR", foN10, XBrushes.Black, new XRect(128, 477, 0, 0), XStringFormats.TopLeft);
                        //gbp
                        XPoint lineExX3S = new XPoint(127, 524);
                        XPoint lineExX3E = new XPoint(574, 524);
                        gfx3.DrawLine(pen5, lineExX3S, lineExX3E);
                        gfx3.DrawString("GBP", foN10, XBrushes.Black, new XRect(128, 505, 0, 0), XStringFormats.TopLeft);
                        //Empty
                        XPoint lineExX4S = new XPoint(30, 549);
                        XPoint lineExX4E = new XPoint(290, 549);
                        gfx3.DrawLine(pen5, lineExX4S, lineExX4E);

                        XPoint LExamoYs1 = new XPoint(165, 445);
                        XPoint LExamoYe1 = new XPoint(165, 549);
                        gfx3.DrawLine(pen5, LExamoYs1, LExamoYe1);

                        XPoint LExamoYs2 = new XPoint(183, 445);
                        XPoint LExamoYe2 = new XPoint(183, 549);
                        gfx3.DrawLine(pen5, LExamoYs2, LExamoYe2);

                        XPoint LExamoYs3 = new XPoint(201, 445);
                        XPoint LExamoYe3 = new XPoint(201, 549);
                        gfx3.DrawLine(pen5, LExamoYs3, LExamoYe3);

                        XPoint LExamoYs4 = new XPoint(217, 445);
                        XPoint LExamoYe4 = new XPoint(217, 549);
                        gfx3.DrawLine(pen5, LExamoYs4, LExamoYe4);

                        XPoint LExamoYs5 = new XPoint(233, 445);
                        XPoint LExamoYe5 = new XPoint(233, 549);
                        gfx3.DrawLine(pen5, LExamoYs5, LExamoYe5);

                        XPoint LExamoYs6 = new XPoint(248, 445);
                        XPoint LExamoYe6 = new XPoint(248, 549);
                        gfx3.DrawLine(pen5, LExamoYs6, LExamoYe6);

                        XPoint LExamoYs7 = new XPoint(265, 445);
                        XPoint LExamoYe7 = new XPoint(265, 549);
                        gfx3.DrawLine(pen5, LExamoYs7, LExamoYe7);

                        XPoint LExamoYs8 = new XPoint(278, 445);
                        XPoint LExamoYe8 = new XPoint(278, 549);
                        gfx3.DrawLine(pen5, LExamoYs8, LExamoYe8);
                        // end forign exchange

                        //applicant signature
                        XPoint LapplicntsingS= new XPoint(30, 648);
                        XPoint LapplicntsingE = new XPoint(572, 648);
                        gfx3.DrawLine(mainLins2, LapplicntsingS, LapplicntsingE);
                        gfx3.DrawString("I declare that all information given by me is true and correct", fo8, XBrushes.Black, new XRect(60, 553, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("..............................................", fo8, XBrushes.Black, new XRect(40, 625, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Date", fo8, XBrushes.Black, new XRect(75, 635, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("..............................................", fo8, XBrushes.Black, new XRect(184, 625, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Signature of applicant", fo8, XBrushes.Black, new XRect(195, 635, 0, 0), XStringFormats.TopLeft);

                        //bank code
                        gfx3.DrawString("Bank Code", fo8, XBrushes.Black, new XRect(295, 220, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Branch Code", fo8, XBrushes.Black, new XRect(295, 245, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Country Code", fo8, XBrushes.Black, new XRect(295, 265, 0, 0), XStringFormats.TopLeft);
                       
                        XPoint bCodeys = new XPoint(340, 210);
                        XPoint bCodeye = new XPoint(340, 285);
                        gfx3.DrawLine(mainLins2, bCodeys, bCodeye);

                        XPoint bCodeysL1 = new XPoint(355, 210);
                        XPoint bCodeyeL1 = new XPoint(355, 285);
                        gfx3.DrawLine(pen5, bCodeysL1, bCodeyeL1);

                        XPoint bCodeysL2 = new XPoint(370, 210);
                        XPoint bCodeyeL2 = new XPoint(370, 285);
                        gfx3.DrawLine(pen5, bCodeysL2, bCodeyeL2);

                        XPoint bCodeysL3 = new XPoint(385, 210);
                        XPoint bCodeyeL3 = new XPoint(385, 285);
                        gfx3.DrawLine(pen5, bCodeysL3, bCodeyeL3);
                        //end brance code

                        //purpose code                     
                        gfx3.DrawString("Purpose Code", fo8, XBrushes.Black, new XRect(405, 220, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Sub Perpose Code", fo8, XBrushes.Black, new XRect(405, 245, 0, 0), XStringFormats.TopLeft);
                        XPoint pCodeL1YS = new XPoint(490, 210);
                        XPoint pCodeL1YE = new XPoint(490, 260);
                        gfx3.DrawLine(mainLins2, pCodeL1YS, pCodeL1YE);

                        XPoint pCodeL2YS = new XPoint(505, 210);
                        XPoint pCodeL2YE = new XPoint(505, 260);
                        gfx3.DrawLine(pen5, pCodeL2YS, pCodeL2YE);

                        XPoint pCodeL3YS = new XPoint(520, 210);
                        XPoint pCodeL3YE = new XPoint(520, 260);
                        gfx3.DrawLine(pen5, pCodeL3YS, pCodeL3YE);

                        XPoint pCodeL4YS = new XPoint(535, 210);
                        XPoint pCodeL4YE = new XPoint(535, 260);
                        gfx3.DrawLine(pen5, pCodeL4YS, pCodeL4YE);

                        XPoint pCodeL5YS = new XPoint(550, 210);
                        XPoint pCodeL5YE = new XPoint(550, 260);
                        gfx3.DrawLine(pen5, pCodeL5YS, pCodeL5YE);

                        XPoint pCodeL6YS = new XPoint(562, 210);
                        XPoint pCodeL6YE = new XPoint(562, 260);
                        gfx3.DrawLine(pen5, pCodeL6YS, pCodeL6YE);

                        //country code
                        gfx3.DrawString("Curruncy", fo8, XBrushes.Black, new XRect(410, 275, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Code", fo8, XBrushes.Black, new XRect(415, 285, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Released Foreign Exchange Amount", fo8, XBrushes.Black, new XRect(453, 275, 0, 0), XStringFormats.TopLeft);

                        XPoint CcodeYLS = new XPoint(445, 260);
                        XPoint CcodeYLE = new XPoint(445, 648);
                        gfx3.DrawLine(mainLins2, CcodeYLS, CcodeYLE);

                        XPoint CcodeYL1S = new XPoint(460, 308);
                        XPoint CcodeY1LE = new XPoint(460, 648);
                        gfx3.DrawLine(pen5, CcodeYL1S, CcodeY1LE);

                        XPoint CcodeYL2S = new XPoint(475, 308);
                        XPoint CcodeYL2E = new XPoint(475, 648);
                        gfx3.DrawLine(pen5, CcodeYL2S, CcodeYL2E);

                        XPoint CcodeYL3S = new XPoint(490, 308);
                        XPoint CcodeYL3E = new XPoint(490, 648);
                        gfx3.DrawLine(pen5, CcodeYL3S, CcodeYL3E);

                        XPoint CcodeYL4S = new XPoint(505, 308);
                        XPoint CcodeYL4E = new XPoint(505, 648);
                        gfx3.DrawLine(pen5, CcodeYL4S, CcodeYL4E);


                        XPoint CcodeYL5S = new XPoint(520, 308);
                        XPoint CcodeYL5E = new XPoint(520, 648);
                        gfx3.DrawLine(pen5, CcodeYL5S, CcodeYL5E);

                        XPoint CcodeYL6S = new XPoint(535, 308);
                        XPoint CcodeYL6E = new XPoint(535, 648);
                        gfx3.DrawLine(pen5, CcodeYL6S, CcodeYL6E);

                        XPoint CcodeYL7S = new XPoint(550, 308);
                        XPoint CcodeYL7E = new XPoint(550, 648);
                        gfx3.DrawLine(pen5, CcodeYL7S, CcodeYL7E);

                        XPoint CcodeYL8S = new XPoint(562, 308);
                        XPoint CcodeYL8E = new XPoint(562, 648);
                        gfx3.DrawLine(pen5, CcodeYL8S, CcodeYL8E);

                        gfx3.DrawString("Bank Draft", fo8, XBrushes.Black, new XRect(295, 310, 0, 0), XStringFormats.TopLeft);
                        XPoint CcodeXL1S = new XPoint(400, 345);//bank Draft
                        XPoint CcodeXL1E = new XPoint(573, 345);
                        gfx3.DrawLine(pen5, CcodeXL1S, CcodeXL1E);

                        gfx3.DrawString("Telegraphic Transfer", fo8, XBrushes.Black, new XRect(295, 375, 0, 0), XStringFormats.TopLeft);
                        XPoint CcodeXL2S = new XPoint(400, 397);//Tdeligrafic Trafer
                        XPoint CcodeXL2E = new XPoint(573, 397);
                        gfx3.DrawLine(pen5, CcodeXL2S, CcodeXL2E);

                        gfx3.DrawString("Travel Card", fo8, XBrushes.Black, new XRect(295, 422, 0, 0), XStringFormats.TopLeft);
                        XPoint CcodeXL3S = new XPoint(400, 445);//Travel card
                        XPoint CcodeXL3E = new XPoint(573, 445);
                        gfx3.DrawLine(pen5, CcodeXL3S, CcodeXL3E);

                        gfx3.DrawString("Other (specify)", fo8, XBrushes.Black, new XRect(295, 471, 0, 0), XStringFormats.TopLeft);
                        XPoint CcodeXL4S = new XPoint(400, 497);// other specify
                        XPoint CcodeXL4E = new XPoint(573, 497);
                        gfx3.DrawLine(pen5, CcodeXL4S, CcodeXL4E);

                        gfx3.DrawString("Currency issuance", fo8, XBrushes.Black, new XRect(295, 528, 0, 0), XStringFormats.TopLeft);
                        XPoint Ce1xL1S = new XPoint(400,555);// currency inssurence
                        XPoint Ce1xL1E = new XPoint(573, 555);
                        gfx3.DrawLine(pen5, Ce1xL1S, Ce1xL1E);

                        XPoint Ce1xL2S = new XPoint(400, 585);// currency inssurence
                        XPoint Ce1xL2E = new XPoint(573, 585);
                        gfx3.DrawLine(pen5, Ce1xL2S, Ce1xL2E);

                        XPoint Ce1xL3S = new XPoint(400, 615);// currency inssurence
                        XPoint Ce1xL3E = new XPoint(573, 615);
                        gfx3.DrawLine(pen5, Ce1xL3S, Ce1xL3E);

                        XPoint BuseS = new XPoint(30, 730);
                        XPoint BuseE = new XPoint(572, 730);
                        gfx3.DrawLine(mainLins2, BuseS, BuseE);

                        XPoint Buse1yS = new XPoint(60, 648);
                        XPoint Buse1yE = new XPoint(60, 770);
                        gfx3.DrawLine(mainLins2, Buse1yS, Buse1yE);
                        gfx3.DrawString("Bank", fo8, XBrushes.Black, new XRect(35, 670, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Use", fo8, XBrushes.Black, new XRect(35, 680, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("...............................", fo8, XBrushes.Black, new XRect(70, 700, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("Date", fo8, XBrushes.Black, new XRect(90, 710, 0, 0), XStringFormats.TopLeft);
                        gfx3.DrawString("..........................", fo8, XBrushes.Black, new XRect(150, 700, 0, 0), XStringFormats.TopLeft);


                        gfx.Dispose();
                        gfx2.Dispose();
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


        private void button1_Click(object sender, EventArgs e)
        {
            UCPage2 uCPage1 = new UCPage2();
            uCPage1.Show();
            uCPage1.Dock = DockStyle.Fill;
            pnlt.Controls.Add(uCPage1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCPage2 uCPage2 = new UCPage2();
            uCPage2.Show();
            uCPage2.Dock = DockStyle.Fill;
            pnlt.Controls.Add(uCPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Form2 f2 = new form2();
            //f2.show();
 ;

        }
    }
}
