using velocidadeDoRobo.Models;

Console.WriteLine("Digite dois valores, o primeiro referente a velociade mínima e o segundo a velocidade máxima.");

string[] valores = Console.ReadLine().Split();
int vmin = int.Parse(valores[0]);
int vmax = int.Parse(valores[1]);

Console.WriteLine("Escreva os comandos de aceleração e desaceleração. 'A' para acelerar e 'D' para desacelerar.");
string comandos = Console.ReadLine();
      
Robo meuRobo = new Robo(vmin, vmax);

    foreach (char comando in comandos)
    {
        char comandosLower = char.ToLower(comando); 
        if (comando == 'a')
        {
            meuRobo.Acelerar();
        }
        else if (comando == 'd')
        {
            meuRobo.Desacelerar();
        }
    }
    Console.WriteLine($"A velociade atual do seu robô é: {meuRobo.VelocidadeAtual}");

