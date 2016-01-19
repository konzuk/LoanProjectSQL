﻿using System;
using System.Windows.Forms;
using Framework.Interfaces.App.resolve;

namespace Framework.Base.App.resolve
{
    public partial class KZPDFViewer : Form, IKZPDFViewer
    {
        public string Document;

        public KZPDFViewer()
        {
            InitializeComponent();
            Load += KZPDFViewer_Load;
            FormClosing += KZPDFViewer_FormClosing;
        }

        private void KZPDFViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            pdfViewer1.CloseDocument();
        }

        private void KZPDFViewer_Load(object sender, EventArgs e)
        {
            pdfViewer1.LoadDocument(Document);
        }
    }
}