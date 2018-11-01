namespace LineBotStateSample
{
    public abstract class LineBotState
    {
        protected LineBot _lineBot;

        public void SetLineBot(LineBot lineBot)
        {
            _lineBot = lineBot;
        }

        public abstract void Default(string text);

        public abstract void Welcome(string text);

        public abstract void Bind(string text);

        public abstract void GameList(string text);

        public abstract void GetLanguageMenu(string text);
        //{
        //    _lineBot.SetLastState(_lineBot.GetCurrentState());
        //    _lineBot.SetCurrentState(LineBot._GetLanguageMenuState);
        //    _lineBot.GetLanguageMenu(text);
        //}

        public abstract void SetLanguage(string text);
        //{
        //    _lineBot.SetCurrentState(LineBot._SetLanguageState);
        //    _lineBot.SetLanguage(text);

        //    _lineBot.GetLastState().Default(text);
        //}
    }
}