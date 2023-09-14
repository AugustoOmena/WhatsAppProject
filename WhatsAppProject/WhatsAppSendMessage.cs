using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAutomationFramework;

namespace WhatsAppProject
{
    public class WhatsAppSendMessage : Web
    {
        public void SendMessage(string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\guguo\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);

            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            CloseBrowser();
        }

        // ---------------------------------------------------------------------------------------------------------------------------------

        public void SendMessageWithImage(string message, string pathImage, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\guguo\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);



            //Clicar no botão CLIP
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/div/div/span");

            //Adicionar o caminho da Imagem
            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/ul/div/div[1]/li/div/input", pathImage);


            var elementInput = AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/div/div[3]/div[2]/span/div/span/div/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[1]/p", message);

            elementInput.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            Thread.Sleep(TimeSpan.FromSeconds(2));

            CloseBrowser();
        }

        // -------------------------------------------------------------------------------------------------------------------------------------------

        public void SendMessageGroupe(string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\guguo\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(3));
            
            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            Click(TypeElement.Xpath, "//*[@id=\"main\"]/div[2]/div/div[2]/div[3]/div[10]/div/div/div/div[2]/div[2]/div/span");

            elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/span[2]/div/div/div/div/div/div/div/div[1]/div/div/div[2]/div/div[1]/p", to);

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            Thread.Sleep(TimeSpan.FromSeconds(2));

            Click(TypeElement.Xpath, "//*[@id=\"app\"]/div/span[2]/div/div/div/div/div/div/div/span/div/div/div/span");

            Thread.Sleep(TimeSpan.FromSeconds(2));

            //*[@id="main"]/div[2]/div/div[2]/div[3]/div[12]/div/div/div/div[1]/span/div/div/span
            /*
            var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);

            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2));

            CloseBrowser();
            */
        }

        public void SendMessageGroup(string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\guguo\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(3));

            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div/div[2]/div/div[1]/p", to);

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/header/div[3]/div/div[2]/div/div/span");

            Click(TypeElement.Xpath, "//*[@id=\"app\"]/div/span[4]/div/ul/div/div/li[2]/div");

            // Selecao
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/div[2]/div/div[2]/div[3]/div[11]/div/div/span/div/div");
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/div[2]/div/div[2]/div[3]/div[10]/div/div/span/div/div");

            // compartilha
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/span[2]/div/button[4]/span");


            // repetir a quantidade de numeros que forem.
            elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/span[2]/div/div/div/div/div/div/div/div[1]/div/div/div[2]/div/div[1]/p", to);

            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            Click(TypeElement.Xpath, "//*[@id=\"app\"]/div/span[2]/div/div/div/div/div/div/div/div[1]/div/div/span/button/span");
            
        }

    }
}
