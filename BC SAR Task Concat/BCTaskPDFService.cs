using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using iTextSharp.text;

namespace BC_SAR_Task_Concat
{
    public class BCTaskPDFService
    {
        public string GenerateSinglePDFWithFields(string taskReport, string reimbursement, string personnel, string outputFileName = null, bool createFillableFields = true)
        {
            string path = System.IO.Path.GetTempPath();
            string finalPath = System.IO.Path.Combine(path, Guid.NewGuid().ToString() + ".pdf");
            if (!string.IsNullOrEmpty(outputFileName)) { finalPath = outputFileName; }

            List<byte[]> allPDFs = new List<byte[]>();
            if (!string.IsNullOrEmpty(taskReport))
            {

                string taskReportPath = System.IO.Path.Combine(path, Guid.NewGuid().ToString() + ".pdf");
                PdfReader rdr = new PdfReader(taskReport);
                PdfStamper stamper = new PdfStamper(rdr, new System.IO.FileStream(taskReportPath, System.IO.FileMode.Create));
                if (createFillableFields)
                {
                    //sig
                    int[] SignatureInstances = { 0, 2, 4 };
                    stamper = AddPDFField(stamper, taskReport, "Signature:", "Signature", 19, 187, "ReportSignature", SignatureInstances);

                    //Dates
                    int[] DateInstances = { 2, 4 };
                    stamper = AddPDFField(stamper, taskReport, "Date:", "TextField", 16, 184, "ReportDate", DateInstances);

                    //Dates
                    int[] RMInstances = { 0 };
                    stamper = AddPDFField(stamper, taskReport, "Regional Manager:", "TextField", 16, 457, "ReportRegionalManager", RMInstances);
                    int[] RMCommentInstances = { 0 };
                    stamper = AddPDFField(stamper, taskReport, "Comments /", "MultiLineTextField", 58, 449, "ReportRecommendations", RMCommentInstances);
                }

                stamper.Close();//Close a PDFStamper Object
                rdr.Close();    //Close a PDFReader Object

                using (FileStream stream = File.OpenRead(taskReportPath))
                {
                    byte[] fileBytes = new byte[stream.Length];

                    stream.Read(fileBytes, 0, fileBytes.Length);
                    stream.Close();
                    allPDFs.Add(fileBytes);
                }
            }
            if (!string.IsNullOrEmpty(reimbursement))
            {
                string reimbursementPath = System.IO.Path.Combine(path, Guid.NewGuid().ToString() + ".pdf");
                using (PdfReader rdr = new PdfReader(reimbursement))
                {
                    PdfStamper stamper = new PdfStamper(rdr, new System.IO.FileStream(reimbursementPath, System.IO.FileMode.Create));
                    if (createFillableFields)
                    {
                        //Position
                        int[] PositionInstances = { 0 };
                        stamper = AddPDFField(stamper, reimbursement, "Position:", "TextField", 16, 180, "EquimentPositionName", PositionInstances);
                        //Email
                        int[] EmailInstances = { 0 };
                        stamper = AddPDFField(stamper, reimbursement, "Email:", "TextField", 16, 180, "EquimentEmail", EmailInstances);
                        //Date
                        int[] DateInstances = { 0 };
                        stamper = AddPDFField(stamper, reimbursement, "Date:", "TextField", 16, 180, "EquimentDate", DateInstances);
                        //Phone
                        int[] PhoneInstances = { 0 };
                        stamper = AddPDFField(stamper, reimbursement, "Telephone:", "TextField", 16, 180, "EquimentTelephone", PhoneInstances);
                        //Fax for some reason
                        int[] FaxInstances = { 0 };
                        stamper = AddPDFField(stamper, reimbursement, "Fax:", "TextField", 16, 180, "EquimentFax", FaxInstances);

                        //sig
                        int[] SignatureInstances = { 0 };
                        stamper = AddPDFField(stamper, reimbursement, "Signature:", "Signature", 21, 145, "EquipmentSignature", SignatureInstances);

                    }
                    stamper.Close();//Close a PDFStamper Object
                    rdr.Close();    //Close a PDFReader Object
                }

                using (FileStream stream = File.OpenRead(reimbursementPath))
                {
                    byte[] fileBytes = new byte[stream.Length];

                    stream.Read(fileBytes, 0, fileBytes.Length);
                    stream.Close();
                    allPDFs.Add(fileBytes);
                }
            }
            if (!string.IsNullOrEmpty(personnel))
            {
                string personnelPath = System.IO.Path.Combine(path, Guid.NewGuid().ToString() + ".pdf");
                using (PdfReader rdr = new PdfReader(personnel))
                {
                    PdfStamper stamper = new PdfStamper(rdr, new System.IO.FileStream(personnelPath, System.IO.FileMode.Create));
                    if (createFillableFields)
                    {
                        //Position
                        int[] TaskLeaderInstances = { 0 };
                        stamper = AddPDFField(stamper, personnel, "Task Leader:", "TextField", 24, 200, "PersonnelTaskLeader", TaskLeaderInstances);

                        //Date
                        int[] DateInstances = { 0 };
                        stamper = AddPDFField(stamper, personnel, "Date:", "TextField", 16, 200, "PersonnelDate", DateInstances);
                        //Email
                        int[] PageInstances = { 0 };
                        stamper = AddPDFField(stamper, personnel, "Page:", "TextField", 16, 200, "PersonnelPage", PageInstances);

                        //sig
                        int[] SignatureInstances = { 0 };
                        stamper = AddPDFField(stamper, personnel, "Signature:", "Signature", 38, 164, "PersonnelSignature", SignatureInstances);
                    }

                    stamper.Close();//Close a PDFStamper Object
                    rdr.Close();    //Close a PDFReader Object
                }

                using (FileStream stream = File.OpenRead(personnelPath))
                {
                    byte[] fileBytes = new byte[stream.Length];

                    stream.Read(fileBytes, 0, fileBytes.Length);
                    stream.Close();
                    allPDFs.Add(fileBytes);
                }
            }

            byte[] fullFile = concatAndAddContent(allPDFs);
            try
            {
                File.WriteAllBytes(finalPath, fullFile);

                //if (automaticallyOpen) { System.Diagnostics.Process.Start(path); }

            }
            catch (Exception)
            {
                //MessageBox.Show("There was an error trying to save " + path + " please verify the path is accessible.");
            }
            //Console.Read();


            return finalPath;
        }

