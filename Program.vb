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
                'chamar CalcFVA()
                Case "m"
                    'chamar CalcFVM()
                Case ""
                Case Else
                    Console.WriteLine("Digite um valor valido")
            End Select
        Loop

    End Sub


End Module

