using System;

class JogoDaVelha {
  static void Main() {
    //Tabuleiro
    string[] tabuleiro = new string[9];
    string xo = "X";
    int info = 1;

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

    Console.WriteLine();
    Console.WriteLine("Clique qualquer tecla para iniciar o jogo.");
    Console.ReadLine();

    while (ganhou == false) {

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

      Console.WriteLine();
      Console.WriteLine($"Vez do jogador \"{xo}\"");
      Console.WriteLine($"Selecione a posição: ");

      string posicao = Console.ReadLine();
      while (!juiz.Contains(posicao)) {
        Console.WriteLine("Selecione uma posição válida !");
        posicao = Console.ReadLine();
      }

      for (int i = 0; i < tabuleiro.Length; i++) {
        if (posicao == tabuleiro[i]) {
          tabuleiro[i] = xo;
          juiz.Remove(posicao);
        }
      }

      Console.Clear();
      Console.WriteLine("=======================");
      Console.WriteLine("      Fim de Jogo      ");
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

      //Condição de vitória
      //Horizontal
      if (tabuleiro[0] == tabuleiro[1] && tabuleiro[0] == tabuleiro[2]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      else if (tabuleiro[3] == tabuleiro[4] && tabuleiro[3] == tabuleiro[5]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      else if (tabuleiro[6] == tabuleiro[7] && tabuleiro[6] == tabuleiro[8]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      //Vertical
      else if (tabuleiro[0] == tabuleiro[3] && tabuleiro[0] == tabuleiro[6]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      else if (tabuleiro[1] == tabuleiro[4] && tabuleiro[1] == tabuleiro[7]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      else if (tabuleiro[2] == tabuleiro[5] && tabuleiro[2] == tabuleiro[8]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      //Diagonal
      else if (tabuleiro[0] == tabuleiro[4] && tabuleiro[4] == tabuleiro[8]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }
      else if (tabuleiro[2] == tabuleiro[4] && tabuleiro[2] == tabuleiro[6]) {
        Console.WriteLine($"Jogador \"{xo}\" venceu.");
        ganhou = true;
      }

      if (juiz.Count == 0) {
        Console.WriteLine("Velha.");
        ganhou = true;
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