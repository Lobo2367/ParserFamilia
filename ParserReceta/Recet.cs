using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParserReceta
{
    internal class Recet : programBaseVisitor<int>
    {
        public override int VisitCouple([NotNull] programParser.CoupleContext context)
        {
            Console.WriteLine($"Visitando Pareja: {context.GetText()}");
            return base.VisitCouple(context);
        }

        public override int VisitFamily([NotNull] programParser.FamilyContext context)
        {
            Console.WriteLine($"Visitando Familia: {context.GetText()}");
            return base.VisitFamily(context);
        }

        public override int VisitPerson([NotNull] programParser.PersonContext context)
        {
            Console.WriteLine($"Visitando Individuo: {context.GetText()}");
            return base.VisitPerson(context);
        }

        public override int VisitProgram([NotNull] programParser.ProgramContext context)
        {
            Console.WriteLine($"Visitando Programa: {context.GetText()}");
            return base.VisitProgram(context);
        }

        public override int VisitSingle([NotNull] programParser.SingleContext context)
        {
            Console.WriteLine($"Visitando Soltero: {context.GetText()}");
            return base.VisitSingle(context);
        }

        public override int VisitSons([NotNull] programParser.SonsContext context)
        {
            Console.WriteLine($"Visitando Hijos: {context.GetText()}");
            return base.VisitSons(context);
        }
    }
}
