class InvalidSoftwareDataException : Exception
{
    public InvalidSoftwareDataException() { }

    public InvalidSoftwareDataException(string message) : base(message) { }

    public override string ToString()
    {
        return $"[InvalidSoftwareDataException]: {Message}";
    }
}