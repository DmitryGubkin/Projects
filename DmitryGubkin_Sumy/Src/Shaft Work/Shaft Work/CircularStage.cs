﻿using System;

//Class for Circular stage
namespace Shaft_Work
{
    class CircularStage : IStage
    {
        public double R1
        {
            get { return r1; }
            set { r1 = value; }
        }

        public double R2
        {
            get { return r2; }
            set { r2 = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public object SOperation
        {
            get { return sOperation; }
            set { sOperation = value; }
        }

        public double SValue
        {
            get { return sValue; }
            set { sValue = value; }
        }

        public object EOperation
        {
            get { return eOperation; }
            set { eOperation = value; }
        }

        public double EValue
        {
            get { return eValue; }
            set { eValue = value; }
        }

        public Point2D P1
        {
            get { return p1; }
            set { p1 = value; }
        }

        public Point2D P2
        {
            get { return p2; }
            set { p2 = value; }
        }

        private double r1;
        private double r2;
        private double length;
        private object sOperation;
        private double sValue;
        private object eOperation;
        private double eValue;
        private Point2D p1;
        private Point2D p2;
        private IStageFeature Feature;


        public void GetParams(MainWindow window)
        {
            window._R1 = r1;
            window._R2 = r2;
            window._Length = length;
            window._Soperation = sOperation;
            window._Svalue = sValue;
            window._Eoperation = eOperation;
            window._Evalue = eValue;
            window._Profile = (object)"Circular";
            if (Feature != null)
            {
                Feature.GetParams(window);
            }
            else
            {
                window._Seating_type = (object)"None";
                window._KeyType = (object)"None";
                window._SplinedType = (object)"None";
                window._TheardUse = (object)"None";
            }
        }

        public void SetParams(double R1, double R2, double Length, object SOperation, double SValue, object EOperation,
            double EValue)
        {
            r1 = R1;
            r2 = R2;
            r2 = r1;
            length = Length;
            sOperation = SOperation;
            eOperation = EOperation;
            sValue = SValue;
            sValue = EValue;
            p1 = new Point2D(0, R1);
            p1 = new Point2D(length, R2);
            Feature = null;
        }


        public IStageFeature StageFeature
        {
            get { return Feature; }
            set { Feature = value; }
        }


        public CircularStage()
        {
            r1 = 10;
            r2 = 10;
            r2 = r1;
            length = 10;
            sOperation = (object)"None";
            sValue = 1;
            eOperation = (object)"None";
            eValue = 1;
            p1 = new Point2D(0, r1);
            p1 = new Point2D(10, r2);
            Feature = null;
        }


        ~CircularStage()
        {
            GC.Collect();
        }

 
    }
}
