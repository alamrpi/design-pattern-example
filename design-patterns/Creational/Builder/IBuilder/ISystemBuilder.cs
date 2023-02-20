using design_patterns.Creational.Builder.Product;

namespace design_patterns.Creational.Builder.IBuilder
{
    public interface ISystemBuilder
    {
        ISystemBuilder AddMemory(string memory);
        ISystemBuilder AddDrive(string size);

        ISystemBuilder AddMouse(string type);
        ISystemBuilder AddKeyBoard(string type);

        ISystemBuilder AddTouchScreen(string enable);

        ComputerSystem GetSytem();
    }
}
