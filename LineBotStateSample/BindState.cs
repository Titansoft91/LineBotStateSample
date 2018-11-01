using System;

namespace LineBotStateSample
{
    internal class BindState : LineBotState
    {
        public override void Default(string text)
        {
            Console.WriteLine("bind");
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
            base._lineBot.SetCurrentState(LineBot._gameListState);
            base._lineBot.GameList(text);
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