<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFifo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFifo))
        Me.LblAlgFIFO = New System.Windows.Forms.Label()
        Me.LblProcesosFIFO = New System.Windows.Forms.Label()
        Me.TbProcesosFIFO = New System.Windows.Forms.TextBox()
        Me.LblTiempoFIFO = New System.Windows.Forms.Label()
        Me.BtnIngresarFIFO = New System.Windows.Forms.Button()
        Me.BtnVolverFIFO = New System.Windows.Forms.Button()
        Me.TbTiempo = New System.Windows.Forms.TextBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.proceso1 = New System.Windows.Forms.Label()
        Me.proceso2 = New System.Windows.Forms.Label()
        Me.proceso3 = New System.Windows.Forms.Label()
        Me.proceso4 = New System.Windows.Forms.Label()
        Me.proceso5 = New System.Windows.Forms.Label()
        Me.proceso6 = New System.Windows.Forms.Label()
        Me.proceso7 = New System.Windows.Forms.Label()
        Me.proceso8 = New System.Windows.Forms.Label()
        Me.proceso9 = New System.Windows.Forms.Label()
        Me.proceso10 = New System.Windows.Forms.Label()
        Me.procesofin1 = New System.Windows.Forms.Label()
        Me.procesofin2 = New System.Windows.Forms.Label()
        Me.procesofin3 = New System.Windows.Forms.Label()
        Me.procesofin4 = New System.Windows.Forms.Label()
        Me.procesofin5 = New System.Windows.Forms.Label()
        Me.tiempo1 = New System.Windows.Forms.Label()
        Me.tiempo2 = New System.Windows.Forms.Label()
        Me.tiempo3 = New System.Windows.Forms.Label()
        Me.tiempo4 = New System.Windows.Forms.Label()
        Me.tiempo5 = New System.Windows.Forms.Label()
        Me.tiempo6 = New System.Windows.Forms.Label()
        Me.tiempo7 = New System.Windows.Forms.Label()
        Me.tiempo8 = New System.Windows.Forms.Label()
        Me.tiempo9 = New System.Windows.Forms.Label()
        Me.tiempo10 = New System.Windows.Forms.Label()
        Me.procesofin6 = New System.Windows.Forms.Label()
        Me.procesofin7 = New System.Windows.Forms.Label()
        Me.procesofin8 = New System.Windows.Forms.Label()
        Me.procesofin9 = New System.Windows.Forms.Label()
        Me.procesofin10 = New System.Windows.Forms.Label()
        Me.panelDecoracion = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lbNombretabla = New System.Windows.Forms.Label()
        Me.lbltiempotabla = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.lblEjecuciontabla = New System.Windows.Forms.Label()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblAlgFIFO
        '
        Me.LblAlgFIFO.AutoSize = True
        Me.LblAlgFIFO.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblAlgFIFO.Location = New System.Drawing.Point(13, 13)
        Me.LblAlgFIFO.Name = "LblAlgFIFO"
        Me.LblAlgFIFO.Size = New System.Drawing.Size(332, 21)
        Me.LblAlgFIFO.TabIndex = 0
        Me.LblAlgFIFO.Text = "ALGORITMO FIFO (First Imput First Output)"
        '
        'LblProcesosFIFO
        '
        Me.LblProcesosFIFO.AutoSize = True
        Me.LblProcesosFIFO.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblProcesosFIFO.Location = New System.Drawing.Point(12, 48)
        Me.LblProcesosFIFO.Name = "LblProcesosFIFO"
        Me.LblProcesosFIFO.Size = New System.Drawing.Size(255, 21)
        Me.LblProcesosFIFO.TabIndex = 1
        Me.LblProcesosFIFO.Text = "Procesos que ingresan (NOMBRE)"
        '
        'TbProcesosFIFO
        '
        Me.TbProcesosFIFO.Location = New System.Drawing.Point(285, 48)
        Me.TbProcesosFIFO.Name = "TbProcesosFIFO"
        Me.TbProcesosFIFO.Size = New System.Drawing.Size(100, 23)
        Me.TbProcesosFIFO.TabIndex = 2
        Me.TbProcesosFIFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblTiempoFIFO
        '
        Me.LblTiempoFIFO.AutoSize = True
        Me.LblTiempoFIFO.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTiempoFIFO.Location = New System.Drawing.Point(13, 77)
        Me.LblTiempoFIFO.Name = "LblTiempoFIFO"
        Me.LblTiempoFIFO.Size = New System.Drawing.Size(260, 21)
        Me.LblTiempoFIFO.TabIndex = 4
        Me.LblTiempoFIFO.Text = "Tiempo de ejecución en segundos"
        '
        'BtnIngresarFIFO
        '
        Me.BtnIngresarFIFO.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnIngresarFIFO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresarFIFO.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnIngresarFIFO.Location = New System.Drawing.Point(297, 115)
        Me.BtnIngresarFIFO.Name = "BtnIngresarFIFO"
        Me.BtnIngresarFIFO.Size = New System.Drawing.Size(75, 31)
        Me.BtnIngresarFIFO.TabIndex = 5
        Me.BtnIngresarFIFO.Text = "INGRESAR"
        Me.BtnIngresarFIFO.UseVisualStyleBackColor = False
        '
        'BtnVolverFIFO
        '
        Me.BtnVolverFIFO.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVolverFIFO.Location = New System.Drawing.Point(649, 504)
        Me.BtnVolverFIFO.Name = "BtnVolverFIFO"
        Me.BtnVolverFIFO.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolverFIFO.TabIndex = 6
        Me.BtnVolverFIFO.Text = "VOLVER"
        Me.BtnVolverFIFO.UseVisualStyleBackColor = False
        '
        'TbTiempo
        '
        Me.TbTiempo.Location = New System.Drawing.Point(285, 79)
        Me.TbTiempo.Name = "TbTiempo"
        Me.TbTiempo.Size = New System.Drawing.Size(100, 23)
        Me.TbTiempo.TabIndex = 8
        Me.TbTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIniciar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnIniciar.Location = New System.Drawing.Point(574, 211)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(94, 29)
        Me.BtnIniciar.TabIndex = 10
        Me.BtnIniciar.Text = "Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'proceso1
        '
        Me.proceso1.AutoSize = True
        Me.proceso1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso1.Location = New System.Drawing.Point(119, 239)
        Me.proceso1.Name = "proceso1"
        Me.proceso1.Size = New System.Drawing.Size(0, 17)
        Me.proceso1.TabIndex = 11
        '
        'proceso2
        '
        Me.proceso2.AutoSize = True
        Me.proceso2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso2.Location = New System.Drawing.Point(119, 262)
        Me.proceso2.Name = "proceso2"
        Me.proceso2.Size = New System.Drawing.Size(0, 17)
        Me.proceso2.TabIndex = 13
        '
        'proceso3
        '
        Me.proceso3.AutoSize = True
        Me.proceso3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso3.Location = New System.Drawing.Point(119, 282)
        Me.proceso3.Name = "proceso3"
        Me.proceso3.Size = New System.Drawing.Size(0, 17)
        Me.proceso3.TabIndex = 14
        '
        'proceso4
        '
        Me.proceso4.AutoSize = True
        Me.proceso4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso4.Location = New System.Drawing.Point(119, 303)
        Me.proceso4.Name = "proceso4"
        Me.proceso4.Size = New System.Drawing.Size(0, 17)
        Me.proceso4.TabIndex = 15
        '
        'proceso5
        '
        Me.proceso5.AutoSize = True
        Me.proceso5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso5.Location = New System.Drawing.Point(119, 323)
        Me.proceso5.Name = "proceso5"
        Me.proceso5.Size = New System.Drawing.Size(0, 17)
        Me.proceso5.TabIndex = 16
        '
        'proceso6
        '
        Me.proceso6.AutoSize = True
        Me.proceso6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso6.Location = New System.Drawing.Point(119, 344)
        Me.proceso6.Name = "proceso6"
        Me.proceso6.Size = New System.Drawing.Size(0, 17)
        Me.proceso6.TabIndex = 17
        '
        'proceso7
        '
        Me.proceso7.AutoSize = True
        Me.proceso7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso7.Location = New System.Drawing.Point(119, 365)
        Me.proceso7.Name = "proceso7"
        Me.proceso7.Size = New System.Drawing.Size(0, 17)
        Me.proceso7.TabIndex = 18
        '
        'proceso8
        '
        Me.proceso8.AutoSize = True
        Me.proceso8.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso8.Location = New System.Drawing.Point(119, 386)
        Me.proceso8.Name = "proceso8"
        Me.proceso8.Size = New System.Drawing.Size(0, 17)
        Me.proceso8.TabIndex = 19
        '
        'proceso9
        '
        Me.proceso9.AutoSize = True
        Me.proceso9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso9.Location = New System.Drawing.Point(119, 409)
        Me.proceso9.Name = "proceso9"
        Me.proceso9.Size = New System.Drawing.Size(0, 17)
        Me.proceso9.TabIndex = 20
        '
        'proceso10
        '
        Me.proceso10.AutoSize = True
        Me.proceso10.BackColor = System.Drawing.Color.PaleTurquoise
        Me.proceso10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.proceso10.Location = New System.Drawing.Point(119, 431)
        Me.proceso10.Name = "proceso10"
        Me.proceso10.Size = New System.Drawing.Size(0, 17)
        Me.proceso10.TabIndex = 21
        '
        'procesofin1
        '
        Me.procesofin1.AutoSize = True
        Me.procesofin1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin1.Location = New System.Drawing.Point(370, 239)
        Me.procesofin1.Name = "procesofin1"
        Me.procesofin1.Size = New System.Drawing.Size(0, 17)
        Me.procesofin1.TabIndex = 23
        '
        'procesofin2
        '
        Me.procesofin2.AutoSize = True
        Me.procesofin2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin2.Location = New System.Drawing.Point(370, 260)
        Me.procesofin2.Name = "procesofin2"
        Me.procesofin2.Size = New System.Drawing.Size(0, 17)
        Me.procesofin2.TabIndex = 24
        '
        'procesofin3
        '
        Me.procesofin3.AutoSize = True
        Me.procesofin3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin3.Location = New System.Drawing.Point(370, 282)
        Me.procesofin3.Name = "procesofin3"
        Me.procesofin3.Size = New System.Drawing.Size(0, 17)
        Me.procesofin3.TabIndex = 25
        '
        'procesofin4
        '
        Me.procesofin4.AutoSize = True
        Me.procesofin4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin4.Location = New System.Drawing.Point(370, 303)
        Me.procesofin4.Name = "procesofin4"
        Me.procesofin4.Size = New System.Drawing.Size(0, 17)
        Me.procesofin4.TabIndex = 26
        '
        'procesofin5
        '
        Me.procesofin5.AutoSize = True
        Me.procesofin5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin5.Location = New System.Drawing.Point(370, 323)
        Me.procesofin5.Name = "procesofin5"
        Me.procesofin5.Size = New System.Drawing.Size(0, 17)
        Me.procesofin5.TabIndex = 27
        '
        'tiempo1
        '
        Me.tiempo1.AutoSize = True
        Me.tiempo1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo1.Location = New System.Drawing.Point(214, 239)
        Me.tiempo1.Name = "tiempo1"
        Me.tiempo1.Size = New System.Drawing.Size(0, 17)
        Me.tiempo1.TabIndex = 28
        '
        'tiempo2
        '
        Me.tiempo2.AutoSize = True
        Me.tiempo2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo2.Location = New System.Drawing.Point(214, 262)
        Me.tiempo2.Name = "tiempo2"
        Me.tiempo2.Size = New System.Drawing.Size(0, 17)
        Me.tiempo2.TabIndex = 29
        '
        'tiempo3
        '
        Me.tiempo3.AutoSize = True
        Me.tiempo3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo3.Location = New System.Drawing.Point(214, 282)
        Me.tiempo3.Name = "tiempo3"
        Me.tiempo3.Size = New System.Drawing.Size(0, 17)
        Me.tiempo3.TabIndex = 30
        '
        'tiempo4
        '
        Me.tiempo4.AutoSize = True
        Me.tiempo4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo4.Location = New System.Drawing.Point(214, 302)
        Me.tiempo4.Name = "tiempo4"
        Me.tiempo4.Size = New System.Drawing.Size(0, 17)
        Me.tiempo4.TabIndex = 31
        '
        'tiempo5
        '
        Me.tiempo5.AutoSize = True
        Me.tiempo5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo5.Location = New System.Drawing.Point(214, 323)
        Me.tiempo5.Name = "tiempo5"
        Me.tiempo5.Size = New System.Drawing.Size(0, 17)
        Me.tiempo5.TabIndex = 32
        '
        'tiempo6
        '
        Me.tiempo6.AutoSize = True
        Me.tiempo6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo6.Location = New System.Drawing.Point(214, 344)
        Me.tiempo6.Name = "tiempo6"
        Me.tiempo6.Size = New System.Drawing.Size(0, 17)
        Me.tiempo6.TabIndex = 33
        '
        'tiempo7
        '
        Me.tiempo7.AutoSize = True
        Me.tiempo7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo7.Location = New System.Drawing.Point(214, 365)
        Me.tiempo7.Name = "tiempo7"
        Me.tiempo7.Size = New System.Drawing.Size(0, 17)
        Me.tiempo7.TabIndex = 34
        '
        'tiempo8
        '
        Me.tiempo8.AutoSize = True
        Me.tiempo8.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo8.Location = New System.Drawing.Point(214, 386)
        Me.tiempo8.Name = "tiempo8"
        Me.tiempo8.Size = New System.Drawing.Size(0, 17)
        Me.tiempo8.TabIndex = 35
        '
        'tiempo9
        '
        Me.tiempo9.AutoSize = True
        Me.tiempo9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo9.Location = New System.Drawing.Point(214, 409)
        Me.tiempo9.Name = "tiempo9"
        Me.tiempo9.Size = New System.Drawing.Size(0, 17)
        Me.tiempo9.TabIndex = 36
        '
        'tiempo10
        '
        Me.tiempo10.AutoSize = True
        Me.tiempo10.BackColor = System.Drawing.Color.PaleTurquoise
        Me.tiempo10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tiempo10.Location = New System.Drawing.Point(214, 431)
        Me.tiempo10.Name = "tiempo10"
        Me.tiempo10.Size = New System.Drawing.Size(0, 17)
        Me.tiempo10.TabIndex = 37
        '
        'procesofin6
        '
        Me.procesofin6.AutoSize = True
        Me.procesofin6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin6.Location = New System.Drawing.Point(370, 344)
        Me.procesofin6.Name = "procesofin6"
        Me.procesofin6.Size = New System.Drawing.Size(0, 17)
        Me.procesofin6.TabIndex = 38
        '
        'procesofin7
        '
        Me.procesofin7.AutoSize = True
        Me.procesofin7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin7.Location = New System.Drawing.Point(370, 365)
        Me.procesofin7.Name = "procesofin7"
        Me.procesofin7.Size = New System.Drawing.Size(0, 17)
        Me.procesofin7.TabIndex = 39
        '
        'procesofin8
        '
        Me.procesofin8.AutoSize = True
        Me.procesofin8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin8.Location = New System.Drawing.Point(370, 386)
        Me.procesofin8.Name = "procesofin8"
        Me.procesofin8.Size = New System.Drawing.Size(0, 17)
        Me.procesofin8.TabIndex = 40
        '
        'procesofin9
        '
        Me.procesofin9.AutoSize = True
        Me.procesofin9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin9.Location = New System.Drawing.Point(370, 407)
        Me.procesofin9.Name = "procesofin9"
        Me.procesofin9.Size = New System.Drawing.Size(0, 17)
        Me.procesofin9.TabIndex = 41
        '
        'procesofin10
        '
        Me.procesofin10.AutoSize = True
        Me.procesofin10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.procesofin10.Location = New System.Drawing.Point(370, 431)
        Me.procesofin10.Name = "procesofin10"
        Me.procesofin10.Size = New System.Drawing.Size(0, 17)
        Me.procesofin10.TabIndex = 42
        '
        'panelDecoracion
        '
        Me.panelDecoracion.BackColor = System.Drawing.SystemColors.ControlText
        Me.panelDecoracion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelDecoracion.Location = New System.Drawing.Point(109, 237)
        Me.panelDecoracion.Name = "panelDecoracion"
        Me.panelDecoracion.Size = New System.Drawing.Size(164, 3)
        Me.panelDecoracion.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(109, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(164, 3)
        Me.Panel1.TabIndex = 44
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel2.Location = New System.Drawing.Point(109, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(164, 1)
        Me.Panel2.TabIndex = 45
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel3.Location = New System.Drawing.Point(109, 282)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 1)
        Me.Panel3.TabIndex = 46
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel4.Location = New System.Drawing.Point(109, 302)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(164, 1)
        Me.Panel4.TabIndex = 47
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Location = New System.Drawing.Point(109, 323)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(164, 1)
        Me.Panel5.TabIndex = 48
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel6.Location = New System.Drawing.Point(109, 344)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(164, 1)
        Me.Panel6.TabIndex = 49
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel7.Location = New System.Drawing.Point(109, 365)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(164, 1)
        Me.Panel7.TabIndex = 50
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel8.Location = New System.Drawing.Point(109, 386)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(164, 1)
        Me.Panel8.TabIndex = 51
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel9.Location = New System.Drawing.Point(109, 409)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(164, 1)
        Me.Panel9.TabIndex = 52
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel10.Location = New System.Drawing.Point(109, 431)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(164, 1)
        Me.Panel10.TabIndex = 53
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel11.Location = New System.Drawing.Point(270, 206)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(3, 247)
        Me.Panel11.TabIndex = 54
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel12.Location = New System.Drawing.Point(109, 207)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(3, 247)
        Me.Panel12.TabIndex = 55
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel13.Location = New System.Drawing.Point(205, 207)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(3, 247)
        Me.Panel13.TabIndex = 56
        '
        'lbNombretabla
        '
        Me.lbNombretabla.AutoSize = True
        Me.lbNombretabla.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lbNombretabla.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbNombretabla.Location = New System.Drawing.Point(119, 211)
        Me.lbNombretabla.Name = "lbNombretabla"
        Me.lbNombretabla.Size = New System.Drawing.Size(67, 20)
        Me.lbNombretabla.TabIndex = 57
        Me.lbNombretabla.Text = "Nombre"
        '
        'lbltiempotabla
        '
        Me.lbltiempotabla.AutoSize = True
        Me.lbltiempotabla.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lbltiempotabla.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltiempotabla.Location = New System.Drawing.Point(208, 211)
        Me.lbltiempotabla.Name = "lbltiempotabla"
        Me.lbltiempotabla.Size = New System.Drawing.Size(62, 20)
        Me.lbltiempotabla.TabIndex = 58
        Me.lbltiempotabla.Text = "Tiempo"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel14.Location = New System.Drawing.Point(109, 206)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(164, 3)
        Me.Panel14.TabIndex = 59
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel15.Location = New System.Drawing.Point(351, 260)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(164, 1)
        Me.Panel15.TabIndex = 60
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel16.Location = New System.Drawing.Point(351, 282)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(164, 1)
        Me.Panel16.TabIndex = 61
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel17.Location = New System.Drawing.Point(351, 303)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(164, 1)
        Me.Panel17.TabIndex = 62
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel18.Location = New System.Drawing.Point(351, 323)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(164, 1)
        Me.Panel18.TabIndex = 63
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel19.Location = New System.Drawing.Point(351, 343)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(164, 1)
        Me.Panel19.TabIndex = 64
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel20.Location = New System.Drawing.Point(351, 365)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(164, 1)
        Me.Panel20.TabIndex = 65
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel21.Location = New System.Drawing.Point(351, 386)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(164, 1)
        Me.Panel21.TabIndex = 66
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel22.Location = New System.Drawing.Point(351, 406)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(164, 1)
        Me.Panel22.TabIndex = 67
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel23.Location = New System.Drawing.Point(351, 431)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(164, 1)
        Me.Panel23.TabIndex = 68
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel24.Location = New System.Drawing.Point(351, 453)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(164, 3)
        Me.Panel24.TabIndex = 69
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel25.Location = New System.Drawing.Point(351, 237)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(164, 3)
        Me.Panel25.TabIndex = 70
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel26.Location = New System.Drawing.Point(351, 209)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(3, 247)
        Me.Panel26.TabIndex = 71
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel27.Location = New System.Drawing.Point(512, 207)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(3, 247)
        Me.Panel27.TabIndex = 72
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.SystemColors.ControlText
        Me.Panel28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel28.Location = New System.Drawing.Point(351, 207)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(164, 3)
        Me.Panel28.TabIndex = 73
        '
        'lblEjecuciontabla
        '
        Me.lblEjecuciontabla.AutoSize = True
        Me.lblEjecuciontabla.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblEjecuciontabla.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEjecuciontabla.Location = New System.Drawing.Point(360, 211)
        Me.lblEjecuciontabla.Name = "lblEjecuciontabla"
        Me.lblEjecuciontabla.Size = New System.Drawing.Size(142, 20)
        Me.lblEjecuciontabla.TabIndex = 74
        Me.lblEjecuciontabla.Text = "Orden de ejecución"
        '
        'btnReiniciar
        '
        Me.btnReiniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReiniciar.Location = New System.Drawing.Point(574, 257)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(94, 25)
        Me.btnReiniciar.TabIndex = 75
        Me.btnReiniciar.Text = "Reiniciar"
        Me.btnReiniciar.UseVisualStyleBackColor = False
        '
        'FrmFifo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(750, 539)
        Me.Controls.Add(Me.btnReiniciar)
        Me.Controls.Add(Me.lblEjecuciontabla)
        Me.Controls.Add(Me.Panel28)
        Me.Controls.Add(Me.Panel27)
        Me.Controls.Add(Me.Panel26)
        Me.Controls.Add(Me.Panel25)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.Panel23)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel21)
        Me.Controls.Add(Me.Panel20)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.Panel18)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.lbltiempotabla)
        Me.Controls.Add(Me.lbNombretabla)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelDecoracion)
        Me.Controls.Add(Me.procesofin10)
        Me.Controls.Add(Me.procesofin9)
        Me.Controls.Add(Me.procesofin8)
        Me.Controls.Add(Me.procesofin7)
        Me.Controls.Add(Me.procesofin6)
        Me.Controls.Add(Me.tiempo10)
        Me.Controls.Add(Me.tiempo9)
        Me.Controls.Add(Me.tiempo8)
        Me.Controls.Add(Me.tiempo7)
        Me.Controls.Add(Me.tiempo6)
        Me.Controls.Add(Me.tiempo5)
        Me.Controls.Add(Me.tiempo4)
        Me.Controls.Add(Me.tiempo3)
        Me.Controls.Add(Me.tiempo2)
        Me.Controls.Add(Me.tiempo1)
        Me.Controls.Add(Me.procesofin5)
        Me.Controls.Add(Me.procesofin4)
        Me.Controls.Add(Me.procesofin3)
        Me.Controls.Add(Me.procesofin2)
        Me.Controls.Add(Me.procesofin1)
        Me.Controls.Add(Me.proceso10)
        Me.Controls.Add(Me.proceso9)
        Me.Controls.Add(Me.proceso8)
        Me.Controls.Add(Me.proceso7)
        Me.Controls.Add(Me.proceso6)
        Me.Controls.Add(Me.proceso5)
        Me.Controls.Add(Me.proceso4)
        Me.Controls.Add(Me.proceso3)
        Me.Controls.Add(Me.proceso2)
        Me.Controls.Add(Me.proceso1)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.TbTiempo)
        Me.Controls.Add(Me.BtnVolverFIFO)
        Me.Controls.Add(Me.BtnIngresarFIFO)
        Me.Controls.Add(Me.LblTiempoFIFO)
        Me.Controls.Add(Me.TbProcesosFIFO)
        Me.Controls.Add(Me.LblProcesosFIFO)
        Me.Controls.Add(Me.LblAlgFIFO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFifo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIFO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAlgFIFO As Label
    Friend WithEvents LblProcesosFIFO As Label
    Friend WithEvents TbProcesosFIFO As TextBox
    Friend WithEvents LblTiempoFIFO As Label
    Friend WithEvents BtnIngresarFIFO As Button
    Friend WithEvents BtnVolverFIFO As Button
    Friend WithEvents TbTiempo As TextBox
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents proceso1 As Label
    Friend WithEvents proceso2 As Label
    Friend WithEvents proceso3 As Label
    Friend WithEvents proceso4 As Label
    Friend WithEvents proceso5 As Label
    Friend WithEvents proceso6 As Label
    Friend WithEvents proceso7 As Label
    Friend WithEvents proceso8 As Label
    Friend WithEvents proceso9 As Label
    Friend WithEvents proceso10 As Label
    Friend WithEvents procesofin1 As Label
    Friend WithEvents procesofin2 As Label
    Friend WithEvents procesofin3 As Label
    Friend WithEvents procesofin4 As Label
    Friend WithEvents procesofin5 As Label
    Friend WithEvents tiempo1 As Label
    Friend WithEvents tiempo2 As Label
    Friend WithEvents tiempo3 As Label
    Friend WithEvents tiempo4 As Label
    Friend WithEvents tiempo5 As Label
    Friend WithEvents tiempo6 As Label
    Friend WithEvents tiempo7 As Label
    Friend WithEvents tiempo8 As Label
    Friend WithEvents tiempo9 As Label
    Friend WithEvents tiempo10 As Label
    Friend WithEvents procesofin6 As Label
    Friend WithEvents procesofin7 As Label
    Friend WithEvents procesofin8 As Label
    Friend WithEvents procesofin9 As Label
    Friend WithEvents procesofin10 As Label
    Friend WithEvents panelDecoracion As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lbNombretabla As Label
    Friend WithEvents lbltiempotabla As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel28 As Panel
    Friend WithEvents lblEjecuciontabla As Label
    Friend WithEvents btnReiniciar As Button
End Class
