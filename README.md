# Calculadora Simples em C#

Este é um projeto de exemplo de uma calculadora de console simples desenvolvida em C#. O objetivo é demonstrar os conceitos básicos da linguagem C# e Programação Orientada a Objetos (POO) de forma funcional e fácil de entender.

## Funcionalidades

Esta calculadora suporta as seguintes operações aritméticas básicas:

*   Adição (`+`)
*   Subtração (`-`)
*   Multiplicação (`*`)
*   Divisão (`/`)

## Como Executar

Para executar esta calculadora, siga os passos abaixo:

1.  **Navegue até o diretório do projeto:**

    Abra seu terminal ou prompt de comando e vá para a pasta `ScientificCalculator`:

    ```bash
    cd "c:\Users\Samsung\Desktop\C# init\ScientificCalculator"
    ```

2.  **Execute a aplicação:**

    No terminal, digite o seguinte comando e pressione Enter:

    ```bash
    dotnet run
    ```
## Como Executar 2.0

     ```bash
    Vá na pasta bin/Debug/net9.0 e execute o ScientificCalculator.exe
    ```


## Exemplo de Uso

Ao iniciar a aplicação, você verá um prompt para digitar expressões. Aqui estão alguns exemplos:

```
Bem-vindo à Calculadora Simples em C#!
Operações suportadas: +, -, *, /
Digite 'sair' para fechar a calculadora.
Digite a expressão: 10 + 5
Resultado: 15
Digite a expressão: 2 * (3 + 4)
Resultado: 14
Digite a expressão: 20 / 4
Resultado: 5
Digite a expressão: sair
Obrigado por usar a calculadora!
```

## Estrutura do Projeto

O projeto é composto principalmente por:

*   `Program.cs`: Contém o ponto de entrada da aplicação (`Main` method) e a lógica de interação com o usuário.
*   `CalculadoraSimples.cs`: (Implicitamente dentro de Program.cs para este exemplo) Uma classe que encapsula a lógica de cálculo das expressões.

## Requisitos

*   .NET SDK (versão 6.0 ou superior recomendada)
