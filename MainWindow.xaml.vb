Class MainWindow 

	Private Sub PlayMazeGame_Click(sender As Object, e As RoutedEventArgs) Handles PlayMazeGame.Click
		Dim win2 = New Maze
		win2.Show()
	End Sub

	Private Sub PlayDuckHunt_Click(sender As Object, e As RoutedEventArgs) Handles PlayDuckHunt.Click
		Dim win2 = New DuckHunt
		win2.Show()
	End Sub

	Private Sub Sandbox_Click(sender As Object, e As RoutedEventArgs) Handles Sandbox.Click
		Dim win2 = New Sandbox
		win2.Show()
	End Sub

End Class
