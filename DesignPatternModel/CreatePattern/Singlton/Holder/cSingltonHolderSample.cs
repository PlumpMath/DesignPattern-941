namespace DesignPatternModel.CreatePattern.Singlton.Holder
{
    public class cSingltonHolderSample
    {
        //コンストラクタをprivateで定義して、外部からインスタンスが生成されない事を保証する。
        private cSingltonHolderSample()
        {
        }

        //インスタンスの取得
        public static cSingltonHolderSample GetInstance()
        {
            //ここでinnerSingletonHolderがロードされcTestClassのインスタンスが生成される。
            return innerSingletonHolder.Instance;
        }
        
        //インスタンスを保持する private static なinnerクラス
        private static class innerSingletonHolder
        {
            //ホルダークラスがロードされた際にインスタンスが生成される。
            private static cSingltonHolderSample _instance = new cSingltonHolderSample();

            //インスタンスを返却
            internal static cSingltonHolderSample Instance
            {
                get
                {
                    return _instance;
                }
            }
        }
    }
}
