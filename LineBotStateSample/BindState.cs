using System;

namespace LineBotStateSample
{
    internal class BindState : LineBotState
    {
        protected override void Default(string text)
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
    }
}