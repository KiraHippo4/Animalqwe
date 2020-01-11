   using System;

    namespace Animal
    {
        interface IAnimal
        {
        }

        interface IAction
        {
            void DoAction();
        }

        interface IWalker
        {
            void Walk();
        }

        interface ISwimmer
        {
            void Swim();
        }
        interface IBreathe
        {
            void Breathe();
        }

        class SwimAction : ISwimmer
        {
            public void Swim()
            {
                Console.WriteLine("Плывёт");
            }
        }
        class BreatheAction : IBreathe
        {
            public void Breathe()
            {
                Console.WriteLine("Дышит");
            }
        }

        class WalkAction : IAction
        {
            public void DoAction()
            {
                Console.WriteLine("Идёт");
            }
        }

        class Hippo : IAnimal, IWalker, ISwimmer, IBreathe
        {
            IAction walkAction;
            ISwimmer swimAction;
            IBreathe breatheAction;

            public Hippo()
            {
                Console.WriteLine("Бегемот");
                walkAction = new WalkAction();
                swimAction = new SwimAction();
                breatheAction = new BreatheAction();
            }

            public void Swim()
            {
                swimAction.Swim();
            }
            public void Breathe()
            {
                breatheAction.Breathe();
            }

            public void Walk()
            {
                walkAction.DoAction();
            }
        }
        class Dog : IAnimal, IWalker, ISwimmer, IBreathe
        {
            IAction walkAction;
            ISwimmer swimAction;
            IBreathe breatheAction;

            public Dog()
            {
                Console.WriteLine("Собака");
                walkAction = new WalkAction();
                swimAction = new SwimAction();
                breatheAction = new BreatheAction();
            }

            public void Swim()
            {
                swimAction.Swim();
            }
            public void Breathe()
            {
                breatheAction.Breathe();
            }

            public void Walk()
            {
                walkAction.DoAction();
            }
        }

        class Runner
        {
            static void Main(string[] args)
            {


                Console.WriteLine("Выберите a для собакелы и 2 для бегемота");
                string answer = Console.ReadLine();

                if (answer == "a")
                {

                    var dog = new Dog();
                    Console.WriteLine("Выберите  для собакелы действия v идти b дышать");
                    answer = Console.ReadLine();
                    if (answer == "v")
                    {
                        dog.Walk();
                    }
                    else if (answer == "b")
                    {
                        dog.Breathe();
                    }

                    // dog.Swim();

                }
                else if (answer == "2")
                {
                    var hippo = new Hippo();
                    hippo.Walk();
                    hippo.Swim();
                    hippo.Breathe();
                }
                else
                {
                    Console.WriteLine("Что же Вы выбираете это? " + answer);
                }


            }
        }
    }

