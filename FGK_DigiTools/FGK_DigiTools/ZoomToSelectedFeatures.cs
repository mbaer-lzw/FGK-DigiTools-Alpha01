﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows;


namespace FGK_DigiTools
{
    public class ZoomToSelectedFeatures : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        
        public ZoomToSelectedFeatures()
        {
        }

        protected override void OnClick()
        {
            //messagedebugger myform = new messagedebugger();
            //myform.ShowDialog();
            SetupPath path = new SetupPath(); //initialize new object from SetupPath class
            //System.Windows.Forms.MessageBox.Show(path.dir); //test path object with a windows messagebox

            
        }

        protected override void OnUpdate()
        {
        }
    }
}
