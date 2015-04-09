using System;
using System.Net;
using LeagueSharp;
using LeagueSharp.Common;

namespace NãoEscrevaParaMim
{
    class Program
    {
        private static readonly string Revision = "1";

        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
            // CustomEvents.Game.OnGameLoad += Up2Date;
            CustomEvents.Game.OnGameEnd += Game_OnGameEnd;
        }

        //  private static void Up2Date(EventArgs args)
        //{
        //  var wc = new WebClient { Proxy = null  };
        //var gitrevision = wc.DownloadString("https://raw.githubusercontent.com/Adilx05/ChatBan/master/ChatBan%C4%B1mVar/Kontrol.txt");

        //if (Revision != gitrevision)
        //{
        //  Game.PrintChat("<font color=\"#FFFFCC\"><b>A New Version Found Please Update</b></font>");
        //}
        //}

        private static void Game_OnGameLoad(EventArgs args)
        {

            Game.Say(RastgeleMetin());

        }

        public static string RastgeleMetin()
        {

            string[] cumleler = new string[5];
            cumleler[0] = "Eu Tenho Conversacao Ban Entao Eu Nao Posso Escrever";
            cumleler[1] = "Se Eu Escrever No Jogo Confuso Entao Eu Nao Posso Escrever No Jogo";
            cumleler[2] = "Rito Deu Um Papo Ban Para Mim, Entao Eu Nao Posso Escrever No Jogo";
            cumleler[3] = "Por Favor, Jogar Com Cuidado Nao Grave Uns Aos Outros";
            cumleler[4] = "Tenho Algumas Ping. Se Eu jogar Mal Por Favor Me Desculpe";

            Random rnd = new Random();
            int rastgele = rnd.Next(0, 4);
            return cumleler[rastgele];
        }

        private static void Game_OnGameEnd(EventArgs args)
        {
            Game.Say("GG");
        }




    }




}