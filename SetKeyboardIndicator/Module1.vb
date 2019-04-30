Module Module1

    Sub Main()


        'Get Value from Registry'
        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_USERS\.DEFAULT\Control Panel\Keyboard", "InitialKeyboardIndicators", Nothing)
        Dim myInteger As Double

        'Convert Object to Double'
        myInteger = Convert.ToDouble(readValue.ToString)


        'Write Value into Registry'
        My.Computer.Registry.SetValue("HKEY_USERS\.DEFAULT\Control Panel\Keyboard", "InitialKeyboardIndicators", myInteger + 2)

    End Sub

End Module
