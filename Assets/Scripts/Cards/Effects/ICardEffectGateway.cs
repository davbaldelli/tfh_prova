namespace Cards.Effects
{
    public interface ICardEffectGateway
    {
        public void addLife(int amount);
        public void addAttackMult(float amount);
        public void addDefenseMult(float amount);
        public void drawCard();
    }
}