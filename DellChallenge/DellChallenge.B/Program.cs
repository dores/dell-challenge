using System;

namespace DellChallenge.B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the classes and interface below, please constructor the proper hierarchy.
            // Feel free to refactor and restructure the classes/interface below.
            // (Hint: Not all species and Fly and/or Swim)
        }
    }

    public interface ISpecies
    {
        void Eat();
        void Drink();
    }

    public interface IFlyer : ISpecies
    {
        void Fly();
    }

    public interface ISwimmer : ISpecies
    {
        void Swim();
    }

    public class Species
    {
        public virtual void GetSpecies()
        {
            Console.WriteLine($"Echo who am I?");
        }
    }

    public class Human : Species, ISpecies
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GetSpecies()
        {
            Console.WriteLine($"Human");
        }
    }

    public class Bird : Species, IFlyer
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public override void GetSpecies()
        {
            Console.WriteLine($"Bird");
        }

    }

    public class Fish : Species, ISwimmer
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public override void GetSpecies()
        {
            Console.WriteLine($"Fish");
        }
    }
}

