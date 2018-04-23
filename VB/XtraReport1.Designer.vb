Namespace WebApplication1
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Dim storedProcQuery1 As New DevExpress.DataAccess.Sql.StoredProcQuery()
            Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
            Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.sqlDataSourceCustomerInfo = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSourceMainData = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.paramCustomerID = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlDataSourceCustomerInfo
            ' 
            Me.sqlDataSourceCustomerInfo.ConnectionName = "northwindConnection"
            Me.sqlDataSourceCustomerInfo.Name = "sqlDataSourceCustomerInfo"
            tableQuery1.Name = "Customers"
            tableInfo1.Name = "Customers"
            columnInfo1.Name = "CustomerID"
            columnInfo2.Name = "CompanyName"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.sqlDataSourceCustomerInfo.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSourceCustomerInfo.ResultSchemaSerializable = resources.GetString("sqlDataSourceCustomerInfo.ResultSchemaSerializable")
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Total", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 11.5R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrderHist.ProductName")})
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.Weight = 0.22222222222222221R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrderHist.Total")})
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.Weight = 0.22222222222222221R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSourceMainData
            ' 
            Me.sqlDataSourceMainData.ConnectionName = "northwindConnection"
            Me.sqlDataSourceMainData.Name = "sqlDataSourceMainData"
            storedProcQuery1.Name = "CustOrderHist"
            queryParameter1.Name = "@CustomerID"
            queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
            queryParameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.paramCustomerID]", GetType(String))
            storedProcQuery1.Parameters.Add(queryParameter1)
            storedProcQuery1.StoredProcName = "CustOrderHist"
            Me.sqlDataSourceMainData.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { storedProcQuery1})
            Me.sqlDataSourceMainData.ResultSchemaSerializable = resources.GetString("sqlDataSourceMainData.ResultSchemaSerializable")
            ' 
            ' paramCustomerID
            ' 
            Me.paramCustomerID.Description = "Customer ID"
            dynamicListLookUpSettings1.DataAdapter = Nothing
            dynamicListLookUpSettings1.DataMember = "Customers"
            dynamicListLookUpSettings1.DataSource = Me.sqlDataSourceCustomerInfo
            dynamicListLookUpSettings1.DisplayMember = "CompanyName"
            dynamicListLookUpSettings1.FilterString = Nothing
            dynamicListLookUpSettings1.ValueMember = "CustomerID"
            Me.paramCustomerID.LookUpSettings = dynamicListLookUpSettings1
            Me.paramCustomerID.Name = "paramCustomerID"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.ReportHeader.HeightF = 48.95833F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Italic)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(463.5417F, 46.25F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "Customer Order History"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.PageHeader.HeightF = 25F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(128)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
            Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 16F)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable2.StylePriority.UseBackColor = False
            Me.xrTable2.StylePriority.UseFont = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell3, Me.xrTableCell4})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "Product Name"
            Me.xrTableCell3.Weight = 0.22222222222222221R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "Total"
            Me.xrTableCell4.Weight = 0.22222222222222221R
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSourceMainData, Me.sqlDataSourceCustomerInfo})
            Me.DataMember = "CustOrderHist"
            Me.DataSource = Me.sqlDataSourceMainData
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.paramCustomerID})
            Me.Version = "14.2"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSourceMainData As DevExpress.DataAccess.Sql.SqlDataSource
        Private sqlDataSourceCustomerInfo As DevExpress.DataAccess.Sql.SqlDataSource
        Private paramCustomerID As DevExpress.XtraReports.Parameters.Parameter
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
