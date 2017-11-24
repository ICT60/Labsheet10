using System;

namespace Labsheet10
{
    class PersonInfo
    {
        int age;
        string name;
        string nickname;

        public int Age => age;
        public string Name => name;
        public string NickName => nickname;


        public PersonInfo(string name)
        {
            age = 0;
            this.name = name;
            this.nickname = String.Empty;
        }

        public PersonInfo(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.nickname = String.Empty;
        }

        public PersonInfo(string name, int age, string nickname)
        {
            this.name = name;
            this.age = age;
            this.nickname = nickname;
        }
    }
}
