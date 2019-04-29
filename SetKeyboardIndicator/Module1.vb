Module Module1

    Sub Main()
        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_USERS\.DEFAULT\Control Panel\Keyboard", "InitialKeyboardIndicators", Nothing)
        Dim myInteger As Double
        myInteger = Convert.ToDouble(readValue.ToString)

        My.Computer.Registry.SetValue("HKEY_USERS\.DEFAULT\Control Panel\Keyboard", "InitialKeyboardIndicators", myInteger + 2)

    End Sub

End Module
