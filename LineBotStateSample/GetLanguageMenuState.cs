using System;

namespace LineBotStateSample
{
    public class GetLanguageMenuState : LineBotState
    {
        public override void Default(string text)
        {
            //push language menu to line client
            Console.WriteLine("push language menu to line client");
        }

        public override void Welcome(string text)
        {
            Default(text);
        }

        public override void Bind(string text)
        {
            Default(text);
        }

        public override void GameList(string text)
        {
            Default(text);
        }

        public override void GetLanguageMenu(string text)
        {
            throw new NotImplementedException();
        }

        public override void SetLanguage(string text)
        {
            throw new NotImplementedException();
        }
    }
}