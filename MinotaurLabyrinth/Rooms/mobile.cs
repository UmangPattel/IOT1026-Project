namespace MinotaurLabyrinth

{
    /// <summary>
    /// Represents a portal room, which contains portal that can take the Gun.
    ///</summary>
    public class mobile : Room
    {
        static mobile()
        {
            RoomFactory.Instance.Register(RoomType.Room, () => new mobile());
        }
        /// <inheritdoc/>
        public override RoomType Type { get; } = RoomType.Room;

        ///<inheritdoc/>
        public override bool IsActive { get; protected set; } = true;

        /// <summary>
        /// Activating this room, make the user to lose the game if the player didnt found the gun.
        ///</summary>
        public override void Activate(Hero hero, Map map)
        {
            if (IsActive)
            {
                ConsoleHelper.WriteLine("You walk into the room and find the gun to win the game.", ConsoleColor.DarkGreen);
                ///this would be the  probability of PUBG player that if he can win or lose the game.
                double chanceOfSuccess = hero.HasGun ? 0.25 : 0.75;


                if (hero.HasGun)
                {
                    ConsoleHelper.WriteLine("the player is in room now the player has to find the gun to win the game", ConsoleColor.DarkBlue);
                    if (RandomNumberGenerator.NextDouble() < chanceOfSuccess)
                    {
                        IsActive = false;
                        ConsoleHelper.WriteLine("Now you have enter in the game. Find the path to find the gun and win the game.", ConsoleColor.DarkBlue);

                    }
                    else
                    {
                        ConsoleHelper.WriteLine("if you don't find the gun you will lose the game and you have to leave the room.", ConsoleColor.DarkBlue);
                    }
                }



            }
        }
    }
}
