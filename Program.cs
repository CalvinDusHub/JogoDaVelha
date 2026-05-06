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
    string jogada = Console.ReadLine();

    //Validação
    while (!juiz.Contains(jogada)) {
      Console.WriteLine("Selecione posição válida");
      jogada = Console.ReadLine();
    }


    Console.Clear();

    while (rounds < 9) {
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


      if (xo == "X") {
        xo = "O";
      }
      else {
        xo = "X";
      }

      rounds++;
      jogada = Console.ReadLine();

      while (!juiz.Contains(jogada)) {
        Console.WriteLine("Selecione posição válida");
        jogada = Console.ReadLine();
      }

      Console.Clear();
    }
  }
}