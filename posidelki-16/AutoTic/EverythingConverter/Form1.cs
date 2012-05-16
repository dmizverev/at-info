using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WatiN.Core;
using Form = System.Windows.Forms.Form;


namespace EverythingConverter
{
    public partial class Form1 : Form
    {
        private static IE _webBrowser;
        private static IE Browser
        {
            get 
            { 
                _webBrowser = _webBrowser ?? new IE();
                return _webBrowser;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            lblConvertResult.Text = "";

            // А мы уже там?
            if (!Browser.Title.Contains("Google"))
            {
                Browser.GoTo("http://google.com");
            }

            // Выполняем поиск в Google
            TextField txtSearchBox = Browser.TextField(Find.ByName("q"));
            txtSearchBox.TypeText(txtSource.Text);

            // Спрашиваем браузер: Мы уже пришли? (С) Ослик из Шрека
            Browser.WaitForComplete();
            
            Button btnSearch = Browser.Button(Find.ByName("btnK"));
            
            btnSearch.Click();

            // (С) Ослик из Шрека
            Browser.WaitForComplete();

            var topStuff = Browser.Div("topstuff");
            topStuff.WaitUntilExists();

            var lnkSpell = topStuff.Link(Find.ByClass("spell"));

            // Возможно, вы имели в виду: 10 долларов в гривнах  
            if (lnkSpell.Exists && lnkSpell.Style.GetAttributeValue("visibility") == "visible")
            {
                string spellText = lnkSpell.Text;
                lblConvertResult.Text = "Ошибка! Возможно, вы имели в виду: " + spellText;
                txtDest.Text = "";
                return;
            }

            TableCell lblConvertedValue =
                (from cell in topStuff.TableCells
                 where cell.Element(Find.ByClass("r")).Exists
                 select cell
                ).FirstOrDefault();

            if (lblConvertedValue == null || String.IsNullOrEmpty(lblConvertedValue.Text))
            {
                lblConvertResult.Text = "Ой, что-то случилось. Обычно такой текст остается в продакшене";
                txtDest.Text = "";
                return;
            }

            txtDest.Text = lblConvertedValue.Text;
        }
    }
}
