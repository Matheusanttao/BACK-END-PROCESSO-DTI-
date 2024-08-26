using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

public class Aluno
{
    public List<int> Notas { get; set; }
    public string Nome { get; set; }
    public int Frequencia { get; set; }

    public double MediaNotas
    {
        get
        {
            if (Notas != null && Notas.Any())
            {
                return Notas.Average();
            }
            return 0;
        }
    }
}
