string FraseParaSair = "tchau";

Console.WriteLine("--- Groot Chatbot ---\n");

string pergunta;

do
{
    Console.Write("Pergunta: ");
    pergunta = Console.ReadLine()!;

    string resposta = ObtemRespostaGroot(pergunta);

    MostraResposta(ObtemRespostaGroot(pergunta));

}
while (pergunta != FraseParaSair);

void MostraResposta(string resposta)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Resposta: {resposta}");
    Console.ResetColor();
}

string ObtemRespostaGroot(string pergunta)
{
    return pergunta == FraseParaSair ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}