using System.Threading.Tasks;

namespace DesignPatterns.Factories.Asynchronous
{
    public class Sloth
    {
        private Sloth()
        {
            
        }

        public static async Task<Sloth> NewSloth()
        {
            await Task.Delay(1000);

            return new Sloth();
        }
    }
}