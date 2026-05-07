using System;

class JogoDaVelha {
  static void Main() {

    Console.WriteLine("=======================");
    Console.WriteLine("     Jogo da Velha     ");
    Console.WriteLine("=======================");
    criarTabuleiro();



  }

  static void criarTabuleiro() {
    string[] tabuleiro = new string[9];
    List<string> juiz = new List<string>();
    int info = 1;

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
  }
}