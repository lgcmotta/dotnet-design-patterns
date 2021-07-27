using System.Collections.ObjectModel;
using System.Text;

namespace DesignPatterns.Structural.Composites
{
    public class Composite : Collection<IComponent>, IComponent
    {
        public string Operation()
        {
            var stringBuilder = new StringBuilder().Append($"{nameof(Composite)}(");

            for (var index = 0; index < Items.Count; index++)
            {
                var component = Items[index];

                stringBuilder.Append(component.Operation());
                
                if (index < Items.Count - 1)
                    stringBuilder.Append('+');
            }

            return stringBuilder.Append(')').ToString();
        }
    }
}