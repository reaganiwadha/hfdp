namespace c09_DinerPancakeCafe
{
    public interface IIterator<out T>
    {
        bool HasNext();
        T Next();
    }
}