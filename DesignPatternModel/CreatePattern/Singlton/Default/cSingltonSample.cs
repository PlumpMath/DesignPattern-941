namespace DesignPatternModel.CreatePattern.Singlton.Default
{
    public class cSingltonSample
    {
        //コンストラクタをprivateで定義して、外部からインスタンスが生成されない事を保証する。
        private cSingltonSample()
        {
        }

        //cSingltonSampleクラスがロードされた際にインスタンスが生成される。
        //GetInstanceメソッドより前に生成される。
        private static cSingltonSample _instance = new cSingltonSample();
        
        //インスタンスの取得
        public static cSingltonSample GetInstance()
        {
            return _instance;
        }
    }
}
