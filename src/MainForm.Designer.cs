// <copyright file="MainForm.Designer.cs" company="N/A">
// Copyright 2025 Scott M. Lerch
// 
// This file is part of HostsFileEditor.
// 
// HostsFileEditor is free software: you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free 
// Software Foundation, either version 2 of the License, or (at your option)
// any later version.
// 
// HostsFileEditor is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
// 
// You should have received a copy of the GNU General Public   License along
// with HostsFileEditor. If not, see http://www.gnu.org/licenses/.
// </copyright>

namespace HostsFileEditor;

/// <summary>
/// MainForm designer class.
/// </summary>
partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        ToolStripSeparator toolStripSeparator22;
        ToolStripSeparator toolStripSeparator23;
        ToolStripSeparator toolStripSeparator25;
        ToolStripLabel toolStripLabel1;
        ToolStripSeparator toolStripSeparator27;
        ToolStripSeparator toolStripSeparator18;
        ToolStripSeparator toolStripSeparator14;
        ToolStripSeparator toolStripSeparator13;
        ToolStripSeparator toolStripSeparator12;
        ToolStripSeparator toolStripSeparator28;
        ToolStripSeparator toolStripSeparator4;
        ToolStripSeparator toolStripSeparator5;
        ToolStripSeparator toolStripSeparator6;
        ToolStripSeparator toolStripSeparator24;
        ToolStripSeparator toolStripSeparator9;
        ToolStripMenuItem menuFilter;
        ToolStripSeparator toolStripSeparator15;
        ToolStripSeparator toolStripSeparator26;
        ToolStripSeparator toolStripSeparator16;
        ToolStripSeparator toolStripSeparator17;
        ToolStripSeparator toolStripSeparator19;
        ToolStripSeparator toolStripSeparator21;
        ToolStripSeparator toolStripSeparator20;
        ToolStripSeparator toolStripSeparator1;
        toolStripContainer = new ToolStripContainer();
        statusStrip = new StatusStrip();
        labelLineCount = new ToolStripStatusLabel();
        labelLineCountNumber = new HostsFileEditor.Controls.ToolStripBindableStatusLabel();
        bindingSourceHostFile = new BindingSource(components);
        labelHostEntries = new ToolStripStatusLabel();
        labelHostEntriesCount = new HostsFileEditor.Controls.ToolStripBindableStatusLabel();
        splitContainer = new SplitContainer();
        dataGridViewHostsEntries = new HostsFileEditor.Controls.HostsEntryDataGridView();
        columnValid = new DataGridViewCheckBoxColumn();
        columnEnabled = new DataGridViewCheckBoxColumn();
        columnIpAddress = new DataGridViewTextBoxColumn();
        columnHostnames = new DataGridViewTextBoxColumn();
        columnComment = new DataGridViewTextBoxColumn();
        columnUnparsedText = new DataGridViewTextBoxColumn();
        columnFiller = new DataGridViewTextBoxColumn();
        contextMenuGrid = new ContextMenuStrip(components);
        menuContextCut = new ToolStripMenuItem();
        menuContextCopy = new ToolStripMenuItem();
        menuContextPaste = new ToolStripMenuItem();
        toolStripSeparator32 = new ToolStripSeparator();
        menuContextDuplicate = new ToolStripMenuItem();
        menuContextDelete = new ToolStripMenuItem();
        menuContextMoveUp = new ToolStripMenuItem();
        menuContextMoveDown = new ToolStripMenuItem();
        menuContextInsertAbove = new ToolStripMenuItem();
        menuContextInsertBelow = new ToolStripMenuItem();
        toolStripSeparator31 = new ToolStripSeparator();
        contextMenuCheck = new ToolStripMenuItem();
        contextMenuUncheck = new ToolStripMenuItem();
        bindingSourceView = new BindingSource(components);
        dataGridViewArchive = new HostsFileEditor.Controls.HostsArchiveDataGridView();
        fileNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        bindingSourceArchive = new BindingSource(components);
        toolStripArchive = new HostsFileEditor.Controls.ToolStripEx();
        buttonDeleteArchive = new ToolStripButton();
        buttonLoadArchive = new ToolStripButton();
        menuStrip = new HostsFileEditor.Controls.MenuStripEx();
        menuFile = new ToolStripMenuItem();
        menuSave = new ToolStripMenuItem();
        menuSaveAs = new ToolStripMenuItem();
        menuArchive = new ToolStripMenuItem();
        openTextEditor = new ToolStripMenuItem();
        menuRestoreDefaults = new ToolStripMenuItem();
        menuDisable = new ToolStripMenuItem();
        menuImport = new ToolStripMenuItem();
        menuExit = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        menuRefresh = new ToolStripMenuItem();
        menuUndo = new ToolStripMenuItem();
        menuRedo = new ToolStripMenuItem();
        menuCut = new ToolStripMenuItem();
        menuCopy = new ToolStripMenuItem();
        menuPaste = new ToolStripMenuItem();
        toolStripSeparator33 = new ToolStripSeparator();
        menuDuplicate = new ToolStripMenuItem();
        menuDelete = new ToolStripMenuItem();
        menuMoveUp = new ToolStripMenuItem();
        menuMoveDown = new ToolStripMenuItem();
        insertRowAboveToolStripMenuItem = new ToolStripMenuItem();
        insertRowBelowToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator30 = new ToolStripSeparator();
        menuCheck = new ToolStripMenuItem();
        menuUncheck = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
        menuViewArchive = new ToolStripMenuItem();
        menuFilterComments = new ToolStripMenuItem();
        menuFilterDisabled = new ToolStripMenuItem();
        toolStripSeparator29 = new ToolStripSeparator();
        menuRemoveSort = new ToolStripMenuItem();
        menuTools = new ToolStripMenuItem();
        menuPingIPs = new ToolStripMenuItem();
        menuRemoveDefaultText = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        toolStrip = new HostsFileEditor.Controls.ToolStripEx();
        buttonSave = new ToolStripButton();
        buttonRefresh = new ToolStripButton();
        buttonDisable = new ToolStripButton();
        buttonArchive = new ToolStripButton();
        buttonViewArchive = new ToolStripButton();
        toolStripDropDownButton1 = new ToolStripLabel();
        buttonFilterComment = new ToolStripButton();
        buttonFilterDisabled = new ToolStripButton();
        textFilter = new HostsFileEditor.Controls.ToolStripSpringTextBox();
        toolStripSeparator2 = new ToolStripSeparator();
        toolStripSeparator7 = new ToolStripSeparator();
        toolStripSeparator = new ToolStripSeparator();
        toolStripSeparator3 = new ToolStripSeparator();
        toolStripSeparator8 = new ToolStripSeparator();
        toolStripSeparator10 = new ToolStripSeparator();
        toolStripSeparator11 = new ToolStripSeparator();
        toolStripMenuItem1 = new ToolStripMenuItem();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        toolStripButton1 = new ToolStripButton();
        saveFileDialog = new SaveFileDialog();
        notifyIcon = new NotifyIcon(components);
        contextMenuTray = new ContextMenuStrip(components);
        menuContextEdit = new ToolStripMenuItem();
        menuContextDisable = new ToolStripMenuItem();
        contextMenuExit = new ToolStripMenuItem();
        openFileDialog = new OpenFileDialog();
        bindingSourceHostEntries = new BindingSource(components);
        toolStripSeparator22 = new ToolStripSeparator();
        toolStripSeparator23 = new ToolStripSeparator();
        toolStripSeparator25 = new ToolStripSeparator();
        toolStripLabel1 = new ToolStripLabel();
        toolStripSeparator27 = new ToolStripSeparator();
        toolStripSeparator18 = new ToolStripSeparator();
        toolStripSeparator14 = new ToolStripSeparator();
        toolStripSeparator13 = new ToolStripSeparator();
        toolStripSeparator12 = new ToolStripSeparator();
        toolStripSeparator28 = new ToolStripSeparator();
        toolStripSeparator4 = new ToolStripSeparator();
        toolStripSeparator5 = new ToolStripSeparator();
        toolStripSeparator6 = new ToolStripSeparator();
        toolStripSeparator24 = new ToolStripSeparator();
        toolStripSeparator9 = new ToolStripSeparator();
        menuFilter = new ToolStripMenuItem();
        toolStripSeparator15 = new ToolStripSeparator();
        toolStripSeparator26 = new ToolStripSeparator();
        toolStripSeparator16 = new ToolStripSeparator();
        toolStripSeparator17 = new ToolStripSeparator();
        toolStripSeparator19 = new ToolStripSeparator();
        toolStripSeparator21 = new ToolStripSeparator();
        toolStripSeparator20 = new ToolStripSeparator();
        toolStripSeparator1 = new ToolStripSeparator();
        toolStripContainer.BottomToolStripPanel.SuspendLayout();
        toolStripContainer.ContentPanel.SuspendLayout();
        toolStripContainer.TopToolStripPanel.SuspendLayout();
        toolStripContainer.SuspendLayout();
        statusStrip.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bindingSourceHostFile).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
        splitContainer.Panel1.SuspendLayout();
        splitContainer.Panel2.SuspendLayout();
        splitContainer.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewHostsEntries).BeginInit();
        contextMenuGrid.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bindingSourceView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewArchive).BeginInit();
        ((System.ComponentModel.ISupportInitialize)bindingSourceArchive).BeginInit();
        toolStripArchive.SuspendLayout();
        menuStrip.SuspendLayout();
        toolStrip.SuspendLayout();
        contextMenuTray.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)bindingSourceHostEntries).BeginInit();
        SuspendLayout();
        // 
        // toolStripContainer
        // 
        // 
        // toolStripContainer.BottomToolStripPanel
        // 
        toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
        // 
        // toolStripContainer.ContentPanel
        // 
        toolStripContainer.ContentPanel.Controls.Add(splitContainer);
        resources.ApplyResources(toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
        resources.ApplyResources(toolStripContainer, "toolStripContainer");
        toolStripContainer.Name = "toolStripContainer";
        // 
        // toolStripContainer.TopToolStripPanel
        // 
        toolStripContainer.TopToolStripPanel.Controls.Add(menuStrip);
        toolStripContainer.TopToolStripPanel.Controls.Add(toolStrip);
        // 
        // statusStrip
        // 
        resources.ApplyResources(statusStrip, "statusStrip");
        statusStrip.Items.AddRange(new ToolStripItem[] { labelLineCount, labelLineCountNumber, labelHostEntries, labelHostEntriesCount });
        statusStrip.Name = "statusStrip";
        // 
        // labelLineCount
        // 
        labelLineCount.Name = "labelLineCount";
        resources.ApplyResources(labelLineCount, "labelLineCount");
        // 
        // labelLineCountNumber
        // 
        labelLineCountNumber.DataBindings.Add(new Binding("Text", bindingSourceHostFile, "LineCount", true));
        labelLineCountNumber.Name = "labelLineCountNumber";
        resources.ApplyResources(labelLineCountNumber, "labelLineCountNumber");
        // 
        // bindingSourceHostFile
        // 
        bindingSourceHostFile.DataSource = typeof(HostsFile);
        // 
        // labelHostEntries
        // 
        labelHostEntries.Name = "labelHostEntries";
        resources.ApplyResources(labelHostEntries, "labelHostEntries");
        // 
        // labelHostEntriesCount
        // 
        labelHostEntriesCount.DataBindings.Add(new Binding("Text", bindingSourceHostFile, "EnabledCount", true));
        labelHostEntriesCount.Name = "labelHostEntriesCount";
        resources.ApplyResources(labelHostEntriesCount, "labelHostEntriesCount");
        // 
        // splitContainer
        // 
        resources.ApplyResources(splitContainer, "splitContainer");
        splitContainer.FixedPanel = FixedPanel.Panel2;
        splitContainer.Name = "splitContainer";
        // 
        // splitContainer.Panel1
        // 
        splitContainer.Panel1.Controls.Add(dataGridViewHostsEntries);
        // 
        // splitContainer.Panel2
        // 
        splitContainer.Panel2.Controls.Add(dataGridViewArchive);
        splitContainer.Panel2.Controls.Add(toolStripArchive);
        // 
        // dataGridViewHostsEntries
        // 
        dataGridViewHostsEntries.AllowDrop = true;
        dataGridViewHostsEntries.AllowUserToOrderColumns = true;
        dataGridViewHostsEntries.AllowUserToResizeRows = false;
        dataGridViewHostsEntries.AutoGenerateColumns = false;
        dataGridViewHostsEntries.BorderStyle = BorderStyle.None;
        dataGridViewHostsEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewHostsEntries.Columns.AddRange(new DataGridViewColumn[] { columnValid, columnEnabled, columnIpAddress, columnHostnames, columnComment, columnUnparsedText, columnFiller });
        dataGridViewHostsEntries.ContextMenuStrip = contextMenuGrid;
        dataGridViewHostsEntries.DataSource = bindingSourceView;
        resources.ApplyResources(dataGridViewHostsEntries, "dataGridViewHostsEntries");
        dataGridViewHostsEntries.Name = "dataGridViewHostsEntries";
        // 
        // columnValid
        // 
        columnValid.DataPropertyName = "Valid";
        resources.ApplyResources(columnValid, "columnValid");
        columnValid.Name = "columnValid";
        columnValid.ReadOnly = true;
        columnValid.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // columnEnabled
        // 
        columnEnabled.DataPropertyName = "Enabled";
        resources.ApplyResources(columnEnabled, "columnEnabled");
        columnEnabled.Name = "columnEnabled";
        columnEnabled.SortMode = DataGridViewColumnSortMode.Automatic;
        // 
        // columnIpAddress
        // 
        columnIpAddress.DataPropertyName = "IpAddress";
        resources.ApplyResources(columnIpAddress, "columnIpAddress");
        columnIpAddress.Name = "columnIpAddress";
        // 
        // columnHostnames
        // 
        columnHostnames.DataPropertyName = "HostNames";
        resources.ApplyResources(columnHostnames, "columnHostnames");
        columnHostnames.Name = "columnHostnames";
        // 
        // columnComment
        // 
        columnComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        columnComment.DataPropertyName = "Comment";
        resources.ApplyResources(columnComment, "columnComment");
        columnComment.Name = "columnComment";
        // 
        // columnUnparsedText
        // 
        columnUnparsedText.DataPropertyName = "UnparsedText";
        resources.ApplyResources(columnUnparsedText, "columnUnparsedText");
        columnUnparsedText.Name = "columnUnparsedText";
        columnUnparsedText.ReadOnly = true;
        // 
        // columnFiller
        // 
        columnFiller.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        resources.ApplyResources(columnFiller, "columnFiller");
        columnFiller.Name = "columnFiller";
        columnFiller.ReadOnly = true;
        // 
        // contextMenuGrid
        // 
        contextMenuGrid.Items.AddRange(new ToolStripItem[] { menuContextCut, menuContextCopy, menuContextPaste, toolStripSeparator32, menuContextDuplicate, toolStripSeparator22, menuContextDelete, toolStripSeparator23, menuContextMoveUp, menuContextMoveDown, toolStripSeparator25, menuContextInsertAbove, menuContextInsertBelow, toolStripSeparator31, contextMenuCheck, contextMenuUncheck });
        contextMenuGrid.Name = "contextMenuGrid";
        resources.ApplyResources(contextMenuGrid, "contextMenuGrid");
        // 
        // menuContextCut
        // 
        menuContextCut.Image = Properties.Resources.Cut;
        menuContextCut.Name = "menuContextCut";
        resources.ApplyResources(menuContextCut, "menuContextCut");
        menuContextCut.Click += OnCutClick;
        // 
        // menuContextCopy
        // 
        menuContextCopy.Image = Properties.Resources.Copy;
        menuContextCopy.Name = "menuContextCopy";
        resources.ApplyResources(menuContextCopy, "menuContextCopy");
        menuContextCopy.Click += OnCopyClick;
        // 
        // menuContextPaste
        // 
        menuContextPaste.Image = Properties.Resources.Paste;
        menuContextPaste.Name = "menuContextPaste";
        resources.ApplyResources(menuContextPaste, "menuContextPaste");
        menuContextPaste.Click += OnPasteClick;
        // 
        // toolStripSeparator32
        // 
        toolStripSeparator32.Name = "toolStripSeparator32";
        resources.ApplyResources(toolStripSeparator32, "toolStripSeparator32");
        // 
        // menuContextDuplicate
        // 
        menuContextDuplicate.Image = Properties.Resources.Duplicate;
        menuContextDuplicate.Name = "menuContextDuplicate";
        resources.ApplyResources(menuContextDuplicate, "menuContextDuplicate");
        menuContextDuplicate.Click += OnDuplicateClick;
        // 
        // toolStripSeparator22
        // 
        toolStripSeparator22.Name = "toolStripSeparator22";
        resources.ApplyResources(toolStripSeparator22, "toolStripSeparator22");
        // 
        // menuContextDelete
        // 
        menuContextDelete.Image = Properties.Resources.Delete;
        menuContextDelete.Name = "menuContextDelete";
        resources.ApplyResources(menuContextDelete, "menuContextDelete");
        menuContextDelete.Click += OnDeleteClick;
        // 
        // toolStripSeparator23
        // 
        toolStripSeparator23.Name = "toolStripSeparator23";
        resources.ApplyResources(toolStripSeparator23, "toolStripSeparator23");
        // 
        // menuContextMoveUp
        // 
        menuContextMoveUp.Image = Properties.Resources.MoveUp;
        menuContextMoveUp.Name = "menuContextMoveUp";
        resources.ApplyResources(menuContextMoveUp, "menuContextMoveUp");
        menuContextMoveUp.Click += OnMoveUpClick;
        // 
        // menuContextMoveDown
        // 
        menuContextMoveDown.Image = Properties.Resources.MoveDown;
        menuContextMoveDown.Name = "menuContextMoveDown";
        resources.ApplyResources(menuContextMoveDown, "menuContextMoveDown");
        menuContextMoveDown.Click += OnMoveDownClick;
        // 
        // toolStripSeparator25
        // 
        toolStripSeparator25.Name = "toolStripSeparator25";
        resources.ApplyResources(toolStripSeparator25, "toolStripSeparator25");
        // 
        // menuContextInsertAbove
        // 
        menuContextInsertAbove.Image = Properties.Resources.InsertAbove;
        menuContextInsertAbove.Name = "menuContextInsertAbove";
        resources.ApplyResources(menuContextInsertAbove, "menuContextInsertAbove");
        menuContextInsertAbove.Click += OnInsertAboveClick;
        // 
        // menuContextInsertBelow
        // 
        menuContextInsertBelow.Image = Properties.Resources.InsertBelow;
        menuContextInsertBelow.Name = "menuContextInsertBelow";
        resources.ApplyResources(menuContextInsertBelow, "menuContextInsertBelow");
        menuContextInsertBelow.Click += OnInsertBelowClick;
        // 
        // toolStripSeparator31
        // 
        toolStripSeparator31.Name = "toolStripSeparator31";
        resources.ApplyResources(toolStripSeparator31, "toolStripSeparator31");
        // 
        // contextMenuCheck
        // 
        contextMenuCheck.Image = Properties.Resources.Check;
        resources.ApplyResources(contextMenuCheck, "contextMenuCheck");
        contextMenuCheck.Name = "contextMenuCheck";
        contextMenuCheck.Click += OnCheckClick;
        // 
        // contextMenuUncheck
        // 
        contextMenuUncheck.Image = Properties.Resources.Uncheck;
        resources.ApplyResources(contextMenuUncheck, "contextMenuUncheck");
        contextMenuUncheck.Name = "contextMenuUncheck";
        contextMenuUncheck.Click += OnUncheckClick;
        // 
        // bindingSourceView
        // 
        bindingSourceView.DataSource = typeof(HostsEntryList);
        // 
        // dataGridViewArchive
        // 
        dataGridViewArchive.AllowUserToAddRows = false;
        dataGridViewArchive.AllowUserToDeleteRows = false;
        dataGridViewArchive.AllowUserToResizeColumns = false;
        dataGridViewArchive.AllowUserToResizeRows = false;
        dataGridViewArchive.AutoGenerateColumns = false;
        dataGridViewArchive.BackgroundColor = Color.White;
        dataGridViewArchive.BorderStyle = BorderStyle.None;
        dataGridViewArchive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewArchive.ColumnHeadersVisible = false;
        dataGridViewArchive.Columns.AddRange(new DataGridViewColumn[] { fileNameDataGridViewTextBoxColumn });
        dataGridViewArchive.DataSource = bindingSourceArchive;
        resources.ApplyResources(dataGridViewArchive, "dataGridViewArchive");
        dataGridViewArchive.GridColor = Color.White;
        dataGridViewArchive.MultiSelect = false;
        dataGridViewArchive.Name = "dataGridViewArchive";
        dataGridViewArchive.ReadOnly = true;
        dataGridViewArchive.RowHeadersVisible = false;
        dataGridViewArchive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        // 
        // fileNameDataGridViewTextBoxColumn
        // 
        fileNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
        resources.ApplyResources(fileNameDataGridViewTextBoxColumn, "fileNameDataGridViewTextBoxColumn");
        fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
        fileNameDataGridViewTextBoxColumn.ReadOnly = true;
        // 
        // bindingSourceArchive
        // 
        bindingSourceArchive.AllowNew = false;
        bindingSourceArchive.DataSource = typeof(HostsArchiveList);
        // 
        // toolStripArchive
        // 
        toolStripArchive.ClickThrough = true;
        toolStripArchive.GripStyle = ToolStripGripStyle.Hidden;
        toolStripArchive.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator27, buttonDeleteArchive, buttonLoadArchive });
        resources.ApplyResources(toolStripArchive, "toolStripArchive");
        toolStripArchive.Name = "toolStripArchive";
        // 
        // toolStripLabel1
        // 
        toolStripLabel1.Name = "toolStripLabel1";
        resources.ApplyResources(toolStripLabel1, "toolStripLabel1");
        // 
        // toolStripSeparator27
        // 
        toolStripSeparator27.Name = "toolStripSeparator27";
        resources.ApplyResources(toolStripSeparator27, "toolStripSeparator27");
        // 
        // buttonDeleteArchive
        // 
        buttonDeleteArchive.Alignment = ToolStripItemAlignment.Right;
        buttonDeleteArchive.DisplayStyle = ToolStripItemDisplayStyle.Image;
        buttonDeleteArchive.Image = Properties.Resources.Delete;
        resources.ApplyResources(buttonDeleteArchive, "buttonDeleteArchive");
        buttonDeleteArchive.Name = "buttonDeleteArchive";
        buttonDeleteArchive.Click += OnArchiveDeleteClick;
        // 
        // buttonLoadArchive
        // 
        buttonLoadArchive.Alignment = ToolStripItemAlignment.Right;
        buttonLoadArchive.DisplayStyle = ToolStripItemDisplayStyle.Image;
        buttonLoadArchive.Image = Properties.Resources.LoadArchive;
        resources.ApplyResources(buttonLoadArchive, "buttonLoadArchive");
        buttonLoadArchive.Name = "buttonLoadArchive";
        buttonLoadArchive.Click += OnArchiveLoadClick;
        // 
        // menuStrip
        // 
        menuStrip.ClickThrough = true;
        resources.ApplyResources(menuStrip, "menuStrip");
        menuStrip.Items.AddRange(new ToolStripItem[] { menuFile, editToolStripMenuItem, viewToolStripMenuItem, menuTools, helpToolStripMenuItem });
        menuStrip.Name = "menuStrip";
        // 
        // menuFile
        // 
        menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuSave, menuSaveAs, toolStripSeparator18, menuArchive, toolStripSeparator14, openTextEditor, menuRestoreDefaults, menuDisable, toolStripSeparator13, menuImport, toolStripSeparator12, menuExit });
        menuFile.Name = "menuFile";
        resources.ApplyResources(menuFile, "menuFile");
        // 
        // menuSave
        // 
        menuSave.Image = Properties.Resources.Save;
        menuSave.Name = "menuSave";
        resources.ApplyResources(menuSave, "menuSave");
        menuSave.Click += OnSaveClick;
        // 
        // menuSaveAs
        // 
        menuSaveAs.Name = "menuSaveAs";
        resources.ApplyResources(menuSaveAs, "menuSaveAs");
        menuSaveAs.Click += OnSaveAsClick;
        // 
        // toolStripSeparator18
        // 
        toolStripSeparator18.Name = "toolStripSeparator18";
        resources.ApplyResources(toolStripSeparator18, "toolStripSeparator18");
        // 
        // menuArchive
        // 
        menuArchive.Image = Properties.Resources.Archive;
        menuArchive.Name = "menuArchive";
        resources.ApplyResources(menuArchive, "menuArchive");
        menuArchive.Click += OnArchiveClick;
        // 
        // toolStripSeparator14
        // 
        toolStripSeparator14.Name = "toolStripSeparator14";
        resources.ApplyResources(toolStripSeparator14, "toolStripSeparator14");
        // 
        // openTextEditor
        // 
        openTextEditor.Name = "openTextEditor";
        resources.ApplyResources(openTextEditor, "openTextEditor");
        openTextEditor.Click += OnOpenTextEditorClick;
        // 
        // menuRestoreDefaults
        // 
        menuRestoreDefaults.Name = "menuRestoreDefaults";
        resources.ApplyResources(menuRestoreDefaults, "menuRestoreDefaults");
        menuRestoreDefaults.Click += OnRestoreClick;
        // 
        // menuDisable
        // 
        menuDisable.Image = Properties.Resources.Disable;
        menuDisable.Name = "menuDisable";
        resources.ApplyResources(menuDisable, "menuDisable");
        menuDisable.Click += OnDisableHostsClick;
        // 
        // toolStripSeparator13
        // 
        toolStripSeparator13.Name = "toolStripSeparator13";
        resources.ApplyResources(toolStripSeparator13, "toolStripSeparator13");
        // 
        // menuImport
        // 
        menuImport.Image = Properties.Resources.Import;
        menuImport.Name = "menuImport";
        resources.ApplyResources(menuImport, "menuImport");
        menuImport.Click += OnImportClick;
        // 
        // toolStripSeparator12
        // 
        toolStripSeparator12.Name = "toolStripSeparator12";
        resources.ApplyResources(toolStripSeparator12, "toolStripSeparator12");
        // 
        // menuExit
        // 
        menuExit.Name = "menuExit";
        resources.ApplyResources(menuExit, "menuExit");
        menuExit.Click += OnExitClick;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuRefresh, toolStripSeparator28, menuUndo, menuRedo, toolStripSeparator4, menuCut, menuCopy, menuPaste, toolStripSeparator33, menuDuplicate, toolStripSeparator5, menuDelete, toolStripSeparator6, menuMoveUp, menuMoveDown, toolStripSeparator24, insertRowAboveToolStripMenuItem, insertRowBelowToolStripMenuItem, toolStripSeparator30, menuCheck, menuUncheck });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        resources.ApplyResources(editToolStripMenuItem, "editToolStripMenuItem");
        // 
        // menuRefresh
        // 
        menuRefresh.Image = Properties.Resources.Refresh;
        resources.ApplyResources(menuRefresh, "menuRefresh");
        menuRefresh.Name = "menuRefresh";
        menuRefresh.Click += OnRefreshClick;
        // 
        // toolStripSeparator28
        // 
        toolStripSeparator28.Name = "toolStripSeparator28";
        resources.ApplyResources(toolStripSeparator28, "toolStripSeparator28");
        // 
        // menuUndo
        // 
        menuUndo.Image = Properties.Resources.Undo;
        menuUndo.Name = "menuUndo";
        resources.ApplyResources(menuUndo, "menuUndo");
        menuUndo.Click += OnUndoClick;
        // 
        // menuRedo
        // 
        menuRedo.Image = Properties.Resources.Redo;
        menuRedo.Name = "menuRedo";
        resources.ApplyResources(menuRedo, "menuRedo");
        menuRedo.Click += OnRedoClick;
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        resources.ApplyResources(toolStripSeparator4, "toolStripSeparator4");
        // 
        // menuCut
        // 
        menuCut.Image = Properties.Resources.Cut;
        menuCut.Name = "menuCut";
        resources.ApplyResources(menuCut, "menuCut");
        menuCut.Click += OnCutClick;
        // 
        // menuCopy
        // 
        menuCopy.Image = Properties.Resources.Copy;
        menuCopy.Name = "menuCopy";
        resources.ApplyResources(menuCopy, "menuCopy");
        menuCopy.Click += OnCopyClick;
        // 
        // menuPaste
        // 
        menuPaste.Image = Properties.Resources.Paste;
        menuPaste.Name = "menuPaste";
        resources.ApplyResources(menuPaste, "menuPaste");
        menuPaste.Click += OnPasteClick;
        // 
        // toolStripSeparator33
        // 
        toolStripSeparator33.Name = "toolStripSeparator33";
        resources.ApplyResources(toolStripSeparator33, "toolStripSeparator33");
        // 
        // menuDuplicate
        // 
        menuDuplicate.Image = Properties.Resources.Duplicate;
        menuDuplicate.Name = "menuDuplicate";
        resources.ApplyResources(menuDuplicate, "menuDuplicate");
        menuDuplicate.Click += OnDuplicateClick;
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        resources.ApplyResources(toolStripSeparator5, "toolStripSeparator5");
        // 
        // menuDelete
        // 
        menuDelete.Image = Properties.Resources.Delete;
        menuDelete.Name = "menuDelete";
        resources.ApplyResources(menuDelete, "menuDelete");
        menuDelete.Click += OnDeleteClick;
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        resources.ApplyResources(toolStripSeparator6, "toolStripSeparator6");
        // 
        // menuMoveUp
        // 
        menuMoveUp.Image = Properties.Resources.MoveUp;
        menuMoveUp.Name = "menuMoveUp";
        resources.ApplyResources(menuMoveUp, "menuMoveUp");
        menuMoveUp.Click += OnMoveUpClick;
        // 
        // menuMoveDown
        // 
        menuMoveDown.Image = Properties.Resources.MoveDown;
        menuMoveDown.Name = "menuMoveDown";
        resources.ApplyResources(menuMoveDown, "menuMoveDown");
        menuMoveDown.Click += OnMoveDownClick;
        // 
        // toolStripSeparator24
        // 
        toolStripSeparator24.Name = "toolStripSeparator24";
        resources.ApplyResources(toolStripSeparator24, "toolStripSeparator24");
        // 
        // insertRowAboveToolStripMenuItem
        // 
        insertRowAboveToolStripMenuItem.Image = Properties.Resources.InsertAbove;
        insertRowAboveToolStripMenuItem.Name = "insertRowAboveToolStripMenuItem";
        resources.ApplyResources(insertRowAboveToolStripMenuItem, "insertRowAboveToolStripMenuItem");
        insertRowAboveToolStripMenuItem.Click += OnInsertAboveClick;
        // 
        // insertRowBelowToolStripMenuItem
        // 
        insertRowBelowToolStripMenuItem.Image = Properties.Resources.InsertBelow;
        insertRowBelowToolStripMenuItem.Name = "insertRowBelowToolStripMenuItem";
        resources.ApplyResources(insertRowBelowToolStripMenuItem, "insertRowBelowToolStripMenuItem");
        insertRowBelowToolStripMenuItem.Click += OnInsertBelowClick;
        // 
        // toolStripSeparator30
        // 
        toolStripSeparator30.Name = "toolStripSeparator30";
        resources.ApplyResources(toolStripSeparator30, "toolStripSeparator30");
        // 
        // menuCheck
        // 
        menuCheck.Image = Properties.Resources.Check;
        resources.ApplyResources(menuCheck, "menuCheck");
        menuCheck.Name = "menuCheck";
        menuCheck.Click += OnCheckClick;
        // 
        // menuUncheck
        // 
        menuUncheck.Image = Properties.Resources.Uncheck;
        resources.ApplyResources(menuUncheck, "menuUncheck");
        menuUncheck.Name = "menuUncheck";
        menuUncheck.Click += OnUncheckClick;
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuViewArchive, toolStripSeparator9, menuFilter, toolStripSeparator29, menuRemoveSort });
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
        // 
        // menuViewArchive
        // 
        menuViewArchive.Image = Properties.Resources.ViewArchive;
        menuViewArchive.Name = "menuViewArchive";
        resources.ApplyResources(menuViewArchive, "menuViewArchive");
        menuViewArchive.Click += OnViewArchiveClick;
        // 
        // toolStripSeparator9
        // 
        toolStripSeparator9.Name = "toolStripSeparator9";
        resources.ApplyResources(toolStripSeparator9, "toolStripSeparator9");
        // 
        // menuFilter
        // 
        menuFilter.DropDownItems.AddRange(new ToolStripItem[] { menuFilterComments, menuFilterDisabled });
        menuFilter.Image = Properties.Resources.Filter;
        menuFilter.Name = "menuFilter";
        resources.ApplyResources(menuFilter, "menuFilter");
        // 
        // menuFilterComments
        // 
        menuFilterComments.Image = Properties.Resources.FilterComments;
        menuFilterComments.Name = "menuFilterComments";
        resources.ApplyResources(menuFilterComments, "menuFilterComments");
        menuFilterComments.Click += OnFilterCommentClick;
        // 
        // menuFilterDisabled
        // 
        menuFilterDisabled.Image = Properties.Resources.FilterDisabled;
        menuFilterDisabled.Name = "menuFilterDisabled";
        resources.ApplyResources(menuFilterDisabled, "menuFilterDisabled");
        menuFilterDisabled.Click += OnFilterDisabledClick;
        // 
        // toolStripSeparator29
        // 
        toolStripSeparator29.Name = "toolStripSeparator29";
        resources.ApplyResources(toolStripSeparator29, "toolStripSeparator29");
        // 
        // menuRemoveSort
        // 
        menuRemoveSort.Name = "menuRemoveSort";
        resources.ApplyResources(menuRemoveSort, "menuRemoveSort");
        menuRemoveSort.Click += OnRemoveSortClick;
        // 
        // menuTools
        // 
        menuTools.DropDownItems.AddRange(new ToolStripItem[] { menuPingIPs, menuRemoveDefaultText });
        menuTools.Name = "menuTools";
        resources.ApplyResources(menuTools, "menuTools");
        // 
        // menuPingIPs
        // 
        menuPingIPs.Name = "menuPingIPs";
        resources.ApplyResources(menuPingIPs, "menuPingIPs");
        menuPingIPs.Click += OnPingIPsClick;
        // 
        // menuRemoveDefaultText
        // 
        menuRemoveDefaultText.CheckState = CheckState.Checked;
        menuRemoveDefaultText.Checked = true;
        menuRemoveDefaultText.Name = "menuRemoveDefaultText";
        resources.ApplyResources(menuRemoveDefaultText, "menuRemoveDefaultText");
        menuRemoveDefaultText.Click += OnRemoveDefaultTextClick;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        resources.ApplyResources(helpToolStripMenuItem, "helpToolStripMenuItem");
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        resources.ApplyResources(aboutToolStripMenuItem, "aboutToolStripMenuItem");
        aboutToolStripMenuItem.Click += OnAboutClick;
        // 
        // toolStrip
        // 
        toolStrip.ClickThrough = true;
        resources.ApplyResources(toolStrip, "toolStrip");
        toolStrip.GripStyle = ToolStripGripStyle.Hidden;
        toolStrip.Items.AddRange(new ToolStripItem[] { buttonSave, toolStripSeparator15, buttonRefresh, toolStripSeparator26, buttonDisable, toolStripSeparator16, buttonArchive, buttonViewArchive, toolStripSeparator17, toolStripDropDownButton1, buttonFilterComment, buttonFilterDisabled, textFilter, toolStripSeparator19 });
        toolStrip.Name = "toolStrip";
        toolStrip.Stretch = true;
        toolStrip.TextChanged += OnFilterTextChanged;
        // 
        // buttonSave
        // 
        buttonSave.Image = Properties.Resources.Save;
        resources.ApplyResources(buttonSave, "buttonSave");
        buttonSave.Margin = new Padding(2, 1, 0, 2);
        buttonSave.Name = "buttonSave";
        buttonSave.Click += OnSaveClick;
        // 
        // toolStripSeparator15
        // 
        toolStripSeparator15.Name = "toolStripSeparator15";
        resources.ApplyResources(toolStripSeparator15, "toolStripSeparator15");
        // 
        // buttonRefresh
        // 
        buttonRefresh.Image = Properties.Resources.Refresh;
        resources.ApplyResources(buttonRefresh, "buttonRefresh");
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Click += OnRefreshClick;
        // 
        // toolStripSeparator26
        // 
        toolStripSeparator26.Name = "toolStripSeparator26";
        resources.ApplyResources(toolStripSeparator26, "toolStripSeparator26");
        // 
        // buttonDisable
        // 
        buttonDisable.Image = Properties.Resources.Disable;
        resources.ApplyResources(buttonDisable, "buttonDisable");
        buttonDisable.Name = "buttonDisable";
        buttonDisable.Click += OnDisableHostsClick;
        // 
        // toolStripSeparator16
        // 
        toolStripSeparator16.Name = "toolStripSeparator16";
        resources.ApplyResources(toolStripSeparator16, "toolStripSeparator16");
        // 
        // buttonArchive
        // 
        buttonArchive.Image = Properties.Resources.Archive;
        resources.ApplyResources(buttonArchive, "buttonArchive");
        buttonArchive.Name = "buttonArchive";
        buttonArchive.Click += OnArchiveClick;
        // 
        // buttonViewArchive
        // 
        buttonViewArchive.Image = Properties.Resources.ViewArchive;
        resources.ApplyResources(buttonViewArchive, "buttonViewArchive");
        buttonViewArchive.Name = "buttonViewArchive";
        buttonViewArchive.Click += OnViewArchiveClick;
        // 
        // toolStripSeparator17
        // 
        toolStripSeparator17.Name = "toolStripSeparator17";
        resources.ApplyResources(toolStripSeparator17, "toolStripSeparator17");
        // 
        // toolStripDropDownButton1
        // 
        toolStripDropDownButton1.Image = Properties.Resources.Filter;
        resources.ApplyResources(toolStripDropDownButton1, "toolStripDropDownButton1");
        toolStripDropDownButton1.Name = "toolStripDropDownButton1";
        // 
        // buttonFilterComment
        // 
        buttonFilterComment.DisplayStyle = ToolStripItemDisplayStyle.Image;
        buttonFilterComment.Image = Properties.Resources.FilterComments;
        buttonFilterComment.Name = "buttonFilterComment";
        resources.ApplyResources(buttonFilterComment, "buttonFilterComment");
        buttonFilterComment.Click += OnFilterCommentClick;
        // 
        // buttonFilterDisabled
        // 
        buttonFilterDisabled.DisplayStyle = ToolStripItemDisplayStyle.Image;
        buttonFilterDisabled.Image = Properties.Resources.FilterDisabled;
        buttonFilterDisabled.Name = "buttonFilterDisabled";
        resources.ApplyResources(buttonFilterDisabled, "buttonFilterDisabled");
        buttonFilterDisabled.Click += OnFilterDisabledClick;
        // 
        // textFilter
        // 
        textFilter.Name = "textFilter";
        resources.ApplyResources(textFilter, "textFilter");
        textFilter.TextChanged += OnFilterTextChanged;
        // 
        // toolStripSeparator19
        // 
        toolStripSeparator19.Name = "toolStripSeparator19";
        resources.ApplyResources(toolStripSeparator19, "toolStripSeparator19");
        // 
        // toolStripSeparator21
        // 
        toolStripSeparator21.Name = "toolStripSeparator21";
        resources.ApplyResources(toolStripSeparator21, "toolStripSeparator21");
        // 
        // toolStripSeparator20
        // 
        toolStripSeparator20.Name = "toolStripSeparator20";
        resources.ApplyResources(toolStripSeparator20, "toolStripSeparator20");
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        resources.ApplyResources(toolStripSeparator1, "toolStripSeparator1");
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
        // 
        // toolStripSeparator7
        // 
        toolStripSeparator7.Name = "toolStripSeparator7";
        resources.ApplyResources(toolStripSeparator7, "toolStripSeparator7");
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        resources.ApplyResources(toolStripSeparator, "toolStripSeparator");
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        resources.ApplyResources(toolStripSeparator3, "toolStripSeparator3");
        // 
        // toolStripSeparator8
        // 
        toolStripSeparator8.Name = "toolStripSeparator8";
        resources.ApplyResources(toolStripSeparator8, "toolStripSeparator8");
        // 
        // toolStripSeparator10
        // 
        toolStripSeparator10.Name = "toolStripSeparator10";
        resources.ApplyResources(toolStripSeparator10, "toolStripSeparator10");
        // 
        // toolStripSeparator11
        // 
        toolStripSeparator11.Name = "toolStripSeparator11";
        resources.ApplyResources(toolStripSeparator11, "toolStripSeparator11");
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        resources.ApplyResources(toolStripMenuItem1, "toolStripMenuItem1");
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        resources.ApplyResources(toolStripStatusLabel1, "toolStripStatusLabel1");
        // 
        // toolStripButton1
        // 
        toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        resources.ApplyResources(toolStripButton1, "toolStripButton1");
        toolStripButton1.Name = "toolStripButton1";
        // 
        // saveFileDialog
        // 
        saveFileDialog.FileName = "hosts";
        resources.ApplyResources(saveFileDialog, "saveFileDialog");
        saveFileDialog.InitialDirectory = "C:\\Windows\\System32\\drivers\\etc";
        // 
        // notifyIcon
        // 
        notifyIcon.ContextMenuStrip = contextMenuTray;
        resources.ApplyResources(notifyIcon, "notifyIcon");
        notifyIcon.DoubleClick += OnNotifyIconDoubleClick;
        // 
        // contextMenuTray
        // 
        contextMenuTray.Items.AddRange(new ToolStripItem[] { menuContextEdit, toolStripSeparator21, menuContextDisable, toolStripSeparator20, contextMenuExit });
        contextMenuTray.Name = "contextMenuTray";
        resources.ApplyResources(contextMenuTray, "contextMenuTray");
        // 
        // menuContextEdit
        // 
        menuContextEdit.Name = "menuContextEdit";
        resources.ApplyResources(menuContextEdit, "menuContextEdit");
        menuContextEdit.Click += OnEditClick;
        // 
        // menuContextDisable
        // 
        menuContextDisable.Image = Properties.Resources.Disable;
        menuContextDisable.Name = "menuContextDisable";
        resources.ApplyResources(menuContextDisable, "menuContextDisable");
        menuContextDisable.Click += OnDisableHostsClick;
        // 
        // contextMenuExit
        // 
        contextMenuExit.Name = "contextMenuExit";
        resources.ApplyResources(contextMenuExit, "contextMenuExit");
        contextMenuExit.Click += OnExitClick;
        // 
        // openFileDialog
        // 
        openFileDialog.FileName = "hosts";
        resources.ApplyResources(openFileDialog, "openFileDialog");
        // 
        // bindingSourceHostEntries
        // 
        bindingSourceHostEntries.DataSource = typeof(HostsEntryList);
        // 
        // MainForm
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(toolStripContainer);
        MainMenuStrip = menuStrip;
        MaximizeBox = false;
        Name = "MainForm";
        ShowInTaskbar = false;
        FormClosing += OnFormClosing;
        Load += OnFomLoad;
        Shown += OnFormShown;
        ResizeEnd += OnResizingEnd;
        VisibleChanged += OnVisibleChanged;
        toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
        toolStripContainer.BottomToolStripPanel.PerformLayout();
        toolStripContainer.ContentPanel.ResumeLayout(false);
        toolStripContainer.TopToolStripPanel.ResumeLayout(false);
        toolStripContainer.TopToolStripPanel.PerformLayout();
        toolStripContainer.ResumeLayout(false);
        toolStripContainer.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)bindingSourceHostFile).EndInit();
        splitContainer.Panel1.ResumeLayout(false);
        splitContainer.Panel2.ResumeLayout(false);
        splitContainer.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
        splitContainer.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewHostsEntries).EndInit();
        contextMenuGrid.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)bindingSourceView).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewArchive).EndInit();
        ((System.ComponentModel.ISupportInitialize)bindingSourceArchive).EndInit();
        toolStripArchive.ResumeLayout(false);
        toolStripArchive.PerformLayout();
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        toolStrip.ResumeLayout(false);
        toolStrip.PerformLayout();
        contextMenuTray.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)bindingSourceHostEntries).EndInit();
        ResumeLayout(false);

    }

    private System.Windows.Forms.ToolStripContainer toolStripContainer;
    private HostsFileEditor.Controls.MenuStripEx menuStrip;
    private System.Windows.Forms.ToolStripMenuItem menuFile;
    private System.Windows.Forms.ToolStripMenuItem menuSave;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem menuExit;
    private HostsFileEditor.Controls.HostsEntryDataGridView dataGridViewHostsEntries;
    private System.Windows.Forms.BindingSource bindingSourceView;
    private System.Windows.Forms.ToolStripMenuItem menuRestoreDefaults;
    private HostsFileEditor.Controls.ToolStripEx toolStrip;
    private System.Windows.Forms.ToolStripButton buttonSave;
    private System.Windows.Forms.ToolStripButton buttonDisable;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel labelHostEntries;
    private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem menuDisable;
    private System.Windows.Forms.ToolStripMenuItem menuImport;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuUndo;
    private System.Windows.Forms.ToolStripMenuItem menuRedo;
    private System.Windows.Forms.ToolStripMenuItem menuCut;
    private System.Windows.Forms.ToolStripMenuItem menuCopy;
    private System.Windows.Forms.ToolStripMenuItem menuPaste;
    private System.Windows.Forms.ToolStripMenuItem menuDelete;
    private System.Windows.Forms.ToolStripMenuItem menuDuplicate;
    private System.Windows.Forms.ToolStripMenuItem menuMoveUp;
    private System.Windows.Forms.ToolStripMenuItem menuMoveDown;
    private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem menuViewArchive;
    private System.Windows.Forms.ToolStripMenuItem menuArchive;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    private System.Windows.Forms.ToolStripMenuItem menuFilterComments;
    private System.Windows.Forms.ToolStripMenuItem menuFilterDisabled;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
    private HostsFileEditor.Controls.ToolStripSpringTextBox textFilter;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private HostsFileEditor.Controls.ToolStripBindableStatusLabel labelHostEntriesCount;
    private System.Windows.Forms.BindingSource bindingSourceHostEntries;
    private System.Windows.Forms.ToolStripLabel toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripButton buttonFilterComment;
    private System.Windows.Forms.ToolStripButton buttonFilterDisabled;
    private System.Windows.Forms.DataGridViewCheckBoxColumn columnValid;
    private System.Windows.Forms.DataGridViewCheckBoxColumn columnEnabled;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnIpAddress;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnHostnames;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnComment;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUnparsedText;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnFiller;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.ContextMenuStrip contextMenuTray;
    private System.Windows.Forms.ToolStripMenuItem menuContextDisable;
    private System.Windows.Forms.ToolStripMenuItem contextMenuExit;
    private System.Windows.Forms.ToolStripMenuItem menuContextEdit;
    private System.Windows.Forms.ToolStripStatusLabel labelLineCount;
    private HostsFileEditor.Controls.ToolStripBindableStatusLabel labelLineCountNumber;
    private System.Windows.Forms.BindingSource bindingSourceHostFile;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolStripMenuItem insertRowAboveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem insertRowBelowToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuGrid;
    private System.Windows.Forms.ToolStripMenuItem menuContextCut;
    private System.Windows.Forms.ToolStripMenuItem menuContextCopy;
    private System.Windows.Forms.ToolStripMenuItem menuContextPaste;
    private System.Windows.Forms.ToolStripMenuItem menuContextDelete;
    private System.Windows.Forms.ToolStripMenuItem menuContextDuplicate;
    private System.Windows.Forms.ToolStripMenuItem menuContextMoveUp;
    private System.Windows.Forms.ToolStripMenuItem menuContextMoveDown;
    private System.Windows.Forms.ToolStripMenuItem menuContextInsertAbove;
    private System.Windows.Forms.ToolStripMenuItem menuContextInsertBelow;
    private System.Windows.Forms.ToolStripMenuItem menuRefresh;
    private System.Windows.Forms.ToolStripButton buttonRefresh;
    private System.Windows.Forms.ToolStripMenuItem menuTools;
    private System.Windows.Forms.ToolStripMenuItem menuPingIPs;
    private System.Windows.Forms.ToolStripButton buttonViewArchive;
    private System.Windows.Forms.SplitContainer splitContainer;
    private HostsFileEditor.Controls.ToolStripEx toolStripArchive;
    private System.Windows.Forms.ToolStripButton buttonDeleteArchive;
    private HostsFileEditor.Controls.HostsArchiveDataGridView dataGridViewArchive;
    private System.Windows.Forms.ToolStripButton buttonLoadArchive;
    private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource bindingSourceArchive;
    private System.Windows.Forms.ToolStripButton buttonArchive;
    private System.Windows.Forms.ToolStripMenuItem menuRemoveDefaultText;

    #endregion
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator29;
    private System.Windows.Forms.ToolStripMenuItem menuRemoveSort;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator30;
    private System.Windows.Forms.ToolStripMenuItem menuCheck;
    private System.Windows.Forms.ToolStripMenuItem menuUncheck;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator31;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator32;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator33;
    private System.Windows.Forms.ToolStripMenuItem contextMenuCheck;
    private System.Windows.Forms.ToolStripMenuItem contextMenuUncheck;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openTextEditor;
}