        public static byte[] concatAndAddContent(List<byte[]> pdfByteContent)
        {

            using (var ms = new MemoryStream())
            {
                using (var doc = new Document())
                {
                    using (var copy = new PdfSmartCopy(doc, ms))
                    {
                        doc.Open();

                        //Loop through each byte array
                        foreach (var p in pdfByteContent)
                        {
                            try
                            {
                                //Create a PdfReader bound to that byte array
                                using (var reader = new PdfReader(p))
                                {

                                    //Add the entire document instead of page-by-page
                                    copy.AddDocument(reader);
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }

                        doc.Close();
                    }
                }

                //Return just before disposing
                return ms.ToArray();
            }
        }

        public PdfStamper AddFormFieldToExistingPDF(PdfStamper stamper, string fieldType, float x, float y, int height, int width, string fieldName)
        {

            switch (fieldType)
            {
                case "TextField":
                    TextField field = new TextField(stamper.Writer, new iTextSharp.text.Rectangle(x, y, x + width, y + height), fieldName);
                    field.Visibility = TextField.VISIBLE;
                    // add the field here, the second param is the page you want it on         
                    stamper.AddAnnotation(field.GetTextField(), 1);

                    break;
                case "Signature":

                    PdfFormField sigField = PdfFormField.CreateSignature(stamper.Writer);
                    sigField.SetWidget(new iTextSharp.text.Rectangle(x, y, x + width, y + height), PdfAnnotation.HIGHLIGHT_INVERT);
                    sigField.FieldName = fieldName;
                    sigField.SetFieldFlags(PdfAnnotation.FLAGS_PRINT);
                    sigField.SetFieldFlags(PdfFormField.FLAGS_PRINT);

                    // add the field here, the second param is the page you want it on
                    stamper.AddAnnotation(sigField, 1);

                    break;
                case "MultiLineTextField":
                    TextField multilineField = new TextField(stamper.Writer, new iTextSharp.text.Rectangle(x, y, x + width, y + height), fieldName);
                    multilineField.Options = TextField.MULTILINE;
                    // add the field here, the second param is the page you want it on         
                    stamper.AddAnnotation(multilineField.GetTextField(), 1);
                    break;
            }
            return stamper;
        }

        public void setVisible(string path)
        {
            using (PdfReader rdr = new PdfReader(path))
            {
                PdfStamper stamper = new PdfStamper(rdr, new System.IO.FileStream(path, System.IO.FileMode.Create));

                var formFields = stamper.AcroFields;
                var filedNames = formFields.Fields.Keys;
                foreach (var keyName in filedNames)
                {
                    formFields.SetFieldProperty(keyName, "setflags", PdfAnnotation.FLAGS_PRINT, null);
                    formFields.SetFieldProperty(keyName, "setflags", PdfFormField.FF_EDIT, null);
                    //formFields.SetFieldProperty(keyName, "textsize", 8.0f, null);

                    formFields.RegenerateField(keyName);
                }
                stamper.Close();//Close a PDFStamper Object
                rdr.Close();    //Close a PDFReader Object

            }

        }



        private PdfStamper AddPDFField(PdfStamper stamper, string fileName, string adjacentText, string fieldType, int height, int width, string fieldName, int[] instancesOfInterest)
        {
            var t = new MyLocationTextExtractionStrategy(adjacentText);
            StringBuilder sb = new StringBuilder();

            //Parse page 1 of the document above
            using (var r = new PdfReader(fileName))
            {
                var ex = PdfTextExtractor.GetTextFromPage(r, 1, t);
            }

            //Loop through each chunk found
            for (int x = 0; x < t.myPoints.Count; x++)
            {
                if (instancesOfInterest.Contains(x))
                {
                    var p = t.myPoints[x];

                    sb.Append(string.Format("Found text {0} at {1}x{2}", p.Text, p.Rect.Left, p.Rect.Bottom));
                    sb.Append(Environment.NewLine);

                    float adjustedStartX = p.Rect.Left + 5;
                    float adjustedStartY = p.Rect.Bottom - 5;
                    if (fieldType == "MultiLineTextField")
                    {
                        adjustedStartX = p.Rect.Left + 12;
                        adjustedStartY = p.Rect.Bottom - (height - 8);
                    }
                    stamper = AddFormFieldToExistingPDF(stamper, fieldType, adjustedStartX, adjustedStartY, height, width, fieldName + (x + 1));
                }
            }





            return stamper;
        }
    }



    public class RectAndText
    {
        public iTextSharp.text.Rectangle Rect;
        public String Text;
        public RectAndText(iTextSharp.text.Rectangle rect, String text)
        {
            this.Rect = rect;
            this.Text = text;
        }
    }

    public class MyLocationTextExtractionStrategy : LocationTextExtractionStrategy
    {
        //Hold each coordinate
        public List<RectAndText> myPoints = new List<RectAndText>();
        private StringBuilder currentBlock = new StringBuilder();

        //The string that we're searching for
        public String TextToSearchFor { get; set; }

        //How to compare strings
        public System.Globalization.CompareOptions CompareOptions { get; set; }

        public MyLocationTextExtractionStrategy(String textToSearchFor, System.Globalization.CompareOptions compareOptions = System.Globalization.CompareOptions.None)
        {
            this.TextToSearchFor = textToSearchFor;
            this.CompareOptions = compareOptions;
        }

        //Automatically called for each chunk of text in the PDF
        public override void RenderText(TextRenderInfo renderInfo)
        {
            base.RenderText(renderInfo);
            var baseline = renderInfo.GetBaseline();


            string text = renderInfo.GetText();
            currentBlock.Append(text);
            if (TextToSearchFor.Equals(currentBlock.ToString()))
            {

                var rec = baseline.GetBoundingRectange();

                var rect = new iTextSharp.text.Rectangle(
                                                  rec.X,
                                                  rec.Y,
                                                  rec.X + rec.Width,
                                                  rec.Y + rec.Height
                                                  );
                ;
                this.myPoints.Add(new RectAndText(rect, this.TextToSearchFor));
                currentBlock.Clear();
            }
            else if (TextToSearchFor.Contains(currentBlock.ToString()))
            {
                //so far, keep adding stuff
                return;
            }
            else
            {
                currentBlock.Clear();
                currentBlock.Append(text);
                return;
            }

        }
    }
}
