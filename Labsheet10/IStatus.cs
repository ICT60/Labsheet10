namespace Labsheet10
{
    interface IStatus<T>
    {
        void FullRestore();
        void Clear();
        void Restore(T value);
        void Remove(T value);
    }
}
