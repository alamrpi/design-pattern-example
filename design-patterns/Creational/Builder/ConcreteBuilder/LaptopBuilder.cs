using design_patterns.Creational.Builder.IBuilder;
using design_patterns.Creational.Builder.Product;
using System.Drawing;

namespace design_patterns.Creational.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();

        public ISystemBuilder AddDrive(string size)
        {
           laptop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyBoard(string type)
        {
            laptop.KeyBoard = type;
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            laptop.RAM = memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
           laptop.Mouse = type;
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enable)
        {
            laptop.TouchScreen = enable;
            return this;
        }

        public ComputerSystem GetSytem()
        {
           return laptop;
        }
    }
}
