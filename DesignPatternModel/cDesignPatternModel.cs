using DesignPatternModel.CreatePattern;

namespace DesignPatternModel
{
    public class cDesignPatternModel
    {
        cCreatePattrernModel _createPattrernModel;

        public cCreatePattrernModel CreatePattrernModel
        {
            get
            {
                if (_createPattrernModel == null)
                {
                    _createPattrernModel = new cCreatePattrernModel();
                }
                return _createPattrernModel;
            }
        }
    }
}
