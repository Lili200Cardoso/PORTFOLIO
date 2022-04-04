namespace projetoCarrefour.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType){

            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack(int Bonus){
            if (Bonus > 6){
                return this.Name + " Usou Golpe  Super Efetiva com bonus de " +
                Bonus;
            } else {
                return this.Name + " Usou Golpe com Força Fraca com bonus de "
                + Bonus;
            }
        }
    }
}