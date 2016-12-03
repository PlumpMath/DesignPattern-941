using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DesignPatternModel.CreatePattern.Singlton.Multi
{
    public class cMultitonSample
    {
        //コンストラクタをprivateで定義して、外部からインスタンスが生成されない事を保証する。
        private cMultitonSample()
        {
        }

        //文字列をキーとして文字列に対応するインスタンスを保持
        static Dictionary<string, cMultitonSample> _dictionary = new Dictionary<string, cMultitonSample>();

        //インスタンスの取得
        //MethodImplOptions.Synchronized属性を指定して1つのスレッドだけでメソッドを実行させる。
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static cMultitonSample GetInstance(string key)
        {
            cMultitonSample instance;

            if (!_dictionary.TryGetValue(key, out instance))
            {
                instance = new cMultitonSample();
                _dictionary.Add(key, instance);
            }
            return instance;
        }
    }
}
