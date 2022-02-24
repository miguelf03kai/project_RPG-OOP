namespace project.src.Entities
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public Hero(string Name,int Level,string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public Hero(){

        }

        public string ShowAttributes(){
            return "Name: "+Name+
                   "\nLevel: "+Level+
                   "\nType: "+HeroType+
                   "\nHP: "+HP+
                   "\nMP: "+MP;
        }

        public virtual string Attack(int DamageValue){
            return "Physical attack, Damage "+DamageValue;
        }

        public int DamagePercentage(int DamageValue){
            int Percentage = (DamageValue * DamageValue)/100;
            return Percentage;
        }
    }
}