using System;
using System.Collections.Generic;
using System.Linq;
using Dyplom;
using System.IO;

namespace TemplatesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating...");
            FileIO fileIO = new FileIO();

            ConnectPoint point;
            LogicSymbol symbol = new LogicSymbol();
            symbol.connectPoints = new List<ConnectPoint>();

            point = new ConnectPoint();
            point.width = 1;
            point.height = 0.5;
            point.connectType = ConnectType.output;
            symbol.connectPoints.Add(point);

            point = new ConnectPoint();
            point.width = 0;
            point.height = 0.5;
            point.connectType = ConnectType.input;
            symbol.connectPoints.Add(point);

            /*point = new ConnectPoint();
            point.width = 0;
            point.height = 0.70;
            point.connectType = ConnectType.input;
            symbol.connectPoints.Add(point);*/

            symbol.name = "MULTIPLEKSER";
            symbol.symbolFile = "/images/"+symbol.name+".png";

            fileIO.logicSymbols.Add(symbol);
            string path = Directory.GetCurrentDirectory();
            path = Directory.GetParent(path).FullName;
            path = Directory.GetParent(path).FullName;
            path = Directory.GetParent(path).FullName;
            path = Directory.GetParent(path).FullName;
            fileIO.SaveToFile(path+"/Dyplom/templates/"+symbol.name+".xml", symbol);

            Console.WriteLine("Done!");
        }
    }
}
