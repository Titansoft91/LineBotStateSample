namespace LineBotStateSample
{
    public class LineBot
    {
        public static LineBotState _welcomeState = new WelcomeState();
        public static LineBotState _bindState = new BindState();
        public static LineBotState _gameListState = new GameListState();

        private LineBotState _currentState;
        private LineBotState _lastState;
        public static LineBotState _GetLanguageMenuState = new GetLanguageMenuState();
        public static LineBotState _SetLanguageState = new SetLanguageState();

        public void SetCurrentState(LineBotState state)
        {
            _currentState = state;
            _currentState.SetLineBot(this);
        }

        public LineBotState GetCurrentState()
        {
            return _currentState;
        }

        /// <summary>
        /// line bot listener
        /// </summary>
        /// <param name="text">The text.</param>
        public void Listen(string text)
        {
            if (IsWelcome(text))
            {
                Welcome(text);
            }
            else if (IsBind(text))
            {
                Bind(text);
            }
            else if (IsGameList(text))
            {
                GameList(text);
            }
            else
            {
                _currentState.Default(text);
            }
            //var commandMatchers = new List<ICommandMatcher>
            //{
            //    new WelcomeMatcher(this),
            //    new BindMatcher(this),
            //    new GameListMatcher(this),
            //};

            //var commandMatcher = commandMatchers.FirstOrDefault(m => m.IsMatch(text));
            //if (commandMatcher == null)
            //{
            //    _currentState.Default(text);
            //}
            //else
            //{
            //    commandMatcher.Do(text);
            //}
        }

        private bool IsGameList(string text)
        {
            return new GameListMatcher(this).IsMatch(text);
        }

        private bool IsBind(string text)
        {
            return new BindMatcher(this).IsMatch(text);
        }

        private bool IsWelcome(string text)
        {
            return new WelcomeMatcher(this).IsMatch(text);
        }

        /// <summary>
        /// state machine behavior: Welcomes
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public LineBot Welcome(string text)
        {
            _currentState.Welcome(text);
            return this;
        }

        /// <summary>
        /// state machine behavior: bind account
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public LineBot Bind(string text)
        {
            _currentState.Bind(text);
            return this;
        }

        /// <summary>
        /// state machine behavior: get game list
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public LineBot GameList(string text)
        {
            _currentState.GameList(text);
            return this;
        }

        /// <summary>
        /// state machine behavior: get game list
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public LineBot GetLanguageMenu(string text)
        {
            _currentState.GetLanguageMenu(text);
            return this;
        }

        public LineBot SetLanguage(string text)
        {
            _currentState.SetLanguage(text);
            return this;
        }

        public void SetLastState(LineBotState state)
        {
            _lastState = state;
        }

        public LineBotState GetLastState()
        {
            return _lastState;
        }
    }
}