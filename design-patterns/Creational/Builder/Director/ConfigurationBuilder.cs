using design_patterns.Creational.Builder.IBuilder;
using System.Collections.Specialized;

namespace design_patterns.Creational.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systemBuilder, NameValueCollection collection)
        {
            systemBuilder.AddDrive(collection["Drive"])
            .AddMemory(collection["RAM"])
            .AddMouse(collection["Mouse"])
            .AddKeyBoard(collection["Keyboard"])
            .AddTouchScreen(collection["TouchScreen"]);
        }
    }
}
