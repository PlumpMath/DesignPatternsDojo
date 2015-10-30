namespace DesignPatterns.StatePattern
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
            State = PlayerState.Healthy;
        }

        public string Name { get; private set; }
        public PlayerState State { get; set; }

        public void Hit()
        {
            State = State == PlayerState.UnHealthy ? PlayerState.Dead : PlayerState.UnHealthy;
        }

        public void Heal()
        {
            State = State == PlayerState.Dead ? PlayerState.Dead : PlayerState.Healthy;
        }
    }

    public enum PlayerState
    {
        Unknown,
        Healthy,
        UnHealthy,
        Dead
    }
}
