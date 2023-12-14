Imports System

Imports System.Windows.Forms

Public Class MyVerticalProgressBar

    Inherits ProgressBar

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams

        Get

            Dim pb As CreateParams = MyBase.CreateParams

            pb.Style = pb.Style Or &H6

            Return pb


        End Get

    End Property


End Class
