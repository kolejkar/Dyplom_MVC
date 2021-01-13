using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace Dyplom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SymbolPalettePalette> Palette = new List<SymbolPalettePalette>();

            List<DiagramNode> nodes = new List<DiagramNode>();

            FileIO fileIO = new FileIO();
            fileIO.LoadTemplates();
            foreach (LogicSymbol symbol in fileIO.logicSymbols)
            {
                int id = 0;
                List<DiagramPort> diagramPort = new List<DiagramPort>();
                if (symbol.connectPoints.Count > 0)
                {
                    foreach (ConnectPoint point in symbol.connectPoints)
                    {
                        string name;
                        PortConstraints constraints;
                        if (point.connectType == ConnectType.input)
                        {
                            name = "input" + id;
                            constraints = PortConstraints.InConnect;
                        }
                        else
                        if (point.connectType == ConnectType.output)
                        {
                            name = "output" + id;
                            constraints = PortConstraints.OutConnect;
                        }
                        else
                        {
                            name = "none" + id;
                            constraints = PortConstraints.None;
                        }
                        id++;
                        diagramPort.Add(new DiagramPort()
                        {
                            Id = name,
                            Constraints = constraints,
                            Shape = PortShapes.X,
                            Offset = new DiagramPoint()
                            {
                                X = point.width,
                                Y = point.height
                            }
                        });
                    }
                }

                nodes.Add(new Node()
                {
                    Id = symbol.name,
                    Width = 100,
                    Height = 100,
                    Style = new NodeStyleNodes() { Fill = "white" },
                    Shape = new { type = "Image", source = symbol.symbolFile, Scale = "Stretch" },
                    OffsetX = 100,
                    OffsetY = 100,
                    Constraints = NodeConstraints.Default & ~NodeConstraints.InConnect & ~NodeConstraints.OutConnect,
                    Ports = diagramPort
                });
            }

            List<DiagramConnector> Connectors = new List<DiagramConnector>();

            Connectors.Add(new DiagramConnector()
            {
                Id = "connector",
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow },
            });

            Palette.Add(new SymbolPalettePalette() { Id = "nodes", Expanded = true, Symbols = nodes, Title = "Funkcje logiczne" });
            Palette.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = Connectors, IconCss = "shapes", Title = "Połączenia" });
            ViewBag.Palette = Palette;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Praca dyplomowa  2021";

            return View();
        }
    }

    public class Node : DiagramNode
    {
        public string text;
    }
}