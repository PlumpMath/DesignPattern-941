using DesignPatternModel.CreatePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
