using ContextA.Application.Services;
using System;

namespace ContextA.Presentation
{
    class Program
    {
        private static readonly ProgramAppService _programAppService = new ProgramAppService();

        static void Main(string[] args)
        {
            Console.WriteLine(_programAppService.HelloWorld());
            Console.WriteLine(_programAppService.HelloContextB());

            Console.ReadLine();
        }
    }
}
