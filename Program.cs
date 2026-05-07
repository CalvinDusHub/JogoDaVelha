using System;

class JogoDaVelha {
  static void Main() {
    //Tabuleiro
    string[] tabuleiro = new string[9];
    string xo = "X";
    int info = 1;

    //Teste
    int j = 0;

    //Regras do jogo
    List<string> juiz = new List<string>();
    bool ganhou = false;

    Console.WriteLine("=======================");
    Console.WriteLine("     Jogo da Velha     ");
    Console.WriteLine("=======================");

    for (int i = 0; i < tabuleiro.Length; i++) {
      tabuleiro[i] = info.ToString();
      juiz.Add(info.ToString());
      info++;
    }

    for (int i = 0; i < tabuleiro.Length; i++) {
      Console.Write($"   {tabuleiro[i]}   ");
      if ((i + 1) % 3 != 0) {
        Console.Write("|");
      }
      if ((i + 1) % 3 == 0) {
        Console.WriteLine();
        if (i < 6) {
          Console.WriteLine("-------+-------+-------");
        }
      }
    }

    Console.WriteLine("Clique qualquer tecla para iniciar o jogo.");
    Console.ReadLine();

    while (ganhou = false) {

      Console.Clear();

      Console.WriteLine("=======================");
      Console.WriteLine("         Fight         ");
      Console.WriteLine("=======================");
      for (int i = 0; i < tabuleiro.Length; i++) {
        Console.Write($"   {tabuleiro[i]}   ");
        if ((i + 1) % 3 != 0) {
          Console.Write("|");
        }
        if ((i + 1) % 3 == 0) {
          Console.WriteLine();
          if (i < 6) {
            Console.WriteLine("-------+-------+-------");
          }
        }
      }

      Console.WriteLine($"Vez do jogador \"{xo}\"");
      Console.WriteLine($"Selecione a posição: ");

      string posicao = Console.ReadLine();
      if (!juiz.Contains(posicao)) {
        Console.WriteLine("Selecione uma posição válida !");
        posicao = Console.ReadLine();
      }

      for (int i = 0; i < tabuleiro.Length; i++) {
        if (posicao == tabuleiro[i]) {
          tabuleiro[i] = xo;
          juiz.Remove(posicao);
        }
      }

      if (xo == "X") {
        xo = "O";
      }
      else {
        xo = "X";
      }
    }
  }
}