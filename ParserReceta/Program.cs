using System;
using Antlr4.Runtime;
using ParserReceta;

namespace ParserReceta
{
    class Program
    {
        static void Main(string[] args)
        {
            string operacion = "{Jose#+Maria# { Carlos, Alfredo + Clara{Juana#+Pedro{ Armandito }, Matilda+Alexis { Pepe }}}}";

            Console.WriteLine($"Input: {operacion} \n");
            ICharStream charStream = CharStreams.fromString(operacion);
            programLexer lexer = new programLexer(charStream);
            CommonTokenStream token = new CommonTokenStream(lexer);
            programParser parser = new programParser(token);
            var tree = parser.program();
            Recet aritmetica = new Recet();
            int res = aritmetica.Visit(tree);
        }
    }
}
