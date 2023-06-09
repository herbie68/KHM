﻿using System.ComponentModel;
using System.IO;

namespace KHM.Helpers
{
    public class PdfReport : INotifyPropertyChanged
    {
        private Stream docStream;
        public event PropertyChangedEventHandler PropertyChanged;

        public Stream DocumentStream
        {
            get
            {
                return docStream;
            }
            set
            {
                docStream = value;
                OnPropertyChanged ( new PropertyChangedEventArgs ( "DocumentStream" ) );
            }
        }

        public PdfReport ( )
        {
            //Load the stream from the local system.
            docStream = new FileStream ( @"C:\Users\herbert.nijkamp\OneDrive - Wolters Kluwer\Downloads\!Examples\006TOK - O Gymru.pdf", FileMode.OpenOrCreate );
        }

        public void OnPropertyChanged ( PropertyChangedEventArgs e )
        {
            if ( PropertyChanged != null )
                PropertyChanged ( this, e );
        }
    }
}
