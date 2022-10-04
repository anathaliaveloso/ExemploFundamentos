using ExemploFundamentos.Common.Models;

         /*** AULA 18***/

//TRABALHANDO COM LISTAS

//Uma lista é um array "melhorado", ela tbm é capaz de representar coleções de objetos de um mesmo tipo, mas sem a complexidade intríceca do array. Pode-se dizer que a lista é uma extensão do array

//não precisa determinar uma capacidade máxima para uma lista.

//capacity: uma lista trabalha internamente com um array, e o array tem capacidade, o capacity é a capacidade interna do array que ela ta trabalhando e não da lista em si

//count : quantidade de elemntos dentro de uma lista

// A principal diferença entre uma lista e um array é que com o array você precisa se preocupar com a capacidade, e com a lista não, pois ela faz automaticamente isso pra você.



List<string> listaString = new List<string>();
         
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha LISTA: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add ("SC");

Console.WriteLine($"Itens na minha LISTA: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha LISTA: {listaString.Count} - Capacidade: {listaString.Capacity}");





/*
// USANDO FOR

Console.WriteLine($"Percorrendo a lista com FOR");
for(int contador = 0; contador < listaString.Count; contador ++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

//USANDO FOREACH

Console.WriteLine($"Percorrendo a lista com FOREACH");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição  nº {contadorForeach} - {item}");
    contadorForeach++;
}
*/         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
          /*** AULA 17***/           



 //COPIANDO UM ARRAY PARA OUTRO          
/*
 int [] arrayInteiros = new int [4];

arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;
arrayInteiros [3] = 1;

int[] arrayInteirosDobrado = new int [arrayInteiros.Length * 2]; //declarando nova array

Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Array.Copy (onde estao os arquivos que eu quero copiar, pra onde copiar, quantidade que quer copiar)



for(int contador = 0; contador < arrayInteiros.Length; contador ++) 

{
Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
}
         

//REDIMENSIONANDO UM ARRAY

/*

int [] arrayInteiros = new int [4];

arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;
arrayInteiros [3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


for(int contador = 0; contador < arrayInteiros.Length; contador ++) 

{
Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
}

*/































                  /*** AULA 16***/

/*

//PERCORRENDO UM ARRAY COM FOREACH 

int [] arrayInteiros = new int [4];

arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;
arrayInteiros [3] = 1;

foreach(int valor in arrayInteiros)

{
 Console.WriteLine (valor);
}

// A diferença entre o FOR e o FOREACH é que no FOR você precisa declarar um contador e até onde ele vai, eenquanto que o FOREACH é mais simples e não precisa de contador pq ele vai jogando cada valor na minha variável a cada iteração, além de não precisar gerenciar a capacidade dele.

//CASO QUEIRA ADICIONAR CONTADOR NO FOREACH

int [] arrayInteiros = new int [4];

arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;
arrayInteiros [3] = 1;

int contadoForeach = 0;
foreach(int valor in arrayInteiros)

{
    Console.WriteLine ($"Posição nº {contador} - {valor}");
    contadorForeach ++;
}

//EM RESUMO o FOREACH é mais simplicado, porém, caso você queira ou precise do valor do contador o FOR pode ser mais recomendado.



















                              /*** AULA 15***/ 
                            
//IMPLEMENTANDO UM ARRAY DE INTEIROS
/*
int [] arrayInteiros = new int [3];

arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;

// Percorrendo o Array com o FOR

for(int contador = 0; contador < arrayInteiros.Length; contador ++) //Length é a capacidade do meu array
{
Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
}

*/














                             
                             
                             
                             
                             
                             
                             
                             /*** AULA 14 ***/

/*
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Nathália";
pessoa1.Idade = 28;
pessoa1.Apresentar();
*/












                              
                                /*** AULA 13 ***/    

//REFATORANDO O MENU DA AULA 12

/*

string opcao;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine ("Opção Inválida!");
            break;
    }
}

                                
*/                
























                                /*** AULA 12 ***/

//CONSTRUINDO UM MENU INTERATIVO
/*             
string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine ("Opção Inválida!");
            break;
    }
}
*/               
                            























                            
                                   
                             /*** AULA 11 ***/

//DO WHILE: é mais uma extensão do while, porém sua verificação é executada no final do código, e enquanto que no bloco DO ele vai executar seu codigo independente da condição.

//o DO vai executar o código independente da condição, pois a condição só será executado no final do código.

// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)"); 
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0); //!= diferente, ou seja while numero for != 0 ele continuará executando

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");





























                                /*** AULA 10 ***/


//INTRODUÇÃO AO WHILE

//para quebrar o laço pode-se usar o break.

/*
int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{contador}° Execução: {numero} x {contador} ={numero * contador}");
    contador++;

    if (contador == 6)
    {
        break;
    }
}
*/



//INTRODUÇÃO AO FOR

// for tem 3 sintaxes basicas, a declaração da variável, a coondição e o incremento

/*
int numero = 5;

for(int contador = 0; contador <= 10 ; contador++ )
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/

                         
//Calculadora calc = new Calculadora();       



























                                    /*** AULA 09 ***/

//INCREMENTO E DECREMENTO

/*
int numeroIncremento = 10;
Console.WriteLine("Incrementando o 10");
numeroIncremento++;

Console.WriteLine(numeroIncremento); 

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
numeroDecremento--;


Console.WriteLine(numeroDecremento);
*/





































                                    /*** AULA 08 ***/  

