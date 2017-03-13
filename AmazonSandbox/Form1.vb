Option Explicit On
Imports MWS.AmazonAPI

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New MWS.AmazonAPI(Me.Name, "1.0", "AKIAJBCNHLCSDWQXOLVQ", "tmzZ+4tONP1tEol6bYUDvBK6Ovlsv2YpinKre2BW", "https://mws.amazonservices.com")
        Dim b As New MWS.MarketplaceWebServiceProducts(Me.Name, "1.0", "AKIAJBCNHLCSDWQXOLVQ", "tmzZ+4tONP1tEol6bYUDvBK6Ovlsv2YpinKre2BW", "https://mws.amazonservices.com", "A1OS0G2OT7MBNC", "
amzn.mws.02ad5b62-ab17-8942-3c00-f8887f7670e2", "ATVPDKIKZ0DER")
        Dim results As MWS.AmazonAPI.APIResults
        b.InvokeGetCompetitivePricingForASIN("A1OS0G2OT7MBNC", "amzn.mws.02ad5b62-ab17-8942-3c00-f8887f7670e2", "ATVPDKIKZ0DER", results)

    End Sub
End Class
