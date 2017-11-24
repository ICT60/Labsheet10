namespace Labsheet10
{
    class Person
    {
        PersonInfo info;
        Money money;

        public PersonInfo Info => info;
        public Money Money => money;


        public Person()
        {
            info = new PersonInfo("");
            money = new Money(0);
        }

        public Person(string name, decimal money)
        {
            info = new PersonInfo(name);
            this.money = new Money(money);
        }

        public Person(PersonInfo info, decimal money)
        {
            this.info = info;
            this.money = new Money(money);
        }
    }
}