//O angulo deve ser medido em radianos, deve ser feita a conversão utizando: double radiano = angulo * Math.PI / 180; , para arrendondar os números utilizamos Math.Round(sen, 4), o 4 representa a quant. de casas decimais.

//FUNÇÕES TRIGONOMÉTRICAS

//calc.Seno(30);
//calc.Coseno(30);
//calc.Tangente (30);

//RAIZ QUADRADA

//calc.RaizQuadrada(9);











































                                       /*** AULA 07 ***/     
//INTRODUÇÃO A OPERADORES ARITMÉTICOS 


//calc.Somar(10, 30); 
//calc.Subtrair(10, 50);
//calc.Multiplicar(15, 45);
//calc.Dividir(2, 2);                                      
//calc.Potencia(3, 3);                                       
                                        
                                        


































                                        /*** AULA 06 ***/

//OPERADORES LÓGICOS - OR (||), AND (&&) E NOT (!)

//EXEMPLO ! - Quero pedalar se NÃO estiver chovendo e nem estiver tarde.

/*
 bool choveu = true;
 bool estaTarde = true;

 if (!choveu && !estaTarde)
 {
    Console.WriteLine("Vou pedalar!");
 }
else
{
    Console.WriteLine("Viixi, vou pedalar um outro dia")
}

/* EXEMPLO &&

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 6.5)
{
    Console.WriteLine ("Aprovado");
}
else
{
    Console.WriteLine ("Reprovado");
}
*/

/* EXEMPLO ||

bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");
}
else
{
    Console.WriteLine("Desculpe, você não pode entrar");
}
*/                                       
                                        

































                                        
                                         /*** AULA 05 ***/

//OPERADORES CONDICIONAIS - if, else, switch, case

//Possibilita mudar o fluxo de exec. de eu código, indicando um caminho que ele deve percorrer.

/*
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda?  {possivelVenda}");

if(quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}

//IF ANINHADO: quado há mais de uma opção -> else if



/*
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda?  {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda Inválida");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
}
*/

// SWITCH CASE
/*
Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    defaut:
        Console.WriteLine("Não é uma vogal");
        break;

}
*/































                                           
                                        /*** AULA 04 ***/ 

//CONVERTENDO TIPOS DE VARIÁVEIS

//O mais utilizado são CONVERT E PARSE, a principal diferença entre eles está no tratamento 
//do valor nulo, enquanto Convert devolve null como 0, Parse apresenta erro e encerra o programa

//Transformando String em inteiro
//int a = Convert.ToInt32 ("5");
//Console.WriteLine(a);

//Uma forma mais simples é usando o Parse (Não tem Parse para String)

//int a = int.Parse("5");
//Console.WriteLine(a);                                          
                                           
//Conversão para string

// int inteiro = 5;
// string a = inteiro.ToString();
//Console.WriteLine(a);
                                           
// CAST IMPLÍCITO: É basicamente uma conversão automática de diferentes tipos, ou seja, não é necessário realizar a conversão pois ela ocorre de maneira implícita. EX: De int para long.

//ORDEM DOS OPERADORES: Obedece as mesmas regras da Matemática: (),**,/ e *, + e -.

//CONVERTER DE MANEIRA SEGURA - TRY PARSE

//string a = "15-";
//int b = 0;
//int.TryParse(a, out b);

//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso");
                              
//O TryParse tenta converter o a, se não conseguir o valor de saída será b, o TryParse evita que não o programa seja encerrado e continua executando; outra maneira de usar o Try Parse é:

//string a = "15-";
//int.TryParse(a, out int b);

//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso");

//Observe que aqui int b= 0; está oculto.









































                                            /*** AULA 03 ***/

//REPRESENTAR DATAS NO C#

//DateTime dataAtual = DateTime.Now;

// Esse comando mostra a data atual do PC e o DateTime.Now; as horas.
//Caso queira adicionar 3 dias a data atual por ex., pode-se fazer:

//DateTime dataAtual = DateTime.Now.addDays(3);

//Caso queira APENAS a data:

//Console.WriteLine (dataAtual.toString("dd/MM/yyyy"));

//Para deixar a data e a hora sem o milisegundo:

//Console.WriteLine (dataAtual.ToString("dd/MM/yyyy HH:mm"));
  
  

                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                            
                                             /*** AULA 02 ***/

//string apresentacao = "Olá, seja bem vindo";
//int quantidade = 1;
//double altura = 1.80;
//decimal preco = 1.80M;
//bool condicao = true;

//Console.WriteLine(apresentacao);
//Console.WriteLine("Valor da variável altura: " + altura);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável preço: " + preco);
//Console.WriteLine("Valor da variável condição: " + condicao); 

// Caso queira adicionar mais casas, uma alternativa é:
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Porém o melhor é usar o decimal, que também é o mais recomendado para valores monetários
//Escopo é um pedaço de bloco que você vai realizar seus códigos, reprsentado por {}



































                                              /*** AULA 01 ***/

//É um caminho para sua classe, caso aconteça uma situação em que o programana não reconheça a classe verificar o using para saber se ele está apontando para o namespace que a sua classe tem.  

//Aula01 pessoa1 = new Aula01();

//pessoa1.Nome = "Nathália";
//pessoa1.Idade = 28;
//pessoa1.Apresentar();

//pessoa1 é uma variável, que nada mais é que um endereço na memória

// Apresentar é um método, todo método é acompanhado por ();

//Para pular linha usa-se \n 