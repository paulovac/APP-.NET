using System;

using DIO.Series;

static SerieRepositorio repositorio = new SerieRepositorio();

string opcaoUsuario = ObterOpcaoUsuario();
while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            ListarSeries();
            break;
        case "2":
            InserieSerie();
            break;
        case "3":
            AtualizarSerie();
            break;
        case "4":
            ExcluirSerie();
            break;
        case "5":
            VisualizarSerie();
            break;
        case "C":
            Console.Clear();
            break;
        
        default:
            throw new ArgumentOutOfRangeException();
    }
    opcaoUsuario = ObterOpcaoUsuario();
}

System.Console.WriteLine("Obrigado por utilizar nossos serviços.");
System.Console.WriteLine();

private static void ListarSeries()
{
    System.Console.WriteLine("Listar séries");

    var lista repositorio.Lista();

    if (lista.Count == 0)
    {
        System.Console.WriteLine("Nenhuma série cadastrada.");
        return;
    }

    foreach (var serie in lista)
    {
        System.Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
    }
}

private static string ObterOpcaoUsuario()
{
    System.Console.WriteLine();
    System.Console.WriteLine("DIO Séries a seu dispor!!!");
    System.Console.WriteLine("Informe a opção desejada:");

    System.Console.WriteLine("1- Listar séries");
    System.Console.WriteLine("2- Inserir nova série");
    System.Console.WriteLine("3- Atualizar série");
    System.Console.WriteLine("4- Excluir série");
    System.Console.WriteLine("5- Visualizar série");
    System.Console.WriteLine("C- Limpar tela");
    System.Console.WriteLine("X- Sair);
    System.Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    System.Console.WriteLine();
    return opcaoUsuario;
}
