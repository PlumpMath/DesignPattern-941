using DesignPatternModel.CreatePattern.FactoryMethod.Generic.Abstruct;
using DesignPatternModel.CreatePattern.FactoryMethod.Stantard;

namespace DesignPatternModel.CreatePattern.FactoryMethod.Generic
{
    class cStringListComparer
    {
        public cStringListComparer()
        {
            _dictionaryOrder = new genericCreator<cDictionaryOrderProduct>();
            _lengthOrder = new genericCreator<cLengthOrderProduct>();
        }

        genericCreator<cDictionaryOrderProduct> _dictionaryOrder;

        //五十音順でstringを取得
        internal genericCreator<cDictionaryOrderProduct> DictionaryOrder
        {
            get
            {
                return _dictionaryOrder;
            }
        }

        genericCreator<cLengthOrderProduct> _lengthOrder;

        //長さで順でstringを取得
        internal genericCreator<cLengthOrderProduct> LengthOrder
        {
            get
            {
                return _lengthOrder;
            }
        }
    }
}
