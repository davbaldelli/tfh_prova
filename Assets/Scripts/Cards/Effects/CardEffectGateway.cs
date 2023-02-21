namespace Cards.Effects
{
    public interface CardEffectGateway
    {
        public void addLife(int amount);
        public void addAttackMult(float amount);
        public void addDefenseMult(float amount);
        public void drawCard();
    }
}