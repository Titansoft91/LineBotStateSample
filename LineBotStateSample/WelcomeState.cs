using System;

namespace LineBotStateSample
{
    internal class WelcomeState : LineBotState
    {
        protected override void Default(string text)
        {
            Console.WriteLine("welcome");
        }

        public override void Welcome(string text)
        {
            Default(text);
        }

        public override void Bind(string text)
        {
            base._lineBot.SetCurrentState(LineBot._bindState);
            base._lineBot.Bind(text);
        }

        public override void GameList(string text)
        {
            base._lineBot.SetCurrentState(LineBot._gameListState);
            base._lineBot.GameList(text);
        }
    }
}