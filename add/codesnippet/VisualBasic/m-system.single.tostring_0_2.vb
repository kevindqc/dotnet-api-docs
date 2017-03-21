      Dim numbers() As Single = {1054.32179, -195489100.8377, 1.0437E21, _
                                 -1.0573e-05}
      Dim specifiers() As String = { "C", "E", "e", "F", "G", "N", "P", _
                                     "R", "#,000.000", "0.###E-000", _
                                     "000,000,000,000.00###"}
      For Each number As Single In numbers
         Console.WriteLine("Formatting of {0}:", number)
         For Each specifier As String In specifiers
            Console.WriteLine("   {0,5}: {1}", _
                              specifier, number.ToString(specifier))
         Next
         Console.WriteLine()
      Next
      ' The example displays the following output to the console:
      '       Formatting of 1054.32179:
      '              C: $1,054.32
      '              E: 1.054322E+003
      '              e: 1.054322e+003
      '              F: 1054.32
      '              G: 1054.32179
      '              N: 1,054.32
      '              P: 105,432.18 %
      '              R: 1054.32179
      '          #,000.000: 1,054.322
      '          0.###E-000: 1.054E003
      '          000,000,000,000.00###: 000,000,001,054.322      
      '       
      '       Formatting of -195489100.8377:
      '              C: ($195,489,100.84)
      '              E: -1.954891E+008
      '              e: -1.954891e+008
      '              F: -195489100.84
      '              G: -195489100.8377
      '              N: -195,489,100.84
      '              P: -19,548,910,083.77 %
      '              R: -195489100.8377
      '          #,000.000: -195,489,100.838
      '          0.###E-000: -1.955E008
      '          000,000,000,000.00###: -000,195,489,100.00
      '       
      '       Formatting of 1.0437E+21:
      '              C: $1,043,700,000,000,000,000,000.00
      '              E: 1.043700E+021
      '              e: 1.043700e+021
      '              F: 1043700000000000000000.00
      '              G: 1.0437E+21
      '              N: 1,043,700,000,000,000,000,000.00
      '              P: 104,370,000,000,000,000,000,000.00 %
      '              R: 1.0437E+21
      '          #,000.000: 1,043,700,000,000,000,000,000.000
      '          0.###E-000: 1.044E021
      '          000,000,000,000.00###: 1,043,700,000,000,000,000,000.00
      '       
      '       Formatting of -1.0573E-05:
      '              C: $0.00
      '              E: -1.057300E-005
      '              e: -1.057300e-005
      '              F: 0.00
      '              G: -1.0573E-05
      '              N: 0.00
      '              P: 0.00 %
      '              R: -1.0573E-05
      '          #,000.000: 000.000
      '          0.###E-000: -1.057E-005
      '          000,000,000,000.00###: -000,000,000,000.00001