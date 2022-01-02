Public Class Maze

	Private Sub Finish_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles Finish.MouseLeftButtonDown
		sender.Foreground = Brushes.DeepPink
		sender.Text = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
		MessageBox.Show("You Win!")
	End Sub

	Private Sub TextBlock_MouseDown_1(sender As Object, e As MouseButtonEventArgs)
		sender.Text = "########################################"
	End Sub

	Private Sub TextBlock_MouseDown_2(sender As Object, e As MouseButtonEventArgs)
		sender.Text = "########################################"
		Extra.Text = "########################################"
	End Sub
End Class
