using DesignPatterns.StatePattern;
using NUnit.Framework;

namespace DesignPatterns.Tests.StatePatternTests
{
    [TestFixture]
    public class PlayerTests
    {
        private Player _Player;

        [Test]
        public void Test_CreatingAPlayerWithName()
        {
            Assert.That(_Player.Name,Is.EqualTo("mark"));
        }

        [Test]
        public void Test_NewPlayerState_IsHealth()
        {
            Assert.That(_Player.State,Is.EqualTo(PlayerState.Healthy));
        }

        [Test]
        public void Test_WhenNewPlayerIsHit_StateBecomesUnhealthy()
        {
            _Player.Hit();

            Assert.That(_Player.State,Is.EqualTo(PlayerState.UnHealthy));
        }

        [Test]
        public void Test_WhenUnhealthyPlayerIsHealed_StateBecomesHealth()
        {
            _Player.Heal();

            Assert.That(_Player.State,Is.EqualTo(PlayerState.Healthy));
        }

        [Test]
        public void Test_WhenUnhealthPlayerIsHit_StateBecomesDead()
        {
            _Player.Hit();
            _Player.Hit();

            Assert.That(_Player.State,Is.EqualTo(PlayerState.Dead));
        }

        [Test]
        public void Test_WhePlayerIsDead_HealingDoesNotWork()
        {
            _Player.Hit();
            _Player.Hit();
            
            _Player.Heal();

            Assert.That(_Player.State,Is.EqualTo(PlayerState.Dead));
        }

        [SetUp]
        public void Setup()
        {
            _Player = new Player("mark");   
        }
    }
}
