using Newtonsoft.Json;

namespace DesignPatterns.Creational.Prototypes.Serialization
{
    public static class NodeExtensions
    {
        public static Node DeepCloneThroughJsonSerialization(this Node node)
        {
            var serialized = JsonConvert.SerializeObject(node);

            return JsonConvert.DeserializeObject<Node>(serialized);
        }
    }
}