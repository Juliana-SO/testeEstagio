using System;
using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {   
        int totalIdade = 0, i = 0, menores = 0;
        var people = new List<Person>
        {
            new Person("Isaac", 19),
            new Person("Juliana", 15),
            new Person("Alice", 11),
            new Person("Glaucia", 40),
            new Person("Marcos", 3),
        };
        Person nova = people[0];
        Person velha = people[0];

        Console.WriteLine("Lista de Pessoas:");
        foreach(var person in people)
        {
            Console.WriteLine("- " + person.Name + "  (" + person.Age + ")" );
        }
        Console.WriteLine();
        foreach(var person in people)
        {
            if(person.Age >= 18)
            {
                Console.WriteLine("- " + person.Name);
            }
        }
        foreach(var person in people)
        {
            totalIdade += person.Age;
            i += 1;
            if(person.Age < 18)
            {
                menores += 1;
            }
            if(person.Age > velha.Age)
            {
                velha = person;
            }
            if(person.Age < nova.Age)
            {
                nova = person;
            }
        }
        Console.WriteLine();

        double mediaIdade = (double)totalIdade / i;
        Console.WriteLine("Média de idade: "+ mediaIdade);
        Console.WriteLine("Pessoa mais nova: " + nova.Name + " (" + nova.Age + ")");
        Console.WriteLine("Pessoa mais velha: " + velha.Name + " (" + velha.Age + ")");
        Console.WriteLine("Quantidade de menores de idade: " + menores);
    }
}