Imports System.IO
Imports System.Text
Imports System.Collections.Specialized
Imports System.Net
Imports NDde
Imports NDde.Client

Public Class Form1
	Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

	Public Structure COPYDATASTRUCT
		Public dwData As IntPtr
		Public cbData As Integer
		Public lpData As String
	End Structure

	Private Const WM_APP As Integer = &H8000
	Private Const WM_HWND As Integer = WM_APP + &H100
	Private Const WM_START As Integer = WM_APP + &H200
	Private Const WM_FINISH As Integer = WM_APP + &H300
	Private Const WM_SENDLINE As Integer = WM_APP + &H500

	Private hWnd As String
	Private itemList As New ArrayList

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Using hWndReader As New StreamReader(Application.StartupPath & "\hWnd.txt", Encoding.GetEncoding("Shift-JIS"))
			hWnd = Integer.Parse(hWndReader.ReadToEnd())
		End Using

		Using itemReader As New StreamReader(Application.StartupPath & "\ItemList.txt", Encoding.GetEncoding("Shift-JIS"))
			Do Until itemReader.EndOfStream
				itemList.Add(itemReader.ReadLine())
			Loop
		End Using

		SendMessage(hWnd, WM_HWND, Me.Handle, 0)
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		Select Case m.Msg
			Case WM_START
				Dim codeList As New ArrayList
				Dim output As String = ""

				Using codeReader As New StreamReader(Application.StartupPath & "\CodeList.txt", Encoding.GetEncoding("Shift-JIS"))
					Do Until codeReader.EndOfStream
						codeList.Add(codeReader.ReadLine())
					Loop
				End Using

				For Each code In codeList
					Using dc As New DdeClient("RSS", code & ".T")
						Try
							dc.Connect() '接続

							output &= code
							For Each item In itemList
								Dim temp() As Byte = dc.Request(item, 1, 60000)
								output &= "," & Encoding.Default.GetString(temp, 0, temp.Length - 1) '取得
							Next
							output &= vbCrLf

						Catch ex As DdeException
							output = "Error"
							Exit For
						End Try
					End Using
				Next

				Using getInfoWriter As New StreamWriter(Application.StartupPath & "\GetInfo.csv", False, Encoding.GetEncoding("Shift-JIS"))
					getInfoWriter.Write(output)
				End Using

				SendMessage(hWnd, WM_FINISH, 0, 0)

			Case WM_SENDLINE
				Dim sendText As String

				Using lineInfoReader As New StreamReader(Application.StartupPath & "\LineInfo.txt", Encoding.GetEncoding("Shift-JIS"))
					sendText = lineInfoReader.ReadToEnd()
				End Using

				Using wc As New WebClient
					Dim data As New NameValueCollection
					data.Add("sendtext", sendText)
					wc.UploadValues("https://lolipop-dp26251191.ssl-lolipop.jp/line/sendline.php", data)
				End Using
		End Select

		MyBase.WndProc(m)
	End Sub
End Class
