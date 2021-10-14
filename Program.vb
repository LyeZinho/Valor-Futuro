Imports System




Module Program

    Sub Main(args As String())
        Console.ForegroundColor = ConsoleColor.DarkCyan
        InterfMain()

    End Sub




    Sub InterfMain()
        Do

            Dim _input As String
            Dim _interf As String = "
                ██    ██  █████  ██       ██████  ██████      ███████ ██    ██ ████████ ██    ██ ██████   ██████      
                ██    ██ ██   ██ ██      ██    ██ ██   ██     ██      ██    ██    ██    ██    ██ ██   ██ ██    ██     
                ██    ██ ███████ ██      ██    ██ ██████      █████   ██    ██    ██    ██    ██ ██████  ██    ██     
                 ██  ██  ██   ██ ██      ██    ██ ██   ██     ██      ██    ██    ██    ██    ██ ██   ██ ██    ██     
                  ████   ██   ██ ███████  ██████  ██   ██     ██       ██████     ██     ██████  ██   ██  ██████      
                                                                                                      

                            " + "[a] Calculo anual [m] Calculo mensal [s] Sair"


            Console.Clear()

            Console.WriteLine(_interf)
            Console.Write("-")
            _input = Console.ReadLine()


            Select Case _input
                Case "a"
                    CalcFVA()
                Case "m"
                    CalcFVM()
                Case "s"
                    Console.WriteLine("Finalizado")
                    Console.ReadKey()
                    Console.Clear()
                    Exit Do
                Case Else
                    Console.WriteLine("Digite um valor valido")
            End Select
        Loop

    End Sub




    Sub CalcFVA()
        'Valor futuro Anual
        Dim Periodo As Integer
        Dim TaxaAnual As Integer
        Dim DepositoAnual As Double
        Dim ValorInicial As Double
        Dim _input As String
        Dim result As Double
        Do
            'Periodo
            Console.Clear()
            Console.WriteLine("Digite o periodo de investimento")
            _input = Console.ReadLine()
            Try
                Periodo = Convert.ToInt32(_input)
                _input = "" 'Reset _input
            Catch ex As Exception
                Console.WriteLine("Digite um valor valido")
            End Try


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


            CalculatorVF.SetPeriod(Periodo)
            CalculatorVF.SetTaxYearly(TaxaAnual)
            CalculatorVF.SetYearlyDeposit(DepositoAnual)
            CalculatorVF.SetStartVaule(ValorInicial)

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

