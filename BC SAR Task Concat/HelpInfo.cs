﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_SAR_Task_Concat
{
    public class HelpInfo
    {
        private string _ID;
        private string _Title;
        private string _Body;
        private string _moreInfoURL;
        private string _moreInfoButtonText;

        public string ID { get => _ID; set => _ID = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Body { get => _Body; set => _Body = value; }
        public string MoreInfoURL { get => _moreInfoURL; set => _moreInfoURL = value; }
        public string MoreInfoButtonText { get => _moreInfoButtonText; set => _moreInfoButtonText = value; }
        public bool loadByTopic(string id)
        {
            StringBuilder bt = new StringBuilder();
            ID = id;
            switch (id)
            {
               

                case "Concat":
                    Title = "Task Package Concat Tool";
                    bt.Append("This tool is designed to take the three PDF reports generated by D4H for EMBC, combine them together into a single PDF, and (at your option) add editable fields you can then fill in order to complete your paperwork."); bt.Append(Environment.NewLine); bt.Append(Environment.NewLine);
                    bt.Append("Note there is a known issue where the signature fields are not shown when the document is printed. This is a default behaviour in the code used to add fields to the PDF, and reinforces a best practice in so far as digital signature data is not captured in a paper printout."); bt.Append(Environment.NewLine); bt.Append(Environment.NewLine);
                    bt.Append("To use the tool, simply generate the three PDFs from D4H, save them to your computer, and browse to each of them here in the tool."); bt.Append(Environment.NewLine); bt.Append(Environment.NewLine);
                    bt.Append("Press “GO” and choose a file name to save the new combined file."); bt.Append(Environment.NewLine); bt.Append(Environment.NewLine);
                    Body = bt.ToString();
                    return true;


                default:
                    return false;


            }


        }
    }
}
