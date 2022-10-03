using Football;

namespace FootballPlayerRest.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>()
        {
            new FootballPlayer {Id = _nextId++, Name = "Casper", Age = 25, ShirtNumber = 7},
            new FootballPlayer {Id = _nextId++, Name = "Joe", Age = 22, ShirtNumber = 10},
            new FootballPlayer {Id = _nextId++, Name = "Leo", Age = 24, ShirtNumber = 3},
            new FootballPlayer {Id = _nextId++, Name = "Tim", Age = 26, ShirtNumber = 1},
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(fbPlayer => fbPlayer.Id == id);
        }
        public FootballPlayer Add(FootballPlayer fbPlayer)
        {
            fbPlayer.Id = _nextId++;
            Data.Add(fbPlayer);
            return fbPlayer;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer fbPlayer = Data.Find(fbPlayer => fbPlayer.Id == id);
            if (fbPlayer == null) return null;
            Data.Remove(fbPlayer);
            return fbPlayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer fbPlayer = Data.Find(fbPlayer => fbPlayer.Id == id);
            if (fbPlayer == null) return null;
            fbPlayer.Name = updates.Name;
            fbPlayer.Age = updates.Age;
            fbPlayer.ShirtNumber = updates.ShirtNumber;

            return fbPlayer;
        }
    }
}
