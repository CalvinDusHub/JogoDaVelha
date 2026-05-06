using System;

class JogoDaVelha {
  static void Main() {
    String[] tabuleiro = new string[9];
    int info = 1;

    for (int i = 0; i < tabuleiro.Length; i++) {
      tabuleiro[i] = info.ToString();
      info++;
    }

    for (int i = 0; i < tabuleiro.Length; i++) {
      Console.Write($"[{tabuleiro[i]}]");
      if ((i + 1) % 3 == 0) {
        Console.WriteLine();
      }
    }
  }
}