namespace exercicio_exceções.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
