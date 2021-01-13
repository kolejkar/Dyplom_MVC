using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dyplom
{
    [Serializable]
    public class LogicSymbol
    {
        public string name;
        public string symbolFile;
        public List<ConnectPoint> connectPoints;
    }

    [Serializable]
    public class ConnectPoint
    {
        public double width;
        public double height;
        public ConnectType connectType;
    }

    public enum ConnectType
    {
        none = 0,
        input = 1,
        output = 2
    }
}