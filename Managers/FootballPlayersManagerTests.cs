using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayerRest.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football;

namespace FootballPlayerRest.Managers.Tests
{

    [TestClass()]
    public class FootballPlayersManagerTests
    {
        [TestMethod()]
        public void AddFootballPlayerTest()
        {
            // Arrange
            FootballPlayersManager manager = new FootballPlayersManager();
            FootballPlayer newfbPlayer = new FootballPlayer { Name = "Mike", Age = 18, ShirtNumber = 13 };

            // Act
            FootballPlayer addedfbPlayer = manager.Add(newfbPlayer);

            // Assert
            Assert.AreEqual(5, newfbPlayer.Id);
            Assert.AreEqual(5, manager.GetAll().Count);
        }

        [TestMethod()]
        public void GetAllFootballPlayersTest()
        {
            // Arrange
            FootballPlayersManager manager = new FootballPlayersManager();

            // Act
            List<FootballPlayer> footballPlayers = manager.GetAll();
            
            // Assert
            Assert.AreEqual(5, footballPlayers.Count);
        }



    }
}