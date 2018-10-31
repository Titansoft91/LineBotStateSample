namespace LineBotStateSample
{
    public class LineBot
    {
        public static LineBotState _welcomeState = new WelcomeState();
        public static LineBotState _bindState = new BindState();
        public static LineBotState _gameListState = new GameListState();

        private LineBotState _currentState;

        public void SetCurrentState(LineBotState state)
        {
            _currentState = state;
            _currentState.SetLineBot(this);
        }

        public LineBotState GetCurrentState()
        {
            return _currentState;
        }

        public LineBot Welcome(string text)
        {
            _currentState.Welcome(text);
            return this;
        }

        public LineBot Bind(string text)
        {
            _currentState.Bind(text);
            return this;
        }

        public LineBot GameList(string text)
        {
            _currentState.GameList(text);
            return this;
        }
    }
}