namespace Assets.Scripts
{
    public interface GameManagerGateway
    {
        public void finishTurn();
        public void startGame(Card[] startingCards);
        public void drawCards();
    }
}