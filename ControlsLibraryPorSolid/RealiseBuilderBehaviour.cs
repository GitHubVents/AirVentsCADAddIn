using SolidWorksLibrary;

namespace ControlsLibrary
{
    class RealiseBuilderBehaviour : SolidWorksLibrary.Builders.ElementsCase.ProductBuilderBehavior
    {
        public RealiseBuilderBehaviour()
        {

        }
    }

    public class PathValidity
    {
        public PathValidity(string path, bool exists)
        {
            _Path = path;
            Exsists = exists;
        }
        public string _Path { get; set; }
        public bool Exsists { get; set; }
    }
}