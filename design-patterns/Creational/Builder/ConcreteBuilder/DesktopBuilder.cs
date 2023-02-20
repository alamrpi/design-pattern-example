using design_patterns.Creational.Builder.IBuilder;
using design_patterns.Creational.Builder.Product;

namespace design_patterns.Creational.Builder.ConcreteBuilder
{
    internal class DesktopBuilder : ISystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();

        public ISystemBuilder AddDrive(string size)
        {
            desktop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyBoard(string type)
        {
            desktop.KeyBoard = type;
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            desktop.RAM = memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
            desktop.Mouse = type; 
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enable)
        {
            return this;
        }

        public ComputerSystem GetSytem()
        {
            return desktop;
        }
    }
}
