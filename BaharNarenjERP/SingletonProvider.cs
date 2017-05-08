using System.Windows.Forms;

namespace BaharNarenjERP
{
    public class SingletonProvider<T> where T : new()
    {
        SingletonProvider() { }

        public static T Instance
        {
            get
            {
                return SingletonCreator.Instance;
            }
        }

        class SingletonCreator
        {
            static SingletonCreator() { }
            private static T instance;
            public static T Instance
            {
                get
                {
                    var frm = instance as Form;
                    if (instance == null || frm.IsDisposed)
                        instance = new T();
                    return instance;
                }
            }
        }
    }
}
