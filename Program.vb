Imports System




Module Program

    Sub Main(args As String())
        'Name space Console Propriedade ForegroundColor recebe = Enum.Valor 3 
        'Valor 3 corresponde a cor CianoEscuro
        Console.ForegroundColor = ConsoleColor.DarkCyan

        'Chamada função interface principal
        InterfMain()

    End Sub




    Sub InterfMain()
        Do
            '_input Variavel de controle da interface ela vai 
            'receber os comandos de navegação na interface
            Dim _input As String

            'Variavel _interf guarda a string contendo a logo 
            'do programa basicamente o iniciar do programa
            Dim _interf As String = "
                ██    ██  █████  ██       ██████  ██████      ███████ ██    ██ ████████ ██    ██ ██████   ██████      
                ██    ██ ██   ██ ██      ██    ██ ██   ██     ██      ██    ██    ██    ██    ██ ██   ██ ██    ██     
                ██    ██ ███████ ██      ██    ██ ██████      █████   ██    ██    ██    ██    ██ ██████  ██    ██     
                 ██  ██  ██   ██ ██      ██    ██ ██   ██     ██      ██    ██    ██    ██    ██ ██   ██ ██    ██     
                  ████   ██   ██ ███████  ██████  ██   ██     ██       ██████     ██     ██████  ██   ██  ██████      
                                                                                                      

                            " + "[a] Calculo anual [m] Calculo mensal [s] Sair
                                
                               



                            "

            'Limpa a linhade comandos
            Console.Clear()

            'Escreve a interface na linha de comandos
            Console.WriteLine(_interf)

            ' - traco para mostrar onde o usuario está digitando
            Console.Write("-")

            ' "scanf()" do codigo basicamente vai ler oque o 
            'usuario vai inserir e guardar na variavel _input
            _input = Console.ReadLine()

            'Case para escolha de interface
            Select Case _input
                Case "a"
                    'Chamada procedimeno CalcFVA() Valor Futuro Anual
                    CalcFVA()
                Case "m"
                    'Chamada procedimeno CalcFVM() Valor Futuro Mensal
                    CalcFVM()
                Case "s"

                    'Aleta finalizado
                    Console.WriteLine("Finalizado")

                    'Pressione qualquer tecla
                    Console.ReadKey()

                    'Limpa o CMD
                    Console.Clear()

                    'Sai do DO LOOP
                    Exit Do
                Case Else

                    'Caso não insira um valor valido alerta
                    Console.WriteLine("Digite um valor valido")
            End Select
        Loop

    End Sub




    Sub CalcFVA()
        'Valor futuro Anual

        'Variaveis e variaveis não tenho que explicar
        Dim Periodo As Integer
        Dim TaxaAnual As Integer
        Dim DepositoAnual As Double
        Dim ValorInicial As Double
        Dim _input As String 'Essa aki e uma variavel de entrada [ _input ]
        Dim result As Double 'Essa aki e o resultado


        Do

            'Nota ❗ Tudo abaixo e apenas um control+c control+v ums dos outros
            'pode se perceber que cada operação abaixo são levemente diferentes
            'porem são basicamene a mesma coisa por isso vou comentar apenas 1
            'ja que o resto e igual so muda a qual das variaveis anteriores e 
            'atribuido os valores


            'Periodo
            Console.Clear() 'Limpa a linha de comando
            Console.WriteLine("Digite o periodo de investimento") 'pequena interface
            _input = Console.ReadLine() 'Lé o que o usuario inseriu

            'Abaixo e outra coisa importante 
            '(Try...Catch) neste caso está sendo
            'utilizado como um debugg de alerta
            'Try-Tenta Catch-Apanha
            'Tenta executar o bloco de codigos
            'caso tenha algum erro exibe asseguir

            Try
                'Var periodo reçebe inpu .Converta.ParaInteiro32bits(isso de 32 bits 
                'não importa so muda o espaço da variavel para guardar casas decimais
                Periodo = Convert.ToInt32(_input)

                'Transforma _input em uma string vazia para receber outros valores
                _input = "" 'Reset _input

                'Tenta pegar algum erro
            Catch ex As Exception

                'Caso pegue o unico erro possivel aqui e se caso o user insira algo
                'quse o Convert não consiga converter como por exemplo uma letra
                'como não e possivel converter de Letras(nota e possivel string porem
                'a string tem que conter numeros! que e oque aconteçe no codigo acima)
                '-> Numeros
                Console.WriteLine("Digite um valor valido")
            End Try

            'Copy paste do bloco de codigo acima
            'Taxa anual
            Console.WriteLine("Digite a taxa anual")
            _input = Console.ReadLine()
            Try
                TaxaAnual = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


            'Deposito anual
            Console.WriteLine("Digite o valor inicial")
            _input = Console.ReadLine()
            Try
                ValorInicial = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


            'Deposito anual
            Console.WriteLine("Digite o deposito anual")
            _input = Console.ReadLine()
            Try
                DepositoAnual = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try
            'Final dos copy pastes

            'Para não nessesitar passar varios parametros
            'e por praticidade os procedimentos abaixo entregam
            'os valores das variaveis diretamente a função 
            CalculatorVF.SetPeriod(Periodo)
            CalculatorVF.SetTaxYearly(TaxaAnual)
            CalculatorVF.SetYearlyDeposit(DepositoAnual)
            CalculatorVF.SetStartVaule(ValorInicial)

            'Como os valores ja foram entregues a função ja está
            'com os dados prontos para serem processados no momento
            'que chama-se a função os dados são entregues a result
            result = CalculatorVF.YearlyFV()

            Console.WriteLine("Valor futuro:" + result.ToString + "$")

            Console.WriteLine("Deseja continuar? sim/nao")
            Dim _exit As String = Console.ReadLine()
            If _exit = "sim" Then
                Exit Do
            End If
        Loop

    End Sub




    Sub CalcFVM()
        'Valor mensal mensal
        Dim Periodo As Integer
        Dim TaxaMensal As Integer
        Dim DepositoMensal As Double
        Dim ValorInicial As Double
        Dim _input As String
        Dim result As Double
        Do
            'Periodo
            Console.WriteLine("Digite o periodo de investimento")
            _input = Console.ReadLine()
            Try
                Periodo = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


            'Taxa anual
            Console.WriteLine("Digite a taxa mensal")
            _input = Console.ReadLine()
            Try
                TaxaMensal = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


            'Deposito anual
            Console.WriteLine("Digite o valor inicial")
            _input = Console.ReadLine()
            Try
                ValorInicial = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


            'Deposito anual
            Console.WriteLine("Digite o deposito mensal")
            _input = Console.ReadLine()
            Try
                DepositoMensal = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


            CalculatorVF.SetPeriod(Periodo)
            CalculatorVF.SetTaxMonth(TaxaMensal)
            CalculatorVF.SetMonthDeposit(DepositoMensal)
            CalculatorVF.SetStartVaule(ValorInicial)

            result = CalculatorVF.MonthlyFV()

            Console.WriteLine("Valor futuro:" + result.ToString + "$")

            Console.WriteLine("Deseja continuar? sim/nao")
            Dim _exit As String = Console.ReadLine()
            If _exit = "sim" Then
                Exit Do
            End If
        Loop
    End Sub

End Module

