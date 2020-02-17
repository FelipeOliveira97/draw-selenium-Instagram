using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Windows.Forms;
using System.Data;

namespace InstagramBot.Business_Logic_Layer
{
    class BOT
    {
        IWebDriver insta = new ChromeDriver();
        public void Instagram(string link, string usuario, string senha, int qtd, DataSet conteudo)
        {
            List<Pessoas> p = new List<Pessoas>();
            try
            {

                #region Login
                insta.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");
                Thread.Sleep(7500);

                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[2]/div/label/input")).SendKeys(usuario);
                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[3]/div/label/input")).SendKeys(senha);
                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/article/div/div[1]/div/form/div[4]/button/div")).Submit();
                Thread.Sleep(7500);
                #endregion
                insta.Navigate().GoToUrl(link);
                var pagina = insta.CurrentWindowHandle;
                insta.SwitchTo().Window(pagina);

                switch (qtd)
                {
                    case 2:
                        foreach (DataRow nome in conteudo.Tables["Table"].Rows)
                        {
                            p.Add(new Pessoas() { User = Convert.ToString(nome["nomes"]) });
                            if (p.Count == 2)
                            {
                                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form")).Click();
                                var _pessoas = insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form/textarea"));
                                _pessoas.SendKeys(p.ElementAt(0).User + " " + p.ElementAt(1).User);
                                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form/button")).Submit();
                                Thread.Sleep(60000);
                                p.RemoveAt(1);
                                p.RemoveAt(0);
                            }
                        }
                        break;

                    case 3:
                        foreach (DataRow nome in conteudo.Tables["Table"].Rows)
                        {
                            p.Add(new Pessoas() { User = Convert.ToString(nome["nomes"]) });
                            if (p.Count == 3)
                            {
                                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form")).Click();
                                var _pessoas = insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form/textarea"));
                                _pessoas.SendKeys(p.ElementAt(0).User + " " + p.ElementAt(1).User + " " + p.ElementAt(2).User);
                                insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form/button")).Submit();
                                Thread.Sleep(60000);
                                p.RemoveAt(2);
                                p.RemoveAt(1);
                                p.RemoveAt(0);
                            }
                        }
                        break;

                    default:
                        foreach (DataRow nome in conteudo.Tables["Table"].Rows)
                        {
                            var Users = nome["nomes"];

                            insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form")).Click();
                            var pessoa = insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form/textarea"));
                            pessoa.SendKeys(Users.ToString());
                            insta.FindElement(By.XPath(".//*[@id='react-root']/section/main/div/div/article/div[2]/section[3]/div/form/button")).Submit();
                            Thread.Sleep(60000);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                insta.Dispose();
                MessageBox.Show("Algo deu errado, Favor contatar o Felipe.");
            }
            insta.Dispose();
            MessageBox.Show("Acabou, você brilhou. Adeux");
        }
    }
}
