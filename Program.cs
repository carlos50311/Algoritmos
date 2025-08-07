using System.Collections;
using CursoCsharp;

namespace CursoCSharp
{
    class Program
    {
        static void Main()
        {

            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundametos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritimeticos - Fundametos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Unario - Fundamentos", OperadoresUnarios.Executar},

                //Estruturas de controle 
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Esturtura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Esturtura If/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Esturtura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Esturtura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Esturtura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Esturtura For Each- Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                //Membros 
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estatico - Classes e Métodos", MetodosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Readonly - Classes e Métodos", Readonly.Executar},
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct Vs Class - Classes e Métodos", StructVsClass.Executar},
                {"Valor Vs Refencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parametros Por Referencia - Classes e Métodos", ParametrosPorReferencia.Executar},

                // Coleções 
                { "Array - Coleções", ExemploArray.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "ArrayList - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdades.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", Dictionary.Executar},

                //OO
                {"Herança - Orientação a Objetos", Heranca.Executar},
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}