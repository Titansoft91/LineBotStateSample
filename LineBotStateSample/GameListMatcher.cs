namespace LineBotStateSample
{
    public class GameListMatcher : ICommandMatcher
    {
        private readonly LineBot _lineBot;

        public GameListMatcher(LineBot lineBot)
        {
            _lineBot = lineBot;
        }

        public bool IsMatch(string text)
        {
            return text.Trim().ToLower().StartsWith("gamelist");
        }

        public void Do(string text)
        {
            _lineBot.GameList(text);
        }
    }
}