Imports System




Module Program

    Sub Main(args As String())
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
                    'chamar 
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
        'Valor futuro final
        Dim Periodo As Integer
        Dim TaxaAnual As Integer
        Dim DepositoAnual As Double
        Dim ValorInicial As Double

        Do

        Loop

        CalculatorVF.SetPeriod(Periodo)
        CalculatorVF.SetTaxYearly(TaxaAnual)
        CalculatorVF.SetYearlyDeposit(DepositoAnual)
        CalculatorVF.SetStartVaule(ValorInicial)



    End Sub

    Sub CalcFVM()
        'Valor mensal mensal

    End Sub

End Module

