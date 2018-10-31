namespace LineBotStateSample
{
    public abstract class LineBotState
    {
        protected LineBot _lineBot;

        public void SetLineBot(LineBot lineBot)
        {
            _lineBot = lineBot;
        }

        protected abstract void Default(string text);

        public abstract void Welcome(string text);

        public abstract void Bind(string text);

        public abstract void GameList(string text);
    }
}