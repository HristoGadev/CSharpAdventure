using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        private List<Pokemon> pokemons;

        public string Name { get; }

        public int BadgesCount { get; private set; } = 0;

        public IReadOnlyCollection<Pokemon> Pokemons => this.pokemons.AsReadOnly();

        public Trainer(string name)
        {
            this.Name = name;
            this.pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.pokemons.Add(pokemon);
        }

        public void AddBadge()
        {
            this.BadgesCount++;
        }

        public void TakeDamage()
        {
            this.pokemons.ForEach(p => p.ReduceHealth());
            this.pokemons.RemoveAll(p => p.Health <= 0);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.BadgesCount} {this.pokemons.Count}";
        }
    }
}