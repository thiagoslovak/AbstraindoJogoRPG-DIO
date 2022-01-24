namespace app.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType; 
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        

        //Sobrescrevendo o metodo ToString, para que possa imprimir na tela como por exempo:
        //Console.Writeline(hero)... Como estou sobrescrevendo o ToString, ele ira imprimir oque tem dentro desse escopo
        public override string ToString()
        {
            return this.Name + " " + this.Level + " " +this.HeroType;
        }  

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        } 
    }
}