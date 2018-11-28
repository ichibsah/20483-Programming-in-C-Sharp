﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Win32;
using GradesPrototype.Controls;
using GradesPrototype.Data;
using GradesPrototype.Services;
using Newtonsoft.Json;

namespace GradesPrototype.Views
{
    internal class HelperClass
    {
        internal static void ReadFile(string gradesAsJson, out List<Grade> gradeList)
        {
            gradeList = JsonConvert.DeserializeObject<List<Grade>>(gradesAsJson);
        }
    }
}