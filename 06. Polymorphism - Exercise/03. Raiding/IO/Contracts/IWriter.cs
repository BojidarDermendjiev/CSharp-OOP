namespace _03._Raiding.IO.Contracts
{
    public interface IWriter<T>
    {
        void Write(T value);
        void WriteLine(T value);
    }
}
