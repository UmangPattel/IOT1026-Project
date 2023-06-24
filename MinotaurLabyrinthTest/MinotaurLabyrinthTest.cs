using MinotaurLabyrinth;

namespace MinotaurLabyrinthTest
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]

        public void GelMoveTest()
        {
            Hero hero = new Hero();
            var gelLocation = new Location(1, 1);
            Charizard gel = new(gelLocation);
            Map map = new Map(4, 4);
            map.GetRoomAtLocation(gelLocation).AddMonster(gel);
            map.SetRoomAtLocation(new Location(2, 1), RoomType.Pit);




            gel.Move(hero, map);
            //New location should be (1,1)
            var expectedLocation = new Location(2, 1);
            Assert.AreEqual(expectedLocation, gel.GetLocation());
            gel.Move(hero, map);
            expectedLocation = new Location(3, 1);
            Assert.AreEqual(expectedLocation, gel.GetLocation());
            gel.Move(hero, map);
            expectedLocation = new Location(3, 1);
            Assert.AreEqual(expectedLocation, gel.GetLocation());
        }
    }
}
