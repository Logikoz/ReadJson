using Newtonsoft.Json;
using ReadJson.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ReadJson
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string json = await File.ReadAllTextAsync(AppDomain.CurrentDomain.BaseDirectory + @"\dados.json");

            List<Pessoa> pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(json);

            while (true)
            {
                Console.WriteLine("Informe um nome/nick: ");

                string @in = Console.ReadLine();

                Pessoa p = pessoas.First(a => a.Nome == @in || a.Nick == @in);
                List<Endereco> e = p.Endereco;

                Console.WriteLine($"Nome: {p.Nome}");
                Console.WriteLine($"Nick: {p.Nick}");
                Console.WriteLine($"Idade: {p.Idade}");
                Console.WriteLine("Endereço: ");
                Console.WriteLine($"\tRua/Av: {e[0].Logradouro}");
                Console.WriteLine($"\tBairro: {e[0].Bairro}");
                Console.WriteLine($"\tComplemeto: {e[0].Complemento}");
                Console.WriteLine($"\tNumero: {e[0].Numero}");
                Console.WriteLine();
            }

        }
    }
}
