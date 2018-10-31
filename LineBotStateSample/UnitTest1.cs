using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LineBotStateSample
{
    [TestClass]
    public class UnitTest1
    {
        private LineBot _lineBot = new LineBot();

        [TestMethod]
        public void TestMethod1()
        {
            _lineBot.SetCurrentState(new BindState());

            var text = "";
            var commandMatchers = new List<ICommandMatcher>
            {
                new WelcomeMatcher(_lineBot),
                new BindMatcher(_lineBot),
                new GameListMatcher(_lineBot),
            };

            var commandMatcher = commandMatchers.First(m => m.IsMatch(text));
            commandMatcher.Do(text);

            //lineBot.Welcome(text)
            //    .Bind(text)
            //    .GameList(text)

            //lineBot.Welcome(text)
            //    .GameList(text);
        }

        private bool IsGameList(string arg)
        {
            return arg.Trim().StartsWith("gamelist");
        }

        private bool IsBind(string arg)
        {
            return arg.Trim().ToLower().StartsWith("bind");
        }

        private bool IsWelcome(string arg)
        {
            return string.IsNullOrWhiteSpace(arg);
        }
    }

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

    public interface ICommandMatcher
    {
        bool IsMatch(string text);

        void Do(string text);
    }
}