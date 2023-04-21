namespace _04._Pizza_Calories.IO.Contracts
{
    public interface IWriter<T>
    {
        public void Write(T value); 
        public void WriteLine(T value);
    }
}
