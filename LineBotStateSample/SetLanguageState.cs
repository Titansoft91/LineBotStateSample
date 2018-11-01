using System;

namespace LineBotStateSample
{
    public class SetLanguageState : LineBotState
    {
        public override void Default(string text)
        {
            Console.WriteLine($"set language:{text}");
        }

        public override void Welcome(string text)
        {
            throw new NotImplementedException();
        }

        public override void Bind(string text)
        {
            throw new NotImplementedException();
        }

        public override void GameList(string text)
        {
            throw new NotImplementedException();
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