Sub Main()
        Dim C(5, 6) As Single

        For i As Integer = 0 To C.GetLength(0) - 1
            For j As Integer = 0 To C.GetLength(1) - 1
                C(i, j) = InputBox("Give a number of customers for the day " & j)
            Next
        Next

        Dim sum_customers As Single
        sum_customers = 0

        For i As Integer = 0 To C.GetLength(0) - 1
            For j As Integer = 0 To C.GetLength(1) - 1
                sum_customers = sum_customers + C(i, j)
            Next
        Next
        MsgBox("The total number of customers of all milk stations for the whole week is " & sum_customers)

        Dim min_customers As Single
        min_customers = 9999999
        For i As Integer = 0 To C.GetLength(0) - 1
            For j As Integer = 0 To C.GetLength(1) - 1
                If min_customers > C(i, j) Then
                    min_customers = C(i, j)
                End If

            Next
        Next
        MsgBox("The smallest number of customers of the week is " & min_customers)

        Dim sum_customers_under_60
        sum_customers_under_60 = 0

        For j As Integer = 0 To C.GetLength(1) - 1
            If C(2, j) < 60 Then
                sum_customers_under_60 = sum_customers_under_60 + C(2, j)
            End If
        Next
        MsgBox("For the 3rd milk station the number of customers is less than 60 " & sum_customers_under_60)

        Dim average_customers_per_day(6) As Single
        Dim sum_customers_per_day As Single

        For j As Integer = 0 To C.GetLength(1) - 1
            sum_customers_per_day = 0
            For i As Integer = 0 To C.GetLength(1) - 1
                sum_customers_per_day = sum_customers_per_day + C(i, j)
            Next
            average_customers_per_day(j) = sum_customers_per_day / 6
        Next

        Dim max_average_customers_per_day As Single
        max_average_customers_per_day = 0

        For i As Integer = 0 To average_customers_per_day.GetLength(0) - 1
            If max_average_customers_per_day < average_customers_per_day(i) Then
                max_average_customers_per_day = average_customers_per_day(i)
            End If
        Next
        MsgBox("The largest average number of customers per day is " & max_average_customers_per_day)

    End Sub