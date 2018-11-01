using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LineBotStateSample
{
    [TestClass]
    public class UnitTest1
    {
        private LineBot _lineBot = new LineBot();

        [TestMethod]
        public void linebot_behaviors()
        {
            _lineBot.SetCurrentState(new BindState());

            var text = "gamelist joey123";

            _lineBot.Listen(text);
            Console.WriteLine(_lineBot.GetCurrentState());
            //_lineBot.Welcome(text)
            //    .Bind(text)
            //    .GameList(text)

            //_lineBot.Welcome(text)
            //    .GameList(text);
        }
    }
}