public interface IHeating
{
    int Limit { get;  }
    void GetStatus(int temp);
}
