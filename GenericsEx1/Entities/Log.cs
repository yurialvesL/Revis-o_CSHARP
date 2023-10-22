namespace GenericsEx1.Entities
{
    public class Log
    {
        public string Nome { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return Nome.Equals(other.Nome);
        }
    }
}
