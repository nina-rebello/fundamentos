// --------- CONDICIONAL LÓGICA AND && ----------

bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else
{
    Console.WriteLine("Não vou pedalar!");
}




// --------- CONDICIONAL LÓGICA AND && ----------

// bool possuiPresencaMinima = true;
// double media = 4.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }



// --------- CONDICIONAL LÓGICA OR || ----------

// bool maiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }


// ------------- SWITCH CASE -----------


// Console.WriteLine("Digite uma leta");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default: // caso nao seja nenhum dos casos, entra no default
//         Console.WriteLine("Não é uma vogal");
//         break;
// }



// -------- OPERADORES CONDICIONAIS --------

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda) // if alinhado
// {
//     Console.WriteLine("Venda realizada.");
// } 
// else
// {
//     Console.WriteLine("Desculpa. Não temos a quantidade desejada em estoque.");
// }



// -------- CONVERTENDO DE MANEIRA SEGURA --------

//string a = "15-";
// int b = 6;
// int.TryParse(a, out b);

//Console.WriteLine(b);
// o TryParse() espera que dê erro, por isso, ele fica preparado para isso



// --------- ORDEM DOS OPERADORES -------------

// double a = 4 / (2 + 2); // a utilizacao de parenteses da a prioridade para oque sera resolvido
// Console.WriteLine(a);


// ---------- CONVERSAO IMPLICITA -----------

// int a = 5;
// double b = a;
//Console.WriteLine(b);



// ----------- CASTING (INT --> STRING) -------------

//int inteiro = 5;
//string a = inteiro.ToString(); 
// para converter para string nao é necessario o uso do "Convert"
// todo tipo pode ser convertido para string
//Console.WriteLine(a);


// ----------- CASTING (STRING --> INT) -----------------
// Cast - Casting (converter string para int)
// int a = Convert.ToInt32(null); // possivel conveter 'NULL'para 0
// int a = int.Parse("8"); // nao aceita 'NULL'

// Console.WriteLine(a);

// --------- ATRIBUINDO NOVOS VALORES PARA VARIAVEIS --------
// int a = 1;
// int b = 4;

// int c = a + b;

// c = c + 5; // 5 + 5
// c += 5; // 5 + 5
// Console.WriteLine(c); 

// c -= 4;
//Console.WriteLine(c); 