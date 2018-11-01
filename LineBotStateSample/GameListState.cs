using System;

namespace LineBotStateSample
{
    internal class GameListState : LineBotState
    {
        public override void Default(string text)
        {
            Console.WriteLine("game list");
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