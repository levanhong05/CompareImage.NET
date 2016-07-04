Imports System.IO
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class frmCompare
    Private ReadOnly matrix As ColorMatrix = New ColorMatrix(New Single()() { _
                                                             New Single() {0.3F, 0.3F, 0.3F, 0, 0}, _
                                                             New Single() {0.59F, 0.59F, 0.59F, 0, 0}, _
                                                             New Single() {0.11F, 0.11F, 0.11F, 0, 0}, _
                                                             New Single() {0, 0, 0, 1, 0}, _
                                                             New Single() {0, 0, 0, 0, 1}})

    Dim path(1) As String

    Private Sub btnImageSrc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageSrc.Click
        Dim openDialogOpen As New OpenFileDialog
        'Set the Open dialog properties
        With openDialogOpen
            .Filter = "JPEG (*.jpg)|*.jpg"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        If openDialogOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Read the contents of the file
            Dim NomFic As String = openDialogOpen.FileName
            path(0) = NomFic
            sourcePictureBox.Load(NomFic)
        End If
    End Sub

    Private Sub btnImageDes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageDes.Click
        Dim openDialogOpen As New OpenFileDialog
        'Set the Open dialog properties
        With openDialogOpen
            .Filter = "JPEG (*.jpg)|*.jpg"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        If openDialogOpen.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Read the contents of the file
            Dim NomFic As String = openDialogOpen.FileName
            path(1) = NomFic
            destinationPictureBox.Load(NomFic)
        End If
    End Sub

    Private Function ResizeImage(ByVal originalImage As Image, ByVal newWidth As Integer, ByVal newHeight As Integer) As Image
        Dim smallVersion As Image = New Bitmap(newWidth, newHeight)
        Using g As Graphics = Graphics.FromImage(smallVersion)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = PixelOffsetMode.HighQuality
            g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
        End Using

        Return smallVersion
    End Function

    Private Function GetGrayScaleVersion(ByVal original As Image) As Image
        'create a blank bitmap the same size as original
        Dim newBitmap As Bitmap = New Bitmap(original.Width, original.Height)

        'get a graphics object from the new image
        Using g As Graphics = Graphics.FromImage(newBitmap)
            'create some image attributes
            Dim attributes As ImageAttributes = New ImageAttributes()

            'set the color matrix attribute
            attributes.SetColorMatrix(matrix)

            'draw the original image on the new image
            'using the grayscale color matrix
            g.DrawImage(original, New Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes)
        End Using
        Return newBitmap
    End Function

    Private Function GetGrayScaleValues(ByVal img As Image) As Double(,)
        Using thisOne As Bitmap = CType(GetGrayScaleVersion(ResizeImage(img, 16, 16)), Bitmap)
            Dim grayScale(15, 15) As Double

            For y As Integer = 0 To 15
                For x As Integer = 0 To 15
                    grayScale(x, y) = thisOne.GetPixel(x, y).R * 0.299 + thisOne.GetPixel(x, y).G * 0.587 + thisOne.GetPixel(x, y).B * 0.144
                Next
            Next
            Return grayScale
        End Using

    End Function

    Private Function GetDifferences(ByVal img1 As Image, ByVal img2 As Image) As Double(,)
        Dim thisOne As Bitmap = CType(GetGrayScaleVersion(ResizeImage(img1, 16, 16)), Bitmap)
        Dim theOtherOne As Bitmap = CType(GetGrayScaleVersion(ResizeImage(img2, 16, 16)), Bitmap)

        Dim differences(15, 15) As Double
        Dim firstGray(15, 15) As Double
        Dim secondGray(15, 15) As Double

        firstGray = GetGrayScaleValues(thisOne)
        secondGray = GetGrayScaleValues(theOtherOne)

        For y As Integer = 0 To 15
            For x As Integer = 0 To 15
                differences(x, y) = Math.Abs(firstGray(x, y) - secondGray(x, y))
            Next
        Next

        thisOne.Dispose()
        theOtherOne.Dispose()

        Return differences
    End Function

    Private Function PercentageDifference(ByVal img1 As Image, ByVal img2 As Image, Optional ByVal threshold As Double = 5) As Double
        Dim differences(15, 15) As Double
        differences = GetDifferences(img1, img2)

        Dim diffPixels As Integer = 0

        For Each b As Double In differences
            If (b > threshold) Then
                diffPixels = diffPixels + 1
            End If
        Next

        Return diffPixels / 256.0F
    End Function

    Private Function CheckIfFileExists(ByVal filePath As String) As Boolean
        If File.Exists(filePath) = False Then
            Throw New FileNotFoundException("File '" + filePath + "' not found!")
        End If
        Return True
    End Function

    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        ' Load the images.
        Dim bm1 As Bitmap = Image.FromFile(path(0))
        Dim bm2 As Bitmap = Image.FromFile(path(1))

        Dim diff As Double = PercentageDifference(bm1, bm2)
        Label3.Text = (diff * 100).ToString
        If diff <= 0.25 Then
            Label2.Text = "The images are identical."
        Else
            Label2.Text = "The images are different."
        End If

        bm1.Dispose()
        bm2.Dispose()
    End Sub
End Class
