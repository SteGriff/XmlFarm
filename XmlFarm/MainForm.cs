using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using XSharper.Core;

namespace XmlFarm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
	        //Here's our XML as a string, but it could be loaded from a file or web service
            string myXml = xmlBox.Text;

	        //It requires a Stream type, so let's make a MemoryStream on top of the string
	        MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(myXml));
	
	        //Make a serializer, and deserialize using our model
	        XmlSerializer serializer = new XmlSerializer(typeof(Farm));
	        var theFarm = (Farm)serializer.Deserialize(memStream);

            //Just making use of XSharper dump here to output the results
            resultsBox.Text = Dump.ToDump(theFarm);
        }

        [XmlRoot("Farm")]
        public class Farm
        {
            [XmlArray("Pasture")]
            [XmlArrayItem("Animal")]
            public List<Animal> Animals { get; set; }

            [XmlElement("Barn")]
            public BarnNode Barn { get; set; }

            public class Animal
            {
                [XmlAttribute("Name")]
                public string Name { get; set; }

                [XmlText]
                public string Quantity { get; set; }
            }

            public class BarnNode
            {
                [XmlElement("Animal")]
                public List<Animal> Animals { get; set; }

                [XmlElement("SheepPen")]
                public SheepPenNode SheepPen { get; set; }

                public class SheepPenNode
                {
                    [XmlElement("Animal")]
                    public List<Animal> Animals { get; set; }
                }
            }
        }

    }
}
