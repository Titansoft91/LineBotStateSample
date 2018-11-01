namespace LineBotStateSample
{
    public interface ICommandMatcher
    {
        bool IsMatch(string text);

        void Do(string text);
    }
}