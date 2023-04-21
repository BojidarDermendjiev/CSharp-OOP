namespace _01._Class_Box_Data.IO.Contracts
{
    public interface IWriter<T>
    {
        void Write(T message);
        void WriteLine(T message);
    }
}
