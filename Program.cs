using CallIdCpfValidator;

Console.WriteLine("=== CallID CPF Validator ===");
Console.WriteLine("Sistema iniciado!");

Console.WriteLine("Digite o CallID");

// Aqui o usuário insere o CallID desejado,
string callId = Console.ReadLine() ?? "";

// Cria um registro associando o CallID informado ao CPF temporário.
CallRecord registro = new CallRecord
{
    CallId = callId,
    Cpf = "12345678909"
};

// Por fim, exibe os dados da chamada encontrados no registro.
Console.WriteLine("Dados encontrados:");
Console.WriteLine($"CallID: {registro.CallId}");
Console.WriteLine($"CPF: {registro.Cpf}");