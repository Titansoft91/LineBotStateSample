namespace LineBotStateSample
{
    public class BindMatcher : ICommandMatcher
    {
        private readonly LineBot _lineBot;

        public BindMatcher(LineBot lineBot)
        {
            _lineBot = lineBot;
        }

        public bool IsMatch(string text)
        {
            return text.Trim().ToLower().StartsWith("bind");
        }

        public void Do(string text)
        {
            _lineBot.Bind(text);
        }
    }
}