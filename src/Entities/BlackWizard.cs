namespace project.src.Entities
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name,int Level,string HeroType, int HP, int MP){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack(int DamageValue){
            return base.Attack(DamageValue)+"\nMagic attack, Damage "+(DamageValue+DamagePercentage(DamageValue));
        }
    }
}