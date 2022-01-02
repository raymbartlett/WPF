Imports System.Threading

Public Class DuckHunt

	Dim score As Integer = 0
	Dim killed As Boolean = False
	Dim startLag As Integer
	Dim endLag As Integer

	Dim difficulty As Integer = 0
	Dim easyHighScore As Integer = 0
	Dim mediumHighScore As Integer = 0
	Dim hardHighScore As Integer = 0

	Private Async Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

		score = 0
		HideMenu()

		Await Task.Delay(1000)

		For i = 1 To 40
			Dim location As Integer = (Rnd() * 25)

			If location = 1 Then
				A1.Source = Duck.Source
				Await Task.Delay(startLag)
				A1.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 2 Then
				A2.Source = Duck.Source
				Await Task.Delay(startLag)
				A2.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 3 Then
				A3.Source = Duck.Source
				Await Task.Delay(startLag)
				A3.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 4 Then
				A4.Source = Duck.Source
				Await Task.Delay(startLag)
				A4.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 5 Then
				A5.Source = Duck.Source
				Await Task.Delay(startLag)
				A5.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 6 Then
				A6.Source = Duck.Source
				Await Task.Delay(startLag)
				A6.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 7 Then
				A7.Source = Duck.Source
				Await Task.Delay(startLag)
				A7.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 8 Then
				A8.Source = Duck.Source
				Await Task.Delay(startLag)
				A8.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 9 Then
				B1.Source = Duck.Source
				Await Task.Delay(startLag)
				B1.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 10 Then
				B2.Source = Duck.Source
				Await Task.Delay(startLag)
				B2.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 11 Then
				B3.Source = Duck.Source
				Await Task.Delay(startLag)
				B3.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 12 Then
				B4.Source = Duck.Source
				Await Task.Delay(startLag)
				B4.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 13 Then
				B5.Source = Duck.Source
				Await Task.Delay(startLag)
				B5.Source = Blank.Source
				Await Task.Delay(endLag)

				'Sun Tile
			ElseIf location = 14 Then
				E8.Source = Duck.Source
				Await Task.Delay(startLag)
				E8.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 15 Then
				B7.Source = Duck.Source
				Await Task.Delay(startLag)
				B7.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 16 Then
				B8.Source = Duck.Source
				Await Task.Delay(startLag)
				B8.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 17 Then
				C1.Source = Duck.Source
				Await Task.Delay(startLag)
				C1.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 18 Then
				C2.Source = Duck.Source
				Await Task.Delay(startLag)
				C2.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 19 Then
				C3.Source = Duck.Source
				Await Task.Delay(startLag)
				C3.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 20 Then
				C4.Source = Duck.Source
				Await Task.Delay(startLag)
				C4.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 21 Then
				C5.Source = Duck.Source
				Await Task.Delay(startLag)
				C5.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 22 Then
				C6.Source = Duck.Source
				Await Task.Delay(startLag)
				C6.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 23 Then
				C7.Source = Duck.Source
				Await Task.Delay(startLag)
				C7.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 24 Then
				C8.Source = Duck.Source
				Await Task.Delay(startLag)
				C8.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 25 Then
				D1.Source = Duck.Source
				Await Task.Delay(startLag)
				D1.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 26 Then
				D2.Source = Duck.Source
				Await Task.Delay(startLag)
				D2.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 27 Then
				D3.Source = Duck.Source
				Await Task.Delay(startLag)
				D3.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 28 Then
				D4.Source = Duck.Source
				Await Task.Delay(startLag)
				D4.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 29 Then
				D5.Source = Duck.Source
				Await Task.Delay(startLag)
				D5.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 30 Then
				D6.Source = Duck.Source
				Await Task.Delay(startLag)
				D6.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 31 Then
				D7.Source = Duck.Source
				Await Task.Delay(startLag)
				D7.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 32 Then
				D8.Source = Duck.Source
				Await Task.Delay(startLag)
				D8.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 33 Then
				E1.Source = Duck.Source
				Await Task.Delay(startLag)
				E1.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 34 Then
				E2.Source = Duck.Source
				Await Task.Delay(startLag)
				E2.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 35 Then
				E3.Source = Duck.Source
				Await Task.Delay(startLag)
				E3.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 36 Then
				E4.Source = Duck.Source
				Await Task.Delay(startLag)
				E4.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 37 Then
				E5.Source = Duck.Source
				Await Task.Delay(startLag)
				E5.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 38 Then
				E6.Source = Duck.Source
				Await Task.Delay(startLag)
				E6.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 39 Then
				E7.Source = Duck.Source
				Await Task.Delay(startLag)
				E7.Source = Blank.Source
				Await Task.Delay(endLag)

			ElseIf location = 40 Then
				E8.Source = Duck.Source
				Await Task.Delay(startLag)
				E8.Source = Blank.Source
				Await Task.Delay(endLag)

			End If

			killed = False

			If i < 40 Then
				NumDucks.Text = (i + 1).ToString()
			End If

			If score > 40 Then
				MessageBox.Show("Error: Score is above 40. Something went wrong")
				Exit Sub
			End If

		Next

		'Change Assets
		DayToNight()

		'Update High Scores
		updateHighScores(score, difficulty)

		'Output score
		DisplayScore.Text = ("Your score: " + score.ToString())
		Repeat.Visibility = Visibility.Visible

	End Sub


	Private Sub HideMenu()
		NormalCursor.Visibility = Visibility.Hidden

		Logo.Visibility = Visibility.Hidden
		Cloud1.Visibility = Visibility.Hidden
		Cloud2.Visibility = Visibility.Hidden
		Cloud3.Visibility = Visibility.Hidden
		Cloud4.Visibility = Visibility.Hidden

		Start.Visibility = Visibility.Hidden

	End Sub

	Private Sub DayToNight()
		NumDucks.Text = ""

		Night.Visibility = Visibility.Visible
		Moon.Visibility = Visibility.Visible
		Stars.Visibility = Visibility.Visible

		DogAppears.Visibility = Visibility.Visible
		NormalCursor.Visibility = Visibility.Visible
		DisplayScore.Visibility = Visibility.Visible

	End Sub

	Private Sub ShowMenu()
		NormalCursor.Visibility = Visibility.Visible

		Logo.Visibility = Visibility.Visible
		Cloud1.Visibility = Visibility.Visible
		Cloud2.Visibility = Visibility.Visible
		Cloud3.Visibility = Visibility.Visible
		Cloud4.Visibility = Visibility.Visible

		Easy.Visibility = Visibility.Visible
		Medium.Visibility = Visibility.Visible
		Hard.Visibility = Visibility.Visible

	End Sub

	Private Sub NightToDay()

		Night.Visibility = Visibility.Hidden
		Moon.Visibility = Visibility.Hidden
		Stars.Visibility = Visibility.Hidden

		DogAppears.Visibility = Visibility.Hidden
		DisplayScore.Visibility = Visibility.Hidden

	End Sub

	Private Sub updateHighScores(score As Integer, difficulty As Integer)

		If difficulty = 1 And score >= easyHighScore Then
			easyHighScore = score
			EasyHS.Text = "Easy: " + easyHighScore.ToString()

		ElseIf difficulty = 2 And score >= mediumHighScore Then
			mediumHighScore = score
			MediumHS.Text = "Medium: " + mediumHighScore.ToString()

		ElseIf difficulty = 3 And score >= hardHighScore Then
			hardHighScore = score
			HardHS.Text = "Hard: " + hardHighScore.ToString()

		End If
	End Sub


	Private Sub A1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles A1.MouseDown, A2.MouseDown, A3.MouseDown, A4.MouseDown, A5.MouseDown, A6.MouseDown, A7.MouseDown, A8.MouseDown, B1.MouseDown, B2.MouseDown, B3.MouseDown, B4.MouseDown, B5.MouseDown, B6.MouseDown, B7.MouseDown, B8.MouseDown, C1.MouseDown, C2.MouseDown, C3.MouseDown, C4.MouseDown, C5.MouseDown, C6.MouseDown, C7.MouseDown, C8.MouseDown, D1.MouseDown, D2.MouseDown, D3.MouseDown, D4.MouseDown, D5.MouseDown, D6.MouseDown, D7.MouseDown, D8.MouseDown, E1.MouseDown, E2.MouseDown, E3.MouseDown, E4.MouseDown, E5.MouseDown, E6.MouseDown, E7.MouseDown, E8.MouseDown

		'killed = False prevents double clicks counting as + 2
		If sender.Source.ToString() = Duck.Source.ToString() And killed = False Then
			score += 1
			killed = True
			sender.Source = ShotDuck.Source

		End If

	End Sub

	Private Sub Easy_Click(sender As Object, e As RoutedEventArgs) Handles Easy.Click
		startLag = 700
		endLag = 700
		difficulty = 1

		Easy.Visibility = Visibility.Hidden
		Medium.Visibility = Visibility.Hidden
		Hard.Visibility = Visibility.Hidden

		Start.Visibility = Visibility.Visible

	End Sub

	Private Sub Medium_Click(sender As Object, e As RoutedEventArgs) Handles Medium.Click
		startLag = 550
		endLag = 550
		difficulty = 2

		Easy.Visibility = Visibility.Hidden
		Medium.Visibility = Visibility.Hidden
		Hard.Visibility = Visibility.Hidden

		Start.Visibility = Visibility.Visible

	End Sub

	Private Sub Hard_Click(sender As Object, e As RoutedEventArgs) Handles Hard.Click
		startLag = 400
		endLag = 400
		difficulty = 3

		Easy.Visibility = Visibility.Hidden
		Medium.Visibility = Visibility.Hidden
		Hard.Visibility = Visibility.Hidden

		Start.Visibility = Visibility.Visible

	End Sub

	Private Sub Repeat_Click(sender As Object, e As RoutedEventArgs)
		difficulty = 0
		NightToDay()
		ShowMenu()
		Repeat.Visibility = Visibility.Hidden

	End Sub

End Class
