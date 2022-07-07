namespace UnitTest_Moq_Example
{
    public class Service
    {
        private readonly IFoo _foo;

        public Service(IFoo foo)
        {
            _foo = foo ?? throw new ArgumentNullException(nameof(foo));
        }
        public void Ping()
        {
            _foo.DoSomething("PING");
        }
    }
    public interface IFoo
    {
        bool DoSomething(string message);
    }
}