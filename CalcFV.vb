Public Module CalculatorVF
    ''' <summary>
    ''' Criação biblioteca para calculo valor futuro
    ''' explicaões de uso
    ''' </summary>


    'SetPeriod(_iput As integer)        [Input]
    'SetTaxMonth(_input As Integer)     [Input]
    'SetTaxYearly(_input As Integer)    [Input]
    'SetStartVaule(_input As Double)    [Input]
    'SetYearlyDeposit(_input As Double) [Input] 
    'SetMonthDeposit(_input As Double)  [Input]
    'YearlyFV() As Double               [Function]
    'MonthlyFV() As Double              [Function]

    'Variaveis de operação
    Dim Periodo As Integer
    Dim TaxaAnual, TaxaMensal As Integer
    Dim DepositoMensal, DepositoAnual As Double
    Dim ValorInicial As Double


    'Alimentar valores
    'Procedimentos com proposito de coletar valores
    'e atribuir as variaveis acima usa dos conceitos
    'de programação orientada a objeto
    'ENCAPSULAMENTO, HERANÇA
    Sub SetPeriod(_input As Integer) 'Recebe parametro _input
        'Atribui a Periodo o valor de _input
        Periodo = _input
    End Sub

    Sub SetTaxMonth(_input As Integer)
        TaxaMensal = _input
    End Sub

    Sub SetTaxYearly(_input As Integer)
        TaxaAnual = _input
    End Sub

    Sub SetStartVaule(_input As Double)
        ValorInicial = _input
    End Sub

    Sub SetYearlyDeposit(_input As Double)
        DepositoAnual = _input
    End Sub

    Sub SetMonthDeposit(_input As Double)
        DepositoMensal = _input
    End Sub

    'Operações e calculos
    Function YearlyFV() As Double
        Dim Result As Double
        'Result recebe o valor do seguinte calculo
        Result = DepositoAnual * (((1 + TaxaAnual) ^ Periodo - 1) / TaxaAnual) + ValorInicial * (1 + TaxaAnual) ^ Periodo
        Return Result 'retorna Result
    End Function

    Function MonthlyFV() As Double
        Dim Result As Double
        Result = DepositoMensal * (((1 + TaxaMensal) ^ Periodo - 1) / TaxaMensal) + ValorInicial * (1 + TaxaMensal) ^ Periodo
        Return Result
    End Function

End Module