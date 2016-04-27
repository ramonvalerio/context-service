namespace ContexB.Core.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool IsValid()
        {
            if (Id < 1)
                return false;

            if (string.IsNullOrWhiteSpace(Nome))
                return false;

            return true;
        }
    }
}
