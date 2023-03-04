using System;

class MainClass {
  public static void Main (string[] args) {
    string[] dataInicial = Console.ReadLine().Split(' ');
    int diaInicial = int.Parse(dataInicial[1]);

    string[] horarioInicial = Console.ReadLine().Split(':');
    int horaInicial = int.Parse(horarioInicial[0]);
    int minutoInicial = int.Parse(horarioInicial[1]);
    int segundoInicial = int.Parse(horarioInicial[2]);

    string[] dataFinal = Console.ReadLine().Split(' ');
    int diaFinal = int.Parse(dataFinal[1]);

    string[] horarioFinal = Console.ReadLine().Split(':');
    int horaFinal = int.Parse(horarioFinal[0]);
    int minutoFinal = int.Parse(horarioFinal[1]);
    int segundoFinal = int.Parse(horarioFinal[2]);

    // Convertendo tudo para segundos
    int segundosIniciais = segundoInicial + minutoInicial * 60 + horaInicial * 3600 + (diaInicial - 1) * 86400;
    int segundosFinais = segundoFinal + minutoFinal * 60 + horaFinal * 3600 + (diaFinal - 1) * 86400;

    int duracaoSegundos = segundosFinais - segundosIniciais;

    // Convertendo segundos para dias, horas, minutos e segundos
    int dias = duracaoSegundos / 86400;
    duracaoSegundos -= dias * 86400;

    int horas = duracaoSegundos / 3600;
    duracaoSegundos -= horas * 3600;

    int minutos = duracaoSegundos / 60;
    duracaoSegundos -= minutos * 60;

    int segundos = duracaoSegundos;

    Console.WriteLine($"{dias} dia(s)\n{horas} hora(s)\n{minutos} minuto(s)\n{segundos} segundo(s)");
  }
}
