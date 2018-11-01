namespace LineBotStateSample
{
    public class WelcomeMatcher : ICommandMatcher
    {
        private readonly LineBot _lineBot;

        public WelcomeMatcher(LineBot lineBot)
        {
            _lineBot = lineBot;
        }

        public bool IsMatch(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        public void Do(string text)
        {
            _lineBot.Welcome(text);
        }
    }
}