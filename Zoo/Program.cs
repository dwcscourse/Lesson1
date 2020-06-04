using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cage d = Cage.CreateCage(Cage.CageSize.Medium);
      
        }



        private static void TestPolymorphism()
        {
            // Променлива от тип ICarnivore. Може да сочи към обект, който наследява интерфейс ICarnivore.
            // Чрез нея могат да бъдат достъпени методите описани в този интерфейс
            // както и методите описани в Object, защото всичко така или иначе наследява Object
            ICarnivore carnivore = CreateCarnivore();
            carnivore.EatMeat();
            carnivore.ToString();

            //Но чрез нея не могат да бъдат извикани методите на обект Fox, тък като тя (променливата) не е от тип Fox.
            //carnovore.StealTheCheese()


            //Променлива от тип AbstractAnimal. Може да сочи към обект, който наследява обект AbstractAnimal.
            //Чрез нея могат да бъдат достъпени методите описани в AbstractAnimal,
            //както и методите описани в Object, защото всичко така или иначе наследява Object
            //Но пак както преди не може да бъде използвана за извикване на методите на FOX
            AbstractAnimal anyAnimal = CreateAbstractAnimal();

            //Променлива от тип Object, може да сочи към всичко, защото всичко всъщност наследява Object, директно или не.
            //Но може да бъде използвана за извикване само на методи дефинирани в Object
            Object obj = CreateObject();
            obj.GetHashCode();

            // променлива от тип IHerbivore. Може да сочи към обект наследяващ IHerbivore - Elephant, Rabbit или Fox,
            // но не може да сме 100% сигурни към кое от тях без да сме проверили
            IHerbivore herbivore = CreateHerbivore();

            // може да проверим дали случайно не сочи към Rabbit
            if (herbivore is Rabbit)
            {
                // по случайност сочи към обект който всъщност е Rabbit
                Rabbit r; // създаваме променлива от тип Заек - тя може да сочи само към обект от тип Заек.
                r = (Rabbit)herbivore; // тъй като вече сме проверили, че herbivore всъщност сочи към Заек е безопасно да кастнем към Заек.
                // тъй като r е от тип Заек може да извикваме методите на заек.
                r.DoZigZag();
            }
            else if (herbivore is Fox)
            {
                // съкратена версия на предното
                ((Fox)herbivore).StealTheCheese();
            }
            else if (herbivore is Elephant el)
            {
                // още по-съкратена версия на предното.
                el.DrinkFromTheNose();
            }

            // директното кастване е опасно: ((Fox)herbivore).StealTheCheese();
            // Използва се само ако преди това сме направили проверка дали наистина обекта е такъв, какъвто ние очакваме: if (herbivore is Fox)
            // В противен случай програмата ще гръмне ако не сме уцелили правилният тип

            //Втори вариант на кастване - ключова дума "as" :
            Fox fox = herbivore as Fox;
            if (fox == null)
            {
                // резултат 1: herbivore не е от тип лисица и няма как да бъде третиран като такава. Променливата Fox ще сочи към нищото.
                // При такъв вид кастване трябва винаги да се провери дали променливата не е null.
                Console.WriteLine("This herbivore is not a fox");
            }
            else
            {
                //резултат 2: успешно успяхме да кастнем към лисица, това означава, че обекта herbivore всъщност е лисица.
                // и сега чрез променливата fox може да викаме методи характерни само за лисица.
                fox.StealTheCheese();
            }


            //Всяка променлива от референтен тип А може:  
            Fox f = new Fox(); //да сочи към обект от тип А
            IHerbivore herb = new Rabbit(); //, обект, който наследява А
            Elephant elephant = null;//или към нищо (null)
        }

        private static IHerbivore CreateHerbivore()
        {
            return new Rabbit();
        }

        private static Object CreateObject()
        {
            return new Lion();
        }

        private static AbstractAnimal CreateAbstractAnimal()
        {
            return new Elephant();
        }

        private static ICarnivore CreateCarnivore()
        {
            return new Fox();
        }
     
    }
}

