using System;

class JogoDaVelha {
  static void Main() {
    //Estrutura tabuleiro
    string[] tabuleiro = new string[9];
    int info = 1;
    string xo = "X";

    //Estrutura do jogo
    int rounds = 0;
    List<string> juiz = new List<string>();

    Console.WriteLine("===================");
    Console.WriteLine("   Jogo da Velha   ");
    Console.WriteLine("===================");

    for (int i = 0; i < tabuleiro.Length; i++) {
      tabuleiro[i] = info.ToString();
      juiz.Add(info.ToString());
      info++;
    }

    for (int i = 0; i < tabuleiro.Length; i++) {
      Console.Write($"[{tabuleiro[i]}]");
      if ((i + 1) % 3 == 0) {
        Console.WriteLine();
      }
    }

    //Interação com o player
    Console.WriteLine($"Player {xo}: Selecione a posição no tabuleiro");
    string jogada = Console.ReadLine();

    //Validação
    while (!juiz.Contains(jogada)) {
      Console.WriteLine("Selecione posição válida");
      jogada = Console.ReadLine();
    }

    Console.Clear();

    while (rounds < 9) {
      Console.WriteLine("===================");
      Console.WriteLine("       Fight       ");
      Console.WriteLine("===================");
      for (int i = 0; i < tabuleiro.Length; i++) {
        if (tabuleiro[i] == jogada) {
          tabuleiro[i] = xo;
          juiz.Remove(jogada);
        }
      }

      for (int i = 0; i < tabuleiro.Length; i++) {
        Console.Write($"[{tabuleiro[i]}]");
        if ((i + 1) % 3 == 0) {
          Console.WriteLine();
        }
      }

      //Condição de Vitoria

      //Horizontal
      if (tabuleiro[0] == tabuleiro[1] && tabuleiro[0] == tabuleiro[2]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      else if (tabuleiro[3] == tabuleiro[4] && tabuleiro[3] == tabuleiro[5]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      else if (tabuleiro[6] == tabuleiro[7] && tabuleiro[6] == tabuleiro[8]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      //Vertical
      else if (tabuleiro[0] == tabuleiro[3] && tabuleiro[0] == tabuleiro[6]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      else if (tabuleiro[1] == tabuleiro[4] && tabuleiro[1] == tabuleiro[7]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      else if (tabuleiro[2] == tabuleiro[5] && tabuleiro[2] == tabuleiro[8]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      //Diagonal
      else if (tabuleiro[0] == tabuleiro[4] && tabuleiro[0] == tabuleiro[8]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }
      else if (tabuleiro[2] == tabuleiro[4] && tabuleiro[2] == tabuleiro[6]) {
        Console.WriteLine($"Player {xo} ganhou");
        return;
      }

      //Empate
      if (juiz.Count == 0) {
        Console.WriteLine("Velha");
        return;
      }

      if (xo == "X") {
        xo = "O";
      }
      else {
        xo = "X";
      }

      rounds++;

      Console.WriteLine($"Player {xo}: Selecione a posição no tabuleiro");
      jogada = Console.ReadLine();

      while (!juiz.Contains(jogada)) {
        Console.WriteLine("Selecione posição válida");
        jogada = Console.ReadLine();
      }

      Console.Clear();
    }
  }
}