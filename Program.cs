using Plugify;

namespace ExampleNamespace
{
    public class ExamplePlugin : Plugin
    {
        public void OnStart()
        {
            Console.WriteLine(".NET: OnStart");
        }
        
        /*public void OnUpdate(float dt) 
        {
            Console.WriteLine(".NET: OnUpdate");
        }*/

        public void OnEnd()
        {
            Console.WriteLine(".NET: OnEnd");
        }
        
        public static void MakePrint(int count, string message) 
        {
            for (int i = 0; i < count; ++i) {
                Console.WriteLine(message);
            }
        }
    }
}