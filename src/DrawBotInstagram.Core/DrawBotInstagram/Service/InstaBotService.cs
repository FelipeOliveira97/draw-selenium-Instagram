// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading;
// using System.Threading.Tasks;
// using BotInstagram.Models;
// using OpenQA.Selenium;
// using OpenQA.Selenium.Chrome;

// namespace BotInstagram.Service
// {
//     public class InstaBotService
//     {
//         private readonly string _credentialsPath;
//         private IWebDriver _driver;
        
//         public InstaBotService()
//         {
//             _driver = new ChromeDriver(@"C:\Users\sampa\Projects\-DrawBotInstagram\DotNetCore\");
//         }

//         public async Task ExecuteInstagram(string link, string user, string password, int qtd, IList<IList<object>> sheetValues)
//         {
//             try
//             {
//                 var pessoas = new List<Pessoa>();
                
//                 _driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/?source=auth_switcher");
                
//                 Thread.Sleep(7500);

//                 _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div/div[1]/div/label/input")).SendKeys(user);
//                 _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div/div[2]/div/label/input")).SendKeys(password);
//                 _driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/div/div[3]/button")).Submit();
                
//                 Thread.Sleep(7500);
                
//                 _driver.Navigate().GoToUrl(link);
//                 var pagina = _driver.CurrentWindowHandle;
//                 _driver.SwitchTo().Window(pagina);

//                 switch (qtd)
//                 {
//                     case 2:
//                         foreach (var nome in sheetValues)
//                         {
//                             pessoas.Add(new Pessoa() { User = nome[0].ToString().Contains('@') ? nome[0].ToString() : $"@{nome[0].ToString()}" });

//                             if (pessoas.Count == 2)
//                             {
//                                 _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form")).Click();
//                                 var _pessoas = _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/textarea"));
//                                 _pessoas.SendKeys(pessoas.ElementAt(0).User + " " + pessoas.ElementAt(1).User);
//                                 _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/button")).Submit();
//                                 Thread.Sleep(60000);
//                                 pessoas.RemoveAt(1);
//                                 pessoas.RemoveAt(0);
//                             }
//                         }
//                         break;

//                     case 3:
//                         foreach (var nome in sheetValues)
//                         {
//                             pessoas.Add(new Pessoa() { User = nome[0].ToString().Contains('@') ? nome[0].ToString() : $"@{nome[0].ToString()}" });
//                             if (pessoas.Count == 3)
//                             {
//                                 _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form")).Click();
//                                 var _pessoas = _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/textarea"));
//                                 _pessoas.SendKeys(pessoas.ElementAt(0).User + " " + pessoas.ElementAt(1).User);
//                                 _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/button")).Submit();
//                                 Thread.Sleep(60000);
//                                 pessoas.RemoveAt(2);
//                                 pessoas.RemoveAt(1);
//                                 pessoas.RemoveAt(0);
//                             }
//                         }
//                         break;

//                     default:
//                         foreach (var nome in sheetValues)
//                         {
//                             var Users = nome[0].ToString().Contains('@') ? nome[0].ToString() : $"@{nome[0].ToString()}";

//                             _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form")).Click();
//                             var pessoa = _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/textarea"));
//                             pessoa.SendKeys(Users.ToString());
//                             _driver.FindElement(By.XPath("//*[@id=\"react-root\"]/section/main/div/div[1]/article/div[3]/section[3]/div/form/button")).Submit();
//                             Thread.Sleep(60000);
//                         }
//                         break;
//                 }
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine("Message: {0}", e.InnerException is null ? e.Message : e.InnerException.Message);
//                 Console.WriteLine("Trace: {0}", e.InnerException is null ? e.StackTrace : e.InnerException.StackTrace);
//             }
//             finally
//             {
//                 _driver.Dispose();
//                 _driver.Close();
//             }
//         }
//     }
// }