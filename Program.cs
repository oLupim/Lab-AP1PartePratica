// AP1 Parte prática - CALCULADORA DE IMC
// Use if, if-else para determinar as categorias
// Use um loop do-while
// 1. O programa deverá perguntar o nome da pessoa.
// 2. Em seguida, perguntar a idade, altura e peso.
// 3. Calcule o IMC e determine a categoria de IMC (Abaixo do peso, Normal, Sobrepeso, Obeso).
// 4. Determine a faixa etária da pessoa (Criança, Adolescente, Adulto, Idoso).
// 5. Gere um relatório mostrando o nome, idade, IMC e faixa etária.
// 6. Pergunte ao usuário se ele gostaria de gerar um novo relatório para outra pessoa. Se sim, retorne ao passo 1; se não, encerre o programa.

bool continuar = false;

do{
	
	//Perguntar os dados para o usuário
	Console.WriteLine("Digite seu nome:");
	string nome = Console.ReadLine();
	Console.WriteLine("Digite sua idade:");
	int idade = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Digite sua altura:");
	double altura = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Digite seu peso:");
	double peso = Convert.ToDouble(Console.ReadLine());
	
	
	//Faixa etária
	var faixaEtaria = "";
	if(idade <= 10 && idade >= 1)
	{ 
		faixaEtaria+= "uma criança"; 
	}
	else
	{
		if(idade > 10 && idade <=20)
		{
			faixaEtaria+= "um adolescente";
		}
		else
		{
			if(idade > 20 && idade <=60)
			{
				faixaEtaria+= "um(a) adulto(a)";
			}
			else
			{
				faixaEtaria+= "um(a) idoso(a)";
			}
		}
	}


	//Calculadora de IMC
	double IMC = Math.Round(peso/(altura*altura), 2);


	//Categoria do IMC (Abaixo do peso, normal, sobrepeso e obeso)
	var categoriaIMC = "";
	if (IMC < 18.5)
    {
        categoriaIMC = "abaixo do peso";
    }
    else if (IMC < 25)
    {
        categoriaIMC = "normal";
    }
    else if (IMC < 30)
    {
        categoriaIMC = "com sobrepeso";
    }
    else
    {
        categoriaIMC = "obeso(a)";
    }


	//relatório
	Console.WriteLine($"O resultado é de {IMC} de IMC, isso indica que {nome} é {faixaEtaria} com {idade} anos e está {categoriaIMC}.");


	//TryAgain
	Console.WriteLine("Deseja tentar novamente? (S/N)");
	string tryAgain = Console.ReadLine();
	if(tryAgain.ToUpper() == "S")
	{
		continuar = true;	
	}
	else
	{
		continuar = false;
	}
	}while(continuar);
	
