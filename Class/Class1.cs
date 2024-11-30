
namespace CS_inheritance.Class
{
    public class Human
    {
        private string? _name;
        private int? _age;
        private string? _phonenum;
        private string? _work;

        public string Name
        {
            get => _name ?? "No Name";
            set => _name = value;
        }
        public int Age
        {
            get => _age ?? 0;
            set => _age = value;
        }
        public string Phonenum
        {
            get => _phonenum ?? "No Phone Number";
            set => _phonenum = value;
        }
        public string Work
        {
            get => _work ?? "No Work";
            set => _work = value;
        }
        public Human(string? name, int ?age, string? phonenum, string? work)
        {
            _name = name;
            _age = age;
            _phonenum = phonenum;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Phone Number: {Phonenum}";
        }
    }
    public class Builder : Human
    {
        public Builder(string? name, int? age, string? phonenum) : base(name, age, phonenum, "Builder")
        {
        }
    }
    public class Sailor : Human
    {
        public Sailor(string? name, int? age, string? phonenum) : base(name, age, phonenum, "Sailor")
        {
        }
    }
    public class Pilot : Human
    {
        public Pilot(string? name, int? age, string? phonenum) : base(name, age, phonenum, "Pilot")
        {
        }
    }
}
