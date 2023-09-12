
using System.Reflection.PortableExecutable;

namespace Secao6_vectors
{
    internal class ExerciseVectorsStudents
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public ExerciseVectorsStudents(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        } 

    }
}
