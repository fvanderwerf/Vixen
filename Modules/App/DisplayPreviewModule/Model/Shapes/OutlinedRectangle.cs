﻿namespace VixenModules.App.DisplayPreview.Model.Shapes
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    [DataContract]
    internal class OutlinedRectangle : IShape
    {
        private double _strokeThickness;

        public OutlinedRectangle()
        {
            Initialize();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return "Outlined Rectangle";
            }
        }

        public ShapeType ShapeType
        {
            get
            {
                return ShapeType.OutlinedRectangle;
            }
        }

        [DataMember]
        public double StrokeThickness
        {
            get
            {
                return _strokeThickness;
            }

            set
            {
                _strokeThickness = value;
                PropertyChanged.NotifyPropertyChanged("StrokeThickness", this);
            }
        }

        public IShape Clone()
        {
            return new OutlinedRectangle { StrokeThickness = StrokeThickness };
        }

        private void Initialize()
        {
            _strokeThickness = 5;
        }

        [OnDeserializing]
        private void OnDeserializing(StreamingContext context)
        {
            Initialize();
        }
    }
}
